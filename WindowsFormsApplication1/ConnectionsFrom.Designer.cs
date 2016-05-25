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
            this.btnMainWindow = new System.Windows.Forms.Button();
            this.btnShowDepartures = new System.Windows.Forms.Button();
            this.dataGridConnectionsFrom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConnectionsFrom)).BeginInit();
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
            // dataGridConnectionsFrom
            // 
            this.dataGridConnectionsFrom.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridConnectionsFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConnectionsFrom.Location = new System.Drawing.Point(37, 125);
            this.dataGridConnectionsFrom.Name = "dataGridConnectionsFrom";
            this.dataGridConnectionsFrom.Size = new System.Drawing.Size(327, 150);
            this.dataGridConnectionsFrom.TabIndex = 7;
            // 
            // frmConnectionsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 331);
            this.Controls.Add(this.dataGridConnectionsFrom);
            this.Controls.Add(this.btnShowDepartures);
            this.Controls.Add(this.btnMainWindow);
            this.Controls.Add(this.lblConnectionsFrom);
            this.Controls.Add(this.txtConnectionsFrom);
            this.Name = "frmConnectionsFrom";
            this.Text = "Verbindungen ab";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConnectionsFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionsFrom;
        private System.Windows.Forms.Label lblConnectionsFrom;
        private System.Windows.Forms.Button btnMainWindow;
        private System.Windows.Forms.Button btnShowDepartures;
        private System.Windows.Forms.DataGridView dataGridConnectionsFrom;
    }
}