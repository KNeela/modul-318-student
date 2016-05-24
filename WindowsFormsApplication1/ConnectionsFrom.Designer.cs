namespace WindowsFormsApplication1
{
    partial class ConnectionsFrom
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
            this.SuspendLayout();
            // 
            // txtConnectionsFrom
            // 
            this.txtConnectionsFrom.Location = new System.Drawing.Point(169, 46);
            this.txtConnectionsFrom.Name = "txtConnectionsFrom";
            this.txtConnectionsFrom.Size = new System.Drawing.Size(100, 20);
            this.txtConnectionsFrom.TabIndex = 0;
            // 
            // lblConnectionsFrom
            // 
            this.lblConnectionsFrom.AutoSize = true;
            this.lblConnectionsFrom.Location = new System.Drawing.Point(28, 52);
            this.lblConnectionsFrom.Name = "lblConnectionsFrom";
            this.lblConnectionsFrom.Size = new System.Drawing.Size(88, 13);
            this.lblConnectionsFrom.TabIndex = 1;
            this.lblConnectionsFrom.Text = "Verbindungen ab";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(28, 101);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(33, 13);
            this.lblDestination.TabIndex = 2;
            this.lblDestination.Text = "Nach";
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Location = new System.Drawing.Point(166, 101);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(41, 13);
            this.lblDepartureTime.TabIndex = 3;
            this.lblDepartureTime.Text = "Abfahrt";
            // 
            // lstConnectionsDeparture
            // 
            this.lstConnectionsDeparture.FormattingEnabled = true;
            this.lstConnectionsDeparture.Location = new System.Drawing.Point(31, 131);
            this.lstConnectionsDeparture.Name = "lstConnectionsDeparture";
            this.lstConnectionsDeparture.Size = new System.Drawing.Size(176, 95);
            this.lstConnectionsDeparture.TabIndex = 4;
            // 
            // ConnectionsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 295);
            this.Controls.Add(this.lstConnectionsDeparture);
            this.Controls.Add(this.lblDepartureTime);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblConnectionsFrom);
            this.Controls.Add(this.txtConnectionsFrom);
            this.Name = "ConnectionsFrom";
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
    }
}