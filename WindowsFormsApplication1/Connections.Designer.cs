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
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lstConnections = new System.Windows.Forms.ListBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnMainWindow = new System.Windows.Forms.Button();
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
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(128, 25);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 20);
            this.txtFrom.TabIndex = 1;
            // 
            // lstConnections
            // 
            this.lstConnections.FormattingEnabled = true;
            this.lstConnections.Location = new System.Drawing.Point(53, 183);
            this.lstConnections.Name = "lstConnections";
            this.lstConnections.Size = new System.Drawing.Size(120, 95);
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
            this.txtDestination.Size = new System.Drawing.Size(100, 20);
            this.txtDestination.TabIndex = 5;
            // 
            // btnMainWindow
            // 
            this.btnMainWindow.Location = new System.Drawing.Point(198, 300);
            this.btnMainWindow.Name = "btnMainWindow";
            this.btnMainWindow.Size = new System.Drawing.Size(114, 23);
            this.btnMainWindow.TabIndex = 6;
            this.btnMainWindow.Text = "Zurück zum Menü";
            this.btnMainWindow.UseVisualStyleBackColor = true;
            // 
            // frmConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 335);
            this.Controls.Add(this.btnMainWindow);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lstConnections);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.btnShowConnections);
            this.Name = "frmConnections";
            this.Text = "Verbindungen Von - Nach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowConnections;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.ListBox lstConnections;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnMainWindow;
    }
}

