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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            TxtUserId = new TextBox();
            TxtPassword = new TextBox();
            BtnLogin = new Button();
            ChkShowPass = new CheckBox();
            BtnCancle = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 192);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Student-ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 249);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // TxtUserId
            // 
            TxtUserId.ForeColor = SystemColors.WindowFrame;
            TxtUserId.Location = new Point(23, 210);
            TxtUserId.Name = "TxtUserId";
            TxtUserId.Size = new Size(326, 23);
            TxtUserId.TabIndex = 1;
            TxtUserId.Text = "학번";
            TxtUserId.KeyPress += TxtUserId_KeyPress;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("맑은 고딕", 9F);
            TxtPassword.ForeColor = SystemColors.WindowFrame;
            TxtPassword.Location = new Point(23, 267);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '●';
            TxtPassword.Size = new Size(326, 23);
            TxtPassword.TabIndex = 2;
            TxtPassword.Text = "Password";
            TxtPassword.KeyPress += TxtPassword_KeyPress;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.LightGray;
            BtnLogin.Font = new Font("맑은 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnLogin.Location = new Point(23, 342);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(326, 38);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // ChkShowPass
            // 
            ChkShowPass.AutoSize = true;
            ChkShowPass.Location = new Point(231, 296);
            ChkShowPass.Name = "ChkShowPass";
            ChkShowPass.Size = new Size(118, 19);
            ChkShowPass.TabIndex = 6;
            ChkShowPass.Text = "Unhide password";
            ChkShowPass.UseVisualStyleBackColor = true;
            ChkShowPass.CheckedChanged += ChkShowPass_CheckedChanged;
            // 
            // BtnCancle
            // 
            BtnCancle.BackColor = Color.FromArgb(224, 224, 224);
            BtnCancle.Font = new Font("맑은 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnCancle.Location = new Point(23, 389);
            BtnCancle.Name = "BtnCancle";
            BtnCancle.Size = new Size(326, 38);
            BtnCancle.TabIndex = 7;
            BtnCancle.Text = "Exit";
            BtnCancle.UseVisualStyleBackColor = false;
            BtnCancle.Click += BtnCancle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LoginDisplay;
            pictureBox1.Location = new Point(89, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 119);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 450);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(BtnCancle);
            Controls.Add(ChkShowPass);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUserId);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            Resizable = false;
            Style = MetroFramework.MetroColorStyle.Black;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtUserId;
        private TextBox TxtPassword;
        private Button BtnLogin;
        private CheckBox ChkShowPass;
        private Button BtnCancle;
        private PictureBox pictureBox1;
    }
}
