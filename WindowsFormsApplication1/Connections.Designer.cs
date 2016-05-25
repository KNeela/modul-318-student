namespace WindowsFormsApplication1
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
            this.lstConnections = new System.Windows.Forms.ListBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnMainWindow = new System.Windows.Forms.Button();
            this.lblFromStation = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowConnections
            // 
            this.btnShowConnections.Location = new System.Drawing.Point(53, 130);
            this.btnShowConnections.Name = "btnShowConnections";
            this.btnShowConnections.Size = new System.Drawing.Size(140, 23);
            this.btnShowConnections.TabIndex = 0;
            this.btnShowConnections.Text = "Verbindungen anzeigen";
            this.btnShowConnections.UseVisualStyleBackColor = true;
            this.btnShowConnections.Click += new System.EventHandler(this.btnShowConnections_Click);
            // 
            // txtStart
            // 
            this.txtStart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStart.Location = new System.Drawing.Point(128, 25);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(300, 20);
            this.txtStart.TabIndex = 1;
            this.txtStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StartStation_KeyUp);
            // 
            // lstConnections
            // 
            this.lstConnections.FormattingEnabled = true;
            this.lstConnections.Location = new System.Drawing.Point(53, 211);
            this.lstConnections.Name = "lstConnections";
            this.lstConnections.Size = new System.Drawing.Size(375, 95);
            this.lstConnections.TabIndex = 2;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(50, 28);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(26, 13);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "Von";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(50, 71);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(33, 13);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Nach";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(128, 64);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(300, 20);
            this.txtDestination.TabIndex = 5;
            this.txtDestination.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EndStation_KeyUp);
            // 
            // btnMainWindow
            // 
            this.btnMainWindow.Location = new System.Drawing.Point(200, 324);
            this.btnMainWindow.Name = "btnMainWindow";
            this.btnMainWindow.Size = new System.Drawing.Size(114, 23);
            this.btnMainWindow.TabIndex = 6;
            this.btnMainWindow.Text = "Zurück zum Menü";
            this.btnMainWindow.UseVisualStyleBackColor = true;
            // 
            // lblFromStation
            // 
            this.lblFromStation.AutoSize = true;
            this.lblFromStation.Location = new System.Drawing.Point(53, 191);
            this.lblFromStation.Name = "lblFromStation";
            this.lblFromStation.Size = new System.Drawing.Size(20, 13);
            this.lblFromStation.TabIndex = 7;
            this.lblFromStation.Text = "Ab";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(165, 191);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(41, 13);
            this.lblDeparture.TabIndex = 8;
            this.lblDeparture.Text = "Abfahrt";
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(320, 191);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(30, 13);
            this.lblPlatform.TabIndex = 9;
            this.lblPlatform.Text = "Gleis";
            // 
            // frmConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 368);
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.lblFromStation);
            this.Controls.Add(this.btnMainWindow);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lstConnections);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.btnShowConnections);
            this.Name = "frmConnections";
            this.Text = "Verbindungen Von - Nach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowConnections;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.ListBox lstConnections;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnMainWindow;
        private System.Windows.Forms.Label lblFromStation;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblPlatform;
    }
}

