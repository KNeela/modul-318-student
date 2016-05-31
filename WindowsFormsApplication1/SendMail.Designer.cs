namespace SwissTransportTimeTable
{
    partial class frmSendMail
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblFrom.Location = new System.Drawing.Point(13, 22);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(36, 16);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Von:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblTo.Location = new System.Drawing.Point(13, 97);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(81, 16);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "Empfänger:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblSubject.Location = new System.Drawing.Point(13, 125);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(54, 16);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Betreff:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblPassword.Location = new System.Drawing.Point(13, 50);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Passwort:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblMessage.Location = new System.Drawing.Point(13, 174);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(71, 16);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Nachricht:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(16, 198);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(237, 107);
            this.txtMessage.TabIndex = 5;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(92, 18);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(161, 20);
            this.txtFrom.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(92, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(161, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(92, 97);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(161, 20);
            this.txtTo.TabIndex = 3;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(92, 125);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(161, 20);
            this.txtSubject.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSend.Location = new System.Drawing.Point(221, 321);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Senden";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // frmSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(308, 356);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Name = "frmSendMail";
            this.Text = "Email senden";
            this.Load += new System.EventHandler(this.SendMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnSend;
    }
}