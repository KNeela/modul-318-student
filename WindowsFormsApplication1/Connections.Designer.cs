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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridConnections = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConnections)).BeginInit();
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(414, 333);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridConnections
            // 
            this.dataGridConnections.AllowUserToAddRows = false;
            this.dataGridConnections.AllowUserToDeleteRows = false;
            this.dataGridConnections.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConnections.Location = new System.Drawing.Point(53, 169);
            this.dataGridConnections.Name = "dataGridConnections";
            this.dataGridConnections.ReadOnly = true;
            this.dataGridConnections.Size = new System.Drawing.Size(375, 158);
            this.dataGridConnections.TabIndex = 11;
            // 
            // frmConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 368);
            this.Controls.Add(this.dataGridConnections);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.btnShowConnections);
            this.Name = "frmConnections";
            this.Text = "Verbindungen Von - Nach";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConnections)).EndInit();
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
    }
}

