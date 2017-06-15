namespace UI
{
    partial class Inlogscherm
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
            this.tbx_Password_Login = new System.Windows.Forms.TextBox();
            this.tbx_WerknemerID_Login = new System.Windows.Forms.TextBox();
            this.btn_Login_Text = new System.Windows.Forms.Button();
            this.btn_Login_Symbol = new System.Windows.Forms.Button();
            this.l_Message_Inlog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_Password_Login
            // 
            this.tbx_Password_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbx_Password_Login.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbx_Password_Login.Location = new System.Drawing.Point(79, 451);
            this.tbx_Password_Login.Name = "tbx_Password_Login";
            this.tbx_Password_Login.PasswordChar = '*';
            this.tbx_Password_Login.Size = new System.Drawing.Size(267, 38);
            this.tbx_Password_Login.TabIndex = 0;
            this.tbx_Password_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_Password_Login.Visible = false;
            // 
            // tbx_WerknemerID_Login
            // 
            this.tbx_WerknemerID_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbx_WerknemerID_Login.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbx_WerknemerID_Login.Location = new System.Drawing.Point(124, 407);
            this.tbx_WerknemerID_Login.Name = "tbx_WerknemerID_Login";
            this.tbx_WerknemerID_Login.Size = new System.Drawing.Size(192, 38);
            this.tbx_WerknemerID_Login.TabIndex = 1;
            this.tbx_WerknemerID_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_WerknemerID_Login.TextChanged += new System.EventHandler(this.tbx_WerknemerID_Login_TextChanged);
            // 
            // btn_Login_Text
            // 
            this.btn_Login_Text.Enabled = false;
            this.btn_Login_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_Login_Text.Location = new System.Drawing.Point(32, 515);
            this.btn_Login_Text.Name = "btn_Login_Text";
            this.btn_Login_Text.Size = new System.Drawing.Size(359, 113);
            this.btn_Login_Text.TabIndex = 2;
            this.btn_Login_Text.Text = "Log in";
            this.btn_Login_Text.UseVisualStyleBackColor = true;
            this.btn_Login_Text.Click += new System.EventHandler(this.btn_Login_Text_Click);
            // 
            // btn_Login_Symbol
            // 
            this.btn_Login_Symbol.Enabled = false;
            this.btn_Login_Symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Login_Symbol.Location = new System.Drawing.Point(352, 451);
            this.btn_Login_Symbol.Name = "btn_Login_Symbol";
            this.btn_Login_Symbol.Size = new System.Drawing.Size(39, 38);
            this.btn_Login_Symbol.TabIndex = 3;
            this.btn_Login_Symbol.Text = ">";
            this.btn_Login_Symbol.UseVisualStyleBackColor = true;
            this.btn_Login_Symbol.Click += new System.EventHandler(this.btn_Login_Symbol_Click);
            // 
            // l_Message_Inlog
            // 
            this.l_Message_Inlog.AutoSize = true;
            this.l_Message_Inlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.l_Message_Inlog.Location = new System.Drawing.Point(93, 344);
            this.l_Message_Inlog.Name = "l_Message_Inlog";
            this.l_Message_Inlog.Size = new System.Drawing.Size(253, 31);
            this.l_Message_Inlog.TabIndex = 4;
            this.l_Message_Inlog.Text = "Vul uw inlogcode in ";
            this.l_Message_Inlog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inlogscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(418, 697);
            this.ControlBox = false;
            this.Controls.Add(this.l_Message_Inlog);
            this.Controls.Add(this.btn_Login_Symbol);
            this.Controls.Add(this.btn_Login_Text);
            this.Controls.Add(this.tbx_WerknemerID_Login);
            this.Controls.Add(this.tbx_Password_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inlogscherm";
            this.Text = "test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Password_Login;
        private System.Windows.Forms.TextBox tbx_WerknemerID_Login;
        private System.Windows.Forms.Button btn_Login_Symbol;
        private System.Windows.Forms.Button btn_Login_Text;
        private System.Windows.Forms.Label l_Message_Inlog;
    }
}