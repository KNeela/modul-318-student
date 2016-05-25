namespace WindowsFormsApplication1
{
    partial class frmMainWindow
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
            this.btnConnectionsFromDestination = new System.Windows.Forms.Button();
            this.btnConnectionsFrom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnectionsFromDestination
            // 
            this.btnConnectionsFromDestination.Location = new System.Drawing.Point(68, 58);
            this.btnConnectionsFromDestination.Name = "btnConnectionsFromDestination";
            this.btnConnectionsFromDestination.Size = new System.Drawing.Size(169, 37);
            this.btnConnectionsFromDestination.TabIndex = 0;
            this.btnConnectionsFromDestination.Text = "Verbindungen Von - Nach";
            this.btnConnectionsFromDestination.UseVisualStyleBackColor = true;
            this.btnConnectionsFromDestination.Click += new System.EventHandler(this.btnConnectionsFromDestination_Click);
            // 
            // btnConnectionsFrom
            // 
            this.btnConnectionsFrom.Location = new System.Drawing.Point(68, 153);
            this.btnConnectionsFrom.Name = "btnConnectionsFrom";
            this.btnConnectionsFrom.Size = new System.Drawing.Size(169, 39);
            this.btnConnectionsFrom.TabIndex = 1;
            this.btnConnectionsFrom.Text = "Verbindungen ab";
            this.btnConnectionsFrom.UseVisualStyleBackColor = true;
            this.btnConnectionsFrom.Click += new System.EventHandler(this.btnConnectionsFrom_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnConnectionsFrom);
            this.Controls.Add(this.btnConnectionsFromDestination);
            this.Name = "frmMainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnectionsFromDestination;
        private System.Windows.Forms.Button btnConnectionsFrom;
    }
}