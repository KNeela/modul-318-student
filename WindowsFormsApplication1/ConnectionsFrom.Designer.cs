namespace WindowsFormsApplication1
{
    partial class frmConnectionsFrom
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
            this.txtConnectionsFrom = new System.Windows.Forms.TextBox();
            this.lblConnectionsFrom = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.lstConnectionsDeparture = new System.Windows.Forms.ListBox();
            this.btnMainWindow = new System.Windows.Forms.Button();
            this.btnShowDepartures = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConnectionsFrom
            // 
            this.txtConnectionsFrom.Location = new System.Drawing.Point(128, 25);
            this.txtConnectionsFrom.Name = "txtConnectionsFrom";
            this.txtConnectionsFrom.Size = new System.Drawing.Size(174, 20);
            this.txtConnectionsFrom.TabIndex = 0;
            this.txtConnectionsFrom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StartStation_KeyUp);
            // 
            // lblConnectionsFrom
            // 
            this.lblConnectionsFrom.AutoSize = true;
            this.lblConnectionsFrom.Location = new System.Drawing.Point(34, 28);
            this.lblConnectionsFrom.Name = "lblConnectionsFrom";
            this.lblConnectionsFrom.Size = new System.Drawing.Size(88, 13);
            this.lblConnectionsFrom.TabIndex = 1;
            this.lblConnectionsFrom.Text = "Verbindungen ab";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(50, 148);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(33, 13);
            this.lblDestination.TabIndex = 2;
            this.lblDestination.Text = "Nach";
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Location = new System.Drawing.Point(166, 148);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(41, 13);
            this.lblDepartureTime.TabIndex = 3;
            this.lblDepartureTime.Text = "Abfahrt";
            // 
            // lstConnectionsDeparture
            // 
            this.lstConnectionsDeparture.FormattingEnabled = true;
            this.lstConnectionsDeparture.Location = new System.Drawing.Point(53, 174);
            this.lstConnectionsDeparture.Name = "lstConnectionsDeparture";
            this.lstConnectionsDeparture.Size = new System.Drawing.Size(375, 95);
            this.lstConnectionsDeparture.TabIndex = 4;
            // 
            // btnMainWindow
            // 
            this.btnMainWindow.Location = new System.Drawing.Point(409, 290);
            this.btnMainWindow.Name = "btnMainWindow";
            this.btnMainWindow.Size = new System.Drawing.Size(128, 23);
            this.btnMainWindow.TabIndex = 5;
            this.btnMainWindow.Text = "Zurück zum Menü";
            this.btnMainWindow.UseVisualStyleBackColor = true;
            // 
            // btnShowDepartures
            // 
            this.btnShowDepartures.Location = new System.Drawing.Point(128, 85);
            this.btnShowDepartures.Name = "btnShowDepartures";
            this.btnShowDepartures.Size = new System.Drawing.Size(114, 23);
            this.btnShowDepartures.TabIndex = 6;
            this.btnShowDepartures.Text = "Abfahrten anzeigen";
            this.btnShowDepartures.UseVisualStyleBackColor = true;
            this.btnShowDepartures.Click += new System.EventHandler(this.btnShowDepartures_Click);
            // 
            // frmConnectionsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 331);
            this.Controls.Add(this.btnShowDepartures);
            this.Controls.Add(this.btnMainWindow);
            this.Controls.Add(this.lstConnectionsDeparture);
            this.Controls.Add(this.lblDepartureTime);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblConnectionsFrom);
            this.Controls.Add(this.txtConnectionsFrom);
            this.Name = "frmConnectionsFrom";
            this.Text = "Verbindungen ab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionsFrom;
        private System.Windows.Forms.Label lblConnectionsFrom;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.ListBox lstConnectionsDeparture;
        private System.Windows.Forms.Button btnMainWindow;
        private System.Windows.Forms.Button btnShowDepartures;
    }
}