namespace MyEasyVeep
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.gdProcesses = new System.Windows.Forms.GroupBox();
            this.lblProcess = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbModelInfo = new System.Windows.Forms.GroupBox();
            this.dataGridInOutVal = new System.Windows.Forms.DataGridView();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblProcessDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.gdProcesses.SuspendLayout();
            this.gbModelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInOutVal)).BeginInit();
            this.SuspendLayout();
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(554, 12);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(661, 634);
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
            this.gbModelInfo.Size = new System.Drawing.Size(472, 569);
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
            this.dataGridInOutVal.Size = new System.Drawing.Size(435, 389);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 661);
            this.Controls.Add(this.gbModelInfo);
            this.Controls.Add(this.gdProcesses);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.gdProcesses.ResumeLayout(false);
            this.gdProcesses.PerformLayout();
            this.gbModelInfo.ResumeLayout(false);
            this.gbModelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInOutVal)).EndInit();
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
    }
}

