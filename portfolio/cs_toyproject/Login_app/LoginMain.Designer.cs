namespace Login_app
{
    partial class LoginMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMain));
            label1 = new Label();
            label2 = new Label();
            TxtID = new TextBox();
            TxtPassword = new TextBox();
            Btnlog = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label1.Location = new Point(15, 34);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label2.Location = new Point(15, 96);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // TxtID
            // 
            TxtID.Location = new Point(15, 52);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(479, 23);
            TxtID.TabIndex = 2;
            TxtID.Text = "아이디 또는 이메일";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(15, 114);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(479, 23);
            TxtPassword.TabIndex = 3;
            TxtPassword.Text = "비밀번호";
            // 
            // Btnlog
            // 
            Btnlog.BackColor = SystemColors.ActiveCaption;
            Btnlog.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            Btnlog.ForeColor = SystemColors.ButtonHighlight;
            Btnlog.Location = new Point(15, 156);
            Btnlog.Name = "Btnlog";
            Btnlog.Size = new Size(191, 38);
            Btnlog.TabIndex = 4;
            Btnlog.Text = "Log in";
            Btnlog.UseVisualStyleBackColor = false;
            Btnlog.Click += Btnlog_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(Btnlog);
            groupBox1.Controls.Add(TxtPassword);
            groupBox1.Controls.Add(TxtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-3, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 213);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // LoginMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 215);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginMain";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtID;
        private TextBox TxtPassword;
        private Button Btnlog;
        private GroupBox groupBox1;
    }
}
