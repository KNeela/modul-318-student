namespace WindowsFormsApplication1
{
    partial class ShowStations
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
            this.btnShowStations = new System.Windows.Forms.Button();
            this.lblStation = new System.Windows.Forms.Label();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.lstStations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShowStations
            // 
            this.btnShowStations.Location = new System.Drawing.Point(82, 66);
            this.btnShowStations.Name = "btnShowStations";
            this.btnShowStations.Size = new System.Drawing.Size(129, 23);
            this.btnShowStations.TabIndex = 0;
            this.btnShowStations.Text = "Stationen anzeigen";
            this.btnShowStations.UseVisualStyleBackColor = true;
            this.btnShowStations.Click += new System.EventHandler(this.btnShowStations_Click);
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(13, 24);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(40, 13);
            this.lblStation.TabIndex = 1;
            this.lblStation.Text = "Station";
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(82, 21);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(100, 20);
            this.txtStation.TabIndex = 2;
            // 
            // lstStations
            // 
            this.lstStations.FormattingEnabled = true;
            this.lstStations.Location = new System.Drawing.Point(82, 132);
            this.lstStations.Name = "lstStations";
            this.lstStations.Size = new System.Drawing.Size(120, 95);
            this.lstStations.TabIndex = 3;
            // 
            // ShowStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.lstStations);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.btnShowStations);
            this.Name = "ShowStations";
            this.Text = "ShowStations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowStations;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.ListBox lstStations;
    }
}