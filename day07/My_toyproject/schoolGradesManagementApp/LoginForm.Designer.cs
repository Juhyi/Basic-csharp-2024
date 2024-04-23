namespace schoolGradesManagementApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            TxtUserId = new TextBox();
            TxtPassword = new TextBox();
            BtnLogin = new Button();
            BtnRegister = new Button();
            ChkShowPass = new CheckBox();
            BtnCancle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 143);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 204);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // TxtUserId
            // 
            TxtUserId.ForeColor = SystemColors.WindowFrame;
            TxtUserId.Location = new Point(23, 161);
            TxtUserId.Name = "TxtUserId";
            TxtUserId.Size = new Size(326, 23);
            TxtUserId.TabIndex = 2;
            TxtUserId.Text = "Email ID";
            TxtUserId.TextChanged += TxtUserId_TextChanged;
            TxtUserId.KeyPress += TxtUserId_KeyPress;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("맑은 고딕", 9F);
            TxtPassword.ForeColor = SystemColors.WindowFrame;
            TxtPassword.Location = new Point(23, 222);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '●';
            TxtPassword.Size = new Size(326, 23);
            TxtPassword.TabIndex = 3;
            TxtPassword.Text = "Password";
            TxtPassword.TextChanged += TxtPassword_TextChanged;
            TxtPassword.KeyPress += TxtPassword_KeyPress;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(23, 298);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(326, 23);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Log in";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnRegister
            // 
            BtnRegister.Location = new Point(23, 353);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(326, 23);
            BtnRegister.TabIndex = 5;
            BtnRegister.Text = "or Get Registered";
            BtnRegister.UseVisualStyleBackColor = true;
            // 
            // ChkShowPass
            // 
            ChkShowPass.AutoSize = true;
            ChkShowPass.Location = new Point(244, 251);
            ChkShowPass.Name = "ChkShowPass";
            ChkShowPass.Size = new Size(118, 19);
            ChkShowPass.TabIndex = 6;
            ChkShowPass.Text = "Unhide password";
            ChkShowPass.UseVisualStyleBackColor = true;
            ChkShowPass.CheckedChanged += ChkShowPass_CheckedChanged;
            // 
            // BtnCancle
            // 
            BtnCancle.Location = new Point(23, 405);
            BtnCancle.Name = "BtnCancle";
            BtnCancle.Size = new Size(326, 23);
            BtnCancle.TabIndex = 7;
            BtnCancle.Text = "Cancle";
            BtnCancle.UseVisualStyleBackColor = true;
            BtnCancle.Click += BtnCancle_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 450);
            ControlBox = false;
            Controls.Add(BtnCancle);
            Controls.Add(ChkShowPass);
            Controls.Add(BtnRegister);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUserId);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtUserId;
        private TextBox TxtPassword;
        private Button BtnLogin;
        private Button BtnRegister;
        private CheckBox ChkShowPass;
        private Button BtnCancle;
    }
}
