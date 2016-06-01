namespace SwissTransportApplication
{
    partial class frmConnections
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
            this.btnShowConnections = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridConnections = new System.Windows.Forms.DataGridView();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.rbConnections = new System.Windows.Forms.RadioButton();
            this.rbStationBoard = new System.Windows.Forms.RadioButton();
            this.lblTitel = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnSendviaMail = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.linkStartstationOnMaps = new System.Windows.Forms.LinkLabel();
            this.linkEndstationOnMaps = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConnections)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowConnections
            // 
            this.btnShowConnections.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShowConnections.Location = new System.Drawing.Point(205, 221);
            this.btnShowConnections.Name = "btnShowConnections";
            this.btnShowConnections.Size = new System.Drawing.Size(140, 23);
            this.btnShowConnections.TabIndex = 5;
            this.btnShowConnections.Text = "Verbindungen anzeigen";
            this.btnShowConnections.UseVisualStyleBackColor = false;
            this.btnShowConnections.Click += new System.EventHandler(this.btnShowConnections_Click);
            // 
            // txtStart
            // 
            this.txtStart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStart.Location = new System.Drawing.Point(266, 27);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(300, 20);
            this.txtStart.TabIndex = 1;
            this.txtStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StartStation_KeyUp);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(202, 29);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(36, 16);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "Von:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(202, 72);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(44, 16);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Nach:";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(266, 72);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(300, 20);
            this.txtDestination.TabIndex = 2;
            this.txtDestination.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EndStation_KeyUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClose.Location = new System.Drawing.Point(595, 449);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridConnections
            // 
            this.dataGridConnections.AllowUserToAddRows = false;
            this.dataGridConnections.AllowUserToDeleteRows = false;
            this.dataGridConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridConnections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridConnections.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridConnections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConnections.Location = new System.Drawing.Point(205, 267);
            this.dataGridConnections.Name = "dataGridConnections";
            this.dataGridConnections.ReadOnly = true;
            this.dataGridConnections.Size = new System.Drawing.Size(432, 167);
            this.dataGridConnections.TabIndex = 11;
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Location = new System.Drawing.Point(161, 7);
            this.lblSeparator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(2, 470);
            this.lblSeparator.TabIndex = 12;
            // 
            // rbConnections
            // 
            this.rbConnections.AutoSize = true;
            this.rbConnections.Checked = true;
            this.rbConnections.Location = new System.Drawing.Point(9, 66);
            this.rbConnections.Margin = new System.Windows.Forms.Padding(2);
            this.rbConnections.Name = "rbConnections";
            this.rbConnections.Size = new System.Drawing.Size(142, 17);
            this.rbConnections.TabIndex = 9;
            this.rbConnections.TabStop = true;
            this.rbConnections.Text = "Verbindungen Von-Nach";
            this.rbConnections.UseVisualStyleBackColor = true;
            this.rbConnections.CheckedChanged += new System.EventHandler(this.rbConnections_CheckedChanged);
            // 
            // rbStationBoard
            // 
            this.rbStationBoard.AutoSize = true;
            this.rbStationBoard.Location = new System.Drawing.Point(9, 106);
            this.rbStationBoard.Margin = new System.Windows.Forms.Padding(2);
            this.rbStationBoard.Name = "rbStationBoard";
            this.rbStationBoard.Size = new System.Drawing.Size(84, 17);
            this.rbStationBoard.TabIndex = 10;
            this.rbStationBoard.Text = "Abfahrtstafel";
            this.rbStationBoard.UseVisualStyleBackColor = true;
            // 
            // lblTitel
            // 
            this.lblTitel.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitel.Location = new System.Drawing.Point(2, 21);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(155, 32);
            this.lblTitel.TabIndex = 15;
            this.lblTitel.Text = "SwissTransport";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(266, 137);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(79, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblDate.Location = new System.Drawing.Point(202, 141);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 16);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label1.Location = new System.Drawing.Point(202, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Zeit:";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(266, 176);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(79, 20);
            this.dtpTime.TabIndex = 4;
            // 
            // btnSendviaMail
            // 
            this.btnSendviaMail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSendviaMail.Location = new System.Drawing.Point(526, 221);
            this.btnSendviaMail.Name = "btnSendviaMail";
            this.btnSendviaMail.Size = new System.Drawing.Size(111, 23);
            this.btnSendviaMail.TabIndex = 6;
            this.btnSendviaMail.Text = "via Mail weiterleiten";
            this.btnSendviaMail.UseVisualStyleBackColor = false;
            this.btnSendviaMail.Click += new System.EventHandler(this.SendviaMail_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 484);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(740, 22);
            this.statusStrip.TabIndex = 24;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // linkStartstationOnMaps
            // 
            this.linkStartstationOnMaps.AutoSize = true;
            this.linkStartstationOnMaps.Location = new System.Drawing.Point(595, 34);
            this.linkStartstationOnMaps.Name = "linkStartstationOnMaps";
            this.linkStartstationOnMaps.Size = new System.Drawing.Size(107, 13);
            this.linkStartstationOnMaps.TabIndex = 7;
            this.linkStartstationOnMaps.TabStop = true;
            this.linkStartstationOnMaps.Text = "Startstation auf Maps";
            this.linkStartstationOnMaps.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StartstationOnMaps_Click);
            // 
            // linkEndstationOnMaps
            // 
            this.linkEndstationOnMaps.AutoSize = true;
            this.linkEndstationOnMaps.Location = new System.Drawing.Point(595, 79);
            this.linkEndstationOnMaps.Name = "linkEndstationOnMaps";
            this.linkEndstationOnMaps.Size = new System.Drawing.Size(104, 13);
            this.linkEndstationOnMaps.TabIndex = 8;
            this.linkEndstationOnMaps.TabStop = true;
            this.linkEndstationOnMaps.Text = "Endstation auf Maps";
            this.linkEndstationOnMaps.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EndstationOnMaps_Click);
            // 
            // frmConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 506);
            this.Controls.Add(this.linkEndstationOnMaps);
            this.Controls.Add(this.linkStartstationOnMaps);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnSendviaMail);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.rbStationBoard);
            this.Controls.Add(this.rbConnections);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.dataGridConnections);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.btnShowConnections);
            this.Name = "frmConnections";
            this.Text = "SwissTransport";
            this.Load += new System.EventHandler(this.SwissTransport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConnections)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowConnections;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridConnections;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.RadioButton rbStationBoard;
        public System.Windows.Forms.RadioButton rbConnections;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnSendviaMail;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel;
        private System.Windows.Forms.LinkLabel linkStartstationOnMaps;
        private System.Windows.Forms.LinkLabel linkEndstationOnMaps;
    }
}

