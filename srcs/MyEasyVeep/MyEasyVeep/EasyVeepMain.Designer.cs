namespace MyEasyVeep
{
    partial class EasyVeepMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyVeepMain));
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.gdProcesses = new System.Windows.Forms.GroupBox();
            this.lblProcess = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbModelInfo = new System.Windows.Forms.GroupBox();
            this.dataGridInOutVal = new System.Windows.Forms.DataGridView();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblProcessDesc = new System.Windows.Forms.Label();
            this.groupIOSensors = new System.Windows.Forms.GroupBox();
            this.btnDS9 = new System.Windows.Forms.Button();
            this.btnDS10 = new System.Windows.Forms.Button();
            this.btnDS11 = new System.Windows.Forms.Button();
            this.btnDS12 = new System.Windows.Forms.Button();
            this.btnDS13 = new System.Windows.Forms.Button();
            this.btnDS14 = new System.Windows.Forms.Button();
            this.btnDS15 = new System.Windows.Forms.Button();
            this.btnDS16 = new System.Windows.Forms.Button();
            this.btnDS5 = new System.Windows.Forms.Button();
            this.btnDS6 = new System.Windows.Forms.Button();
            this.btnDS7 = new System.Windows.Forms.Button();
            this.btnDS8 = new System.Windows.Forms.Button();
            this.btnDS4 = new System.Windows.Forms.Button();
            this.btnDS3 = new System.Windows.Forms.Button();
            this.btnDS2 = new System.Windows.Forms.Button();
            this.btnDS1 = new System.Windows.Forms.Button();
            this.btnDA9 = new System.Windows.Forms.Button();
            this.btnDA10 = new System.Windows.Forms.Button();
            this.btnDA11 = new System.Windows.Forms.Button();
            this.btnDA12 = new System.Windows.Forms.Button();
            this.btnDA13 = new System.Windows.Forms.Button();
            this.btnDA14 = new System.Windows.Forms.Button();
            this.btnDA15 = new System.Windows.Forms.Button();
            this.btnDA16 = new System.Windows.Forms.Button();
            this.btnDA5 = new System.Windows.Forms.Button();
            this.btnDA6 = new System.Windows.Forms.Button();
            this.btnDA7 = new System.Windows.Forms.Button();
            this.btnDA8 = new System.Windows.Forms.Button();
            this.btnDA4 = new System.Windows.Forms.Button();
            this.btnDA3 = new System.Windows.Forms.Button();
            this.btnDA2 = new System.Windows.Forms.Button();
            this.btnDA1 = new System.Windows.Forms.Button();
            this.groupIOActuators = new System.Windows.Forms.GroupBox();
            this.inputUpdateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.gdProcesses.SuspendLayout();
            this.gbModelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInOutVal)).BeginInit();
            this.groupIOSensors.SuspendLayout();
            this.groupIOActuators.SuspendLayout();
            this.SuspendLayout();
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(582, 17);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(329, 506);
            this.axShockwaveFlash1.TabIndex = 0;
            // 
            // gdProcesses
            // 
            this.gdProcesses.Controls.Add(this.lblProcess);
            this.gdProcesses.Controls.Add(this.comboBox1);
            this.gdProcesses.Location = new System.Drawing.Point(13, 13);
            this.gdProcesses.Name = "gdProcesses";
            this.gdProcesses.Size = new System.Drawing.Size(472, 57);
            this.gdProcesses.TabIndex = 1;
            this.gdProcesses.TabStop = false;
            this.gdProcesses.Text = "EasyVeep Processes";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(7, 23);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(78, 13);
            this.lblProcess.TabIndex = 1;
            this.lblProcess.Text = "Select Process";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gbModelInfo
            // 
            this.gbModelInfo.Controls.Add(this.dataGridInOutVal);
            this.gbModelInfo.Controls.Add(this.txtDesc);
            this.gbModelInfo.Controls.Add(this.lblProcessDesc);
            this.gbModelInfo.Location = new System.Drawing.Point(13, 77);
            this.gbModelInfo.Name = "gbModelInfo";
            this.gbModelInfo.Size = new System.Drawing.Size(472, 451);
            this.gbModelInfo.TabIndex = 2;
            this.gbModelInfo.TabStop = false;
            this.gbModelInfo.Text = "Process Info";
            // 
            // dataGridInOutVal
            // 
            this.dataGridInOutVal.AllowUserToAddRows = false;
            this.dataGridInOutVal.AllowUserToDeleteRows = false;
            this.dataGridInOutVal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInOutVal.Location = new System.Drawing.Point(15, 161);
            this.dataGridInOutVal.Name = "dataGridInOutVal";
            this.dataGridInOutVal.ReadOnly = true;
            this.dataGridInOutVal.Size = new System.Drawing.Size(435, 274);
            this.dataGridInOutVal.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(73, 32);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(377, 115);
            this.txtDesc.TabIndex = 1;
            // 
            // lblProcessDesc
            // 
            this.lblProcessDesc.AutoSize = true;
            this.lblProcessDesc.Location = new System.Drawing.Point(12, 27);
            this.lblProcessDesc.Name = "lblProcessDesc";
            this.lblProcessDesc.Size = new System.Drawing.Size(60, 13);
            this.lblProcessDesc.TabIndex = 0;
            this.lblProcessDesc.Text = "Description";
            // 
            // groupIOSensors
            // 
            this.groupIOSensors.Controls.Add(this.btnDS9);
            this.groupIOSensors.Controls.Add(this.btnDS10);
            this.groupIOSensors.Controls.Add(this.btnDS11);
            this.groupIOSensors.Controls.Add(this.btnDS12);
            this.groupIOSensors.Controls.Add(this.btnDS13);
            this.groupIOSensors.Controls.Add(this.btnDS14);
            this.groupIOSensors.Controls.Add(this.btnDS15);
            this.groupIOSensors.Controls.Add(this.btnDS16);
            this.groupIOSensors.Controls.Add(this.btnDS5);
            this.groupIOSensors.Controls.Add(this.btnDS6);
            this.groupIOSensors.Controls.Add(this.btnDS7);
            this.groupIOSensors.Controls.Add(this.btnDS8);
            this.groupIOSensors.Controls.Add(this.btnDS4);
            this.groupIOSensors.Controls.Add(this.btnDS3);
            this.groupIOSensors.Controls.Add(this.btnDS2);
            this.groupIOSensors.Controls.Add(this.btnDS1);
            this.groupIOSensors.Location = new System.Drawing.Point(492, 13);
            this.groupIOSensors.Name = "groupIOSensors";
            this.groupIOSensors.Size = new System.Drawing.Size(84, 515);
            this.groupIOSensors.TabIndex = 3;
            this.groupIOSensors.TabStop = false;
            this.groupIOSensors.Text = "Sensors";
            // 
            // btnDS9
            // 
            this.btnDS9.Location = new System.Drawing.Point(22, 273);
            this.btnDS9.Name = "btnDS9";
            this.btnDS9.Size = new System.Drawing.Size(47, 23);
            this.btnDS9.TabIndex = 15;
            this.btnDS9.Text = "DS9";
            this.btnDS9.UseVisualStyleBackColor = true;
            // 
            // btnDS10
            // 
            this.btnDS10.Location = new System.Drawing.Point(22, 303);
            this.btnDS10.Name = "btnDS10";
            this.btnDS10.Size = new System.Drawing.Size(47, 23);
            this.btnDS10.TabIndex = 14;
            this.btnDS10.Text = "DS10";
            this.btnDS10.UseVisualStyleBackColor = true;
            // 
            // btnDS11
            // 
            this.btnDS11.Location = new System.Drawing.Point(22, 332);
            this.btnDS11.Name = "btnDS11";
            this.btnDS11.Size = new System.Drawing.Size(47, 23);
            this.btnDS11.TabIndex = 13;
            this.btnDS11.Text = "DS11";
            this.btnDS11.UseVisualStyleBackColor = true;
            // 
            // btnDS12
            // 
            this.btnDS12.Location = new System.Drawing.Point(22, 361);
            this.btnDS12.Name = "btnDS12";
            this.btnDS12.Size = new System.Drawing.Size(47, 23);
            this.btnDS12.TabIndex = 12;
            this.btnDS12.Text = "DS12";
            this.btnDS12.UseVisualStyleBackColor = true;
            // 
            // btnDS13
            // 
            this.btnDS13.Location = new System.Drawing.Point(23, 390);
            this.btnDS13.Name = "btnDS13";
            this.btnDS13.Size = new System.Drawing.Size(46, 23);
            this.btnDS13.TabIndex = 11;
            this.btnDS13.Text = "DS13";
            this.btnDS13.UseVisualStyleBackColor = true;
            // 
            // btnDS14
            // 
            this.btnDS14.Location = new System.Drawing.Point(23, 418);
            this.btnDS14.Name = "btnDS14";
            this.btnDS14.Size = new System.Drawing.Size(46, 23);
            this.btnDS14.TabIndex = 10;
            this.btnDS14.Text = "DS14";
            this.btnDS14.UseVisualStyleBackColor = true;
            // 
            // btnDS15
            // 
            this.btnDS15.Location = new System.Drawing.Point(23, 447);
            this.btnDS15.Name = "btnDS15";
            this.btnDS15.Size = new System.Drawing.Size(46, 23);
            this.btnDS15.TabIndex = 9;
            this.btnDS15.Text = "DS15";
            this.btnDS15.UseVisualStyleBackColor = true;
            // 
            // btnDS16
            // 
            this.btnDS16.Location = new System.Drawing.Point(23, 476);
            this.btnDS16.Name = "btnDS16";
            this.btnDS16.Size = new System.Drawing.Size(46, 23);
            this.btnDS16.TabIndex = 8;
            this.btnDS16.Text = "DS16";
            this.btnDS16.UseVisualStyleBackColor = true;
            // 
            // btnDS5
            // 
            this.btnDS5.Location = new System.Drawing.Point(22, 158);
            this.btnDS5.Name = "btnDS5";
            this.btnDS5.Size = new System.Drawing.Size(46, 23);
            this.btnDS5.TabIndex = 7;
            this.btnDS5.Text = "DS5";
            this.btnDS5.UseVisualStyleBackColor = true;
            // 
            // btnDS6
            // 
            this.btnDS6.Location = new System.Drawing.Point(22, 186);
            this.btnDS6.Name = "btnDS6";
            this.btnDS6.Size = new System.Drawing.Size(46, 23);
            this.btnDS6.TabIndex = 6;
            this.btnDS6.Text = "DS6";
            this.btnDS6.UseVisualStyleBackColor = true;
            // 
            // btnDS7
            // 
            this.btnDS7.Location = new System.Drawing.Point(22, 215);
            this.btnDS7.Name = "btnDS7";
            this.btnDS7.Size = new System.Drawing.Size(46, 23);
            this.btnDS7.TabIndex = 5;
            this.btnDS7.Text = "DS7";
            this.btnDS7.UseVisualStyleBackColor = true;
            // 
            // btnDS8
            // 
            this.btnDS8.Location = new System.Drawing.Point(22, 244);
            this.btnDS8.Name = "btnDS8";
            this.btnDS8.Size = new System.Drawing.Size(46, 23);
            this.btnDS8.TabIndex = 4;
            this.btnDS8.Text = "DS8";
            this.btnDS8.UseVisualStyleBackColor = true;
            // 
            // btnDS4
            // 
            this.btnDS4.Location = new System.Drawing.Point(22, 129);
            this.btnDS4.Name = "btnDS4";
            this.btnDS4.Size = new System.Drawing.Size(46, 23);
            this.btnDS4.TabIndex = 3;
            this.btnDS4.Text = "DS4";
            this.btnDS4.UseVisualStyleBackColor = true;
            // 
            // btnDS3
            // 
            this.btnDS3.Location = new System.Drawing.Point(22, 100);
            this.btnDS3.Name = "btnDS3";
            this.btnDS3.Size = new System.Drawing.Size(46, 23);
            this.btnDS3.TabIndex = 2;
            this.btnDS3.Text = "DS3";
            this.btnDS3.UseVisualStyleBackColor = true;
            // 
            // btnDS2
            // 
            this.btnDS2.Location = new System.Drawing.Point(22, 71);
            this.btnDS2.Name = "btnDS2";
            this.btnDS2.Size = new System.Drawing.Size(46, 23);
            this.btnDS2.TabIndex = 1;
            this.btnDS2.Text = "DS2";
            this.btnDS2.UseVisualStyleBackColor = true;
            // 
            // btnDS1
            // 
            this.btnDS1.Location = new System.Drawing.Point(22, 41);
            this.btnDS1.Name = "btnDS1";
            this.btnDS1.Size = new System.Drawing.Size(46, 23);
            this.btnDS1.TabIndex = 0;
            this.btnDS1.Text = "DS1";
            this.btnDS1.UseVisualStyleBackColor = true;
            // 
            // btnDA9
            // 
            this.btnDA9.Location = new System.Drawing.Point(19, 269);
            this.btnDA9.Name = "btnDA9";
            this.btnDA9.Size = new System.Drawing.Size(47, 23);
            this.btnDA9.TabIndex = 31;
            this.btnDA9.Text = "DA9";
            this.btnDA9.UseVisualStyleBackColor = true;
            // 
            // btnDA10
            // 
            this.btnDA10.Location = new System.Drawing.Point(19, 299);
            this.btnDA10.Name = "btnDA10";
            this.btnDA10.Size = new System.Drawing.Size(47, 23);
            this.btnDA10.TabIndex = 30;
            this.btnDA10.Text = "DA10";
            this.btnDA10.UseVisualStyleBackColor = true;
            // 
            // btnDA11
            // 
            this.btnDA11.Location = new System.Drawing.Point(19, 328);
            this.btnDA11.Name = "btnDA11";
            this.btnDA11.Size = new System.Drawing.Size(47, 23);
            this.btnDA11.TabIndex = 29;
            this.btnDA11.Text = "DA11";
            this.btnDA11.UseVisualStyleBackColor = true;
            // 
            // btnDA12
            // 
            this.btnDA12.Location = new System.Drawing.Point(19, 357);
            this.btnDA12.Name = "btnDA12";
            this.btnDA12.Size = new System.Drawing.Size(47, 23);
            this.btnDA12.TabIndex = 28;
            this.btnDA12.Text = "DA12";
            this.btnDA12.UseVisualStyleBackColor = true;
            // 
            // btnDA13
            // 
            this.btnDA13.Location = new System.Drawing.Point(20, 386);
            this.btnDA13.Name = "btnDA13";
            this.btnDA13.Size = new System.Drawing.Size(46, 23);
            this.btnDA13.TabIndex = 27;
            this.btnDA13.Text = "DA13";
            this.btnDA13.UseVisualStyleBackColor = true;
            // 
            // btnDA14
            // 
            this.btnDA14.Location = new System.Drawing.Point(20, 414);
            this.btnDA14.Name = "btnDA14";
            this.btnDA14.Size = new System.Drawing.Size(46, 23);
            this.btnDA14.TabIndex = 26;
            this.btnDA14.Text = "DA14";
            this.btnDA14.UseVisualStyleBackColor = true;
            // 
            // btnDA15
            // 
            this.btnDA15.Location = new System.Drawing.Point(20, 443);
            this.btnDA15.Name = "btnDA15";
            this.btnDA15.Size = new System.Drawing.Size(46, 23);
            this.btnDA15.TabIndex = 25;
            this.btnDA15.Text = "DA15";
            this.btnDA15.UseVisualStyleBackColor = true;
            // 
            // btnDA16
            // 
            this.btnDA16.Location = new System.Drawing.Point(20, 472);
            this.btnDA16.Name = "btnDA16";
            this.btnDA16.Size = new System.Drawing.Size(46, 23);
            this.btnDA16.TabIndex = 24;
            this.btnDA16.Text = "DA16";
            this.btnDA16.UseVisualStyleBackColor = true;
            // 
            // btnDA5
            // 
            this.btnDA5.Location = new System.Drawing.Point(20, 154);
            this.btnDA5.Name = "btnDA5";
            this.btnDA5.Size = new System.Drawing.Size(46, 23);
            this.btnDA5.TabIndex = 23;
            this.btnDA5.Text = "DA5";
            this.btnDA5.UseVisualStyleBackColor = true;
            // 
            // btnDA6
            // 
            this.btnDA6.Location = new System.Drawing.Point(20, 182);
            this.btnDA6.Name = "btnDA6";
            this.btnDA6.Size = new System.Drawing.Size(46, 23);
            this.btnDA6.TabIndex = 22;
            this.btnDA6.Text = "DA6";
            this.btnDA6.UseVisualStyleBackColor = true;
            // 
            // btnDA7
            // 
            this.btnDA7.Location = new System.Drawing.Point(20, 211);
            this.btnDA7.Name = "btnDA7";
            this.btnDA7.Size = new System.Drawing.Size(46, 23);
            this.btnDA7.TabIndex = 21;
            this.btnDA7.Text = "DA7";
            this.btnDA7.UseVisualStyleBackColor = true;
            // 
            // btnDA8
            // 
            this.btnDA8.Location = new System.Drawing.Point(20, 240);
            this.btnDA8.Name = "btnDA8";
            this.btnDA8.Size = new System.Drawing.Size(46, 23);
            this.btnDA8.TabIndex = 20;
            this.btnDA8.Text = "DA8";
            this.btnDA8.UseVisualStyleBackColor = true;
            // 
            // btnDA4
            // 
            this.btnDA4.Location = new System.Drawing.Point(20, 125);
            this.btnDA4.Name = "btnDA4";
            this.btnDA4.Size = new System.Drawing.Size(46, 23);
            this.btnDA4.TabIndex = 19;
            this.btnDA4.Text = "DA4";
            this.btnDA4.UseVisualStyleBackColor = true;
            // 
            // btnDA3
            // 
            this.btnDA3.Location = new System.Drawing.Point(20, 96);
            this.btnDA3.Name = "btnDA3";
            this.btnDA3.Size = new System.Drawing.Size(46, 23);
            this.btnDA3.TabIndex = 18;
            this.btnDA3.Text = "DA3";
            this.btnDA3.UseVisualStyleBackColor = true;
            // 
            // btnDA2
            // 
            this.btnDA2.Location = new System.Drawing.Point(20, 67);
            this.btnDA2.Name = "btnDA2";
            this.btnDA2.Size = new System.Drawing.Size(46, 23);
            this.btnDA2.TabIndex = 17;
            this.btnDA2.Text = "DA2";
            this.btnDA2.UseVisualStyleBackColor = true;
            // 
            // btnDA1
            // 
            this.btnDA1.Location = new System.Drawing.Point(20, 37);
            this.btnDA1.Name = "btnDA1";
            this.btnDA1.Size = new System.Drawing.Size(46, 23);
            this.btnDA1.TabIndex = 16;
            this.btnDA1.Text = "DA1";
            this.btnDA1.UseVisualStyleBackColor = true;
            // 
            // groupIOActuators
            // 
            this.groupIOActuators.Controls.Add(this.btnDA1);
            this.groupIOActuators.Controls.Add(this.btnDA7);
            this.groupIOActuators.Controls.Add(this.btnDA9);
            this.groupIOActuators.Controls.Add(this.btnDA6);
            this.groupIOActuators.Controls.Add(this.btnDA10);
            this.groupIOActuators.Controls.Add(this.btnDA8);
            this.groupIOActuators.Controls.Add(this.btnDA5);
            this.groupIOActuators.Controls.Add(this.btnDA11);
            this.groupIOActuators.Controls.Add(this.btnDA3);
            this.groupIOActuators.Controls.Add(this.btnDA2);
            this.groupIOActuators.Controls.Add(this.btnDA12);
            this.groupIOActuators.Controls.Add(this.btnDA4);
            this.groupIOActuators.Controls.Add(this.btnDA13);
            this.groupIOActuators.Controls.Add(this.btnDA16);
            this.groupIOActuators.Controls.Add(this.btnDA14);
            this.groupIOActuators.Controls.Add(this.btnDA15);
            this.groupIOActuators.Location = new System.Drawing.Point(917, 17);
            this.groupIOActuators.Name = "groupIOActuators";
            this.groupIOActuators.Size = new System.Drawing.Size(81, 511);
            this.groupIOActuators.TabIndex = 32;
            this.groupIOActuators.TabStop = false;
            this.groupIOActuators.Text = "Actuators";
            // 
            // inputUpdateTimer
            // 
            this.inputUpdateTimer.Interval = 67;
            this.inputUpdateTimer.Tick += new System.EventHandler(this.inputUpdateTimer_Tick);
            // 
            // EasyVeepMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 535);
            this.Controls.Add(this.groupIOActuators);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Controls.Add(this.groupIOSensors);
            this.Controls.Add(this.gbModelInfo);
            this.Controls.Add(this.gdProcesses);
            this.Name = "EasyVeepMain";
            this.Text = "MyEasyVeep";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.gdProcesses.ResumeLayout(false);
            this.gdProcesses.PerformLayout();
            this.gbModelInfo.ResumeLayout(false);
            this.gbModelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInOutVal)).EndInit();
            this.groupIOSensors.ResumeLayout(false);
            this.groupIOActuators.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private System.Windows.Forms.GroupBox gdProcesses;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbModelInfo;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblProcessDesc;
        private System.Windows.Forms.DataGridView dataGridInOutVal;
        private System.Windows.Forms.GroupBox groupIOSensors;
        private System.Windows.Forms.Button btnDS9;
        private System.Windows.Forms.Button btnDS10;
        private System.Windows.Forms.Button btnDS11;
        private System.Windows.Forms.Button btnDS12;
        private System.Windows.Forms.Button btnDS13;
        private System.Windows.Forms.Button btnDS14;
        private System.Windows.Forms.Button btnDS15;
        private System.Windows.Forms.Button btnDS16;
        private System.Windows.Forms.Button btnDS5;
        private System.Windows.Forms.Button btnDS6;
        private System.Windows.Forms.Button btnDS7;
        private System.Windows.Forms.Button btnDS8;
        private System.Windows.Forms.Button btnDS4;
        private System.Windows.Forms.Button btnDS3;
        private System.Windows.Forms.Button btnDS2;
        private System.Windows.Forms.Button btnDS1;
        private System.Windows.Forms.Button btnDA9;
        private System.Windows.Forms.Button btnDA10;
        private System.Windows.Forms.Button btnDA11;
        private System.Windows.Forms.Button btnDA12;
        private System.Windows.Forms.Button btnDA13;
        private System.Windows.Forms.Button btnDA14;
        private System.Windows.Forms.Button btnDA15;
        private System.Windows.Forms.Button btnDA16;
        private System.Windows.Forms.Button btnDA5;
        private System.Windows.Forms.Button btnDA6;
        private System.Windows.Forms.Button btnDA7;
        private System.Windows.Forms.Button btnDA8;
        private System.Windows.Forms.Button btnDA4;
        private System.Windows.Forms.Button btnDA3;
        private System.Windows.Forms.Button btnDA2;
        private System.Windows.Forms.Button btnDA1;
        private System.Windows.Forms.GroupBox groupIOActuators;
        private System.Windows.Forms.Timer inputUpdateTimer;
    }
}

