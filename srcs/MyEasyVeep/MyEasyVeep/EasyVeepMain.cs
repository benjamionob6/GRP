using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Timers;

using System.Windows.Forms;
using System.IO;

namespace MyEasyVeep
{
    public partial class EasyVeepMain : Form
    {
        private ProcessInfo movieInfo = new ProcessInfo();
        
        public EasyVeepMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateProcessBox();

            groupIOSensors.Enabled = false;
            
        }


        private void PopulateProcessBox()
        {
            var swfFiles = Directory.GetFiles(Application.StartupPath + @"\swf");
            List<ProcessListItem> Processes = new List<ProcessListItem>();

            foreach (var swfFile in swfFiles)
            {
                axShockwaveFlash1.LoadMovie(0, swfFile);
                string ProgName = axShockwaveFlash1.GetVariable("EprgName");
                Match FileNumMatch = Regex.Match(swfFile, @"(\d+)\.swf$");
                if (FileNumMatch.Success && FileNumMatch.Groups != null && FileNumMatch.Groups.Count > 1)
                {
                    int fileNumber = Int32.Parse(FileNumMatch.Groups[1].ToString());
                    Processes.Add(new ProcessListItem(ProgName, fileNumber));
                }
                else
                    throw new Exception(String.Format("Unable to parse file number from swf file path {0}", swfFile));
            }

	    //Linq has made me a bad programmer
            Processes = Processes.OrderBy(l=>l.Text).ToList();
	    var selectionIndex = Processes.IndexOf(Processes.Where(m=>m.Value==1).FirstOrDefault());

            comboBox1.Items.AddRange(Processes.ToArray());

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = selectionIndex;

                //Load up the default movie in this case
                axShockwaveFlash1.LoadMovie(0,swfFiles.First());
                axShockwaveFlash1.Play();
                axShockwaveFlash1.GotoFrame(1);
                UpdateProcessInfoDisplay(GetProcessInfo());
            }
            else
            {
                //Do we need to say something, hell yeah we do.
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
	    //Stop any timers we have running
            inputUpdateTimer.Stop();

            ProcessListItem CurrentItem = (ProcessListItem)comboBox1.SelectedItem;
            string filePath = String.Format(@"{0}\swf\{1}.swf",Application.StartupPath,CurrentItem.Value);

            axShockwaveFlash1.LoadMovie(0,filePath);
            axShockwaveFlash1.Play();
            UpdateProcessInfoDisplay(GetProcessInfo());

	    //Spool up the timer
            inputUpdateTimer.Enabled = true;
            inputUpdateTimer.Start();
        }

        private void UpdateProcessInfoDisplay(ProcessInfo Info){
            txtDesc.Text = Info.ProcessDescription;
            DataTable InOutData = new DataTable();

            InOutData.Columns.Add("Index");
            InOutData.Columns.Add("Sensor");
            InOutData.Columns.Add("Actuator");

            for (int i = 1; i <= 16; i++)
            {
                InOutData.Rows.Add(i, (Info.Sensors[i-1] != null ? Info.Sensors[i-1].SensorRole : "" ), ( Info.Actuators[i-1] != null ? Info.Actuators[i-1].ActuatorRole : ""));
                ((Button)(groupIOActuators.Controls.Find(String.Format("btnDA{0}", i), true).FirstOrDefault())).Visible = Info.Actuators[i - 1] != null;
                ((Button)(groupIOSensors.Controls.Find(String.Format("btnDS{0}", i), true).FirstOrDefault())).Visible = Info.Sensors[i - 1] != null;
            }

            dataGridInOutVal.DataSource = InOutData;
            dataGridInOutVal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private ProcessInfo GetProcessInfo()
        {

            movieInfo = new ProcessInfo();

            string ProcessDescription = "";
            int ProcessDescriptionIndex = 0; 
            string SensorDescription = "";
            int SensorDescriptionIndex = 1; 
            string ActuatorDescription = "";
            int ActuatorDescriptionIndex = 1;

            movieInfo.ProcessDescription = axShockwaveFlash1.GetVariable("EprgName");


            //We are going to iterate through the process description variables until we hit and empty one
            do
            {
                //I'm not much for Hungarian, but this means English Program Description
                ProcessDescription = axShockwaveFlash1.GetVariable(String.Format("EprgLeiras{0}", ProcessDescriptionIndex > 0 ? ProcessDescriptionIndex.ToString() : ""));
                movieInfo.ProcessDescription += " " + ProcessDescription;
                ProcessDescriptionIndex++;

            } while (ProcessDescription != "" && ProcessDescriptionIndex <= 10 );
            
            //Keep up the show for Actuators and Outputs
            do
            {
                SensorDescription = axShockwaveFlash1.GetVariable(String.Format("EDigSens{0}", SensorDescriptionIndex));
                if ( SensorDescription != "" )
                    movieInfo.Sensors[SensorDescriptionIndex-1] = new DigitalSensor(SensorDescription, SensorDescriptionIndex);

                SensorDescriptionIndex++;
            } while (SensorDescription != "" && SensorDescriptionIndex <= 16);

            do
            {
                ActuatorDescription = axShockwaveFlash1.GetVariable(String.Format("EDigAct{0}", ActuatorDescriptionIndex));
                if (ActuatorDescription != "" )
                    movieInfo.Actuators[ActuatorDescriptionIndex-1] = new DigitalActuator(ActuatorDescription, ActuatorDescriptionIndex);

                ActuatorDescriptionIndex++;
            } while (ActuatorDescription != "" && ActuatorDescriptionIndex <= 16);


            return movieInfo;
        }

        private void inputUpdateTimer_Tick(object sender, EventArgs e)
        {
	    //Get those sexy sensor values
            foreach (DigitalSensor ds in movieInfo.Sensors)
            {
                if (ds == null)
                    break;

                var sensorValue = axShockwaveFlash1.GetVariable(String.Format("DS{0}", ds.SensorIndex));
                Button buttonControl = groupIOSensors.Controls.Find(String.Format("btnDS{0}", ds.SensorIndex), true).FirstOrDefault() as Button;
		if ( buttonControl != null )
		    buttonControl.BackColor = ( sensorValue == "1" ? Color.Yellow : Control.DefaultBackColor );

            }   
        }

    }

    public class ProcessInfo
    {
        public string ProcessDescription { get; set; }
        public DigitalSensor[] Sensors { get; set; }
        public DigitalActuator[] Actuators { get; set; }

        public ProcessInfo()
        {
            Sensors = new DigitalSensor[16];
            Actuators = new DigitalActuator[16];
            ProcessDescription = "SET DESCRIPTION";
        }
    }

    public class DigitalSensor
    {
        public int SensorIndex { get; set; }
        public string SensorRole { get; set; }

        public DigitalSensor(string SensorRole, int SensorIndex)
        {
            this.SensorIndex = SensorIndex;
            this.SensorRole = SensorRole;
        }                    
    }

    public class DigitalActuator
    {
        public int ActuatorIndex { get; set; }
        public string ActuatorRole { get; set; }

        public DigitalActuator(string ActuatorRole, int ActuatorIndex)
        {
            this.ActuatorIndex = ActuatorIndex;
            this.ActuatorRole = ActuatorRole;
        }                    
    }

    public class ProcessListItem {
        public int Value { get; set; }
        public string Text { get; set; }

        public ProcessListItem(string Text, int Value)
        {
            this.Value = Value;
            this.Text = Text;
        }

        public override string ToString()
        {
            return this.Text;
        }
    }

}
