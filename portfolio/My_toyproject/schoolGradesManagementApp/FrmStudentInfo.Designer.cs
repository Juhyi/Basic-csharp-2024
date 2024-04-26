namespace schoolGradesManagementApp
{
    partial class FrmStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentInfo));
            DgvScore = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            TxtUserScore = new TextBox();
            TxtUserAddr = new TextBox();
            TxtuserEmail = new TextBox();
            TxtUserMoblie = new TextBox();
            TxtUserGrade = new TextBox();
            TxtUserDept = new TextBox();
            TxtUserBirth = new TextBox();
            TxtUserId = new TextBox();
            TxtUserNames = new TextBox();
            label5 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvScore).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // DgvScore
            // 
            DgvScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvScore.Dock = DockStyle.Fill;
            DgvScore.Location = new Point(3, 19);
            DgvScore.MaximumSize = new Size(500, 500);
            DgvScore.Name = "DgvScore";
            DgvScore.Size = new Size(383, 345);
            DgvScore.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DgvScore);
            groupBox1.Location = new Point(323, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 367);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "성적조회";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtUserScore);
            groupBox2.Controls.Add(TxtUserAddr);
            groupBox2.Controls.Add(TxtuserEmail);
            groupBox2.Controls.Add(TxtUserMoblie);
            groupBox2.Controls.Add(TxtUserGrade);
            groupBox2.Controls.Add(TxtUserDept);
            groupBox2.Controls.Add(TxtUserBirth);
            groupBox2.Controls.Add(TxtUserId);
            groupBox2.Controls.Add(TxtUserNames);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(4, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(313, 367);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // TxtUserScore
            // 
            TxtUserScore.Location = new Point(199, 192);
            TxtUserScore.Name = "TxtUserScore";
            TxtUserScore.Size = new Size(86, 23);
            TxtUserScore.TabIndex = 9;
            // 
            // TxtUserAddr
            // 
            TxtUserAddr.Location = new Point(72, 308);
            TxtUserAddr.Name = "TxtUserAddr";
            TxtUserAddr.Size = new Size(213, 23);
            TxtUserAddr.TabIndex = 8;
            // 
            // TxtuserEmail
            // 
            TxtuserEmail.Location = new Point(72, 268);
            TxtuserEmail.Name = "TxtuserEmail";
            TxtuserEmail.Size = new Size(213, 23);
            TxtuserEmail.TabIndex = 7;
            // 
            // TxtUserMoblie
            // 
            TxtUserMoblie.Location = new Point(72, 230);
            TxtUserMoblie.Name = "TxtUserMoblie";
            TxtUserMoblie.Size = new Size(213, 23);
            TxtUserMoblie.TabIndex = 6;
            // 
            // TxtUserGrade
            // 
            TxtUserGrade.Location = new Point(72, 192);
            TxtUserGrade.Name = "TxtUserGrade";
            TxtUserGrade.Size = new Size(84, 23);
            TxtUserGrade.TabIndex = 5;
            // 
            // TxtUserDept
            // 
            TxtUserDept.Location = new Point(72, 152);
            TxtUserDept.Name = "TxtUserDept";
            TxtUserDept.Size = new Size(213, 23);
            TxtUserDept.TabIndex = 4;
            // 
            // TxtUserBirth
            // 
            TxtUserBirth.Location = new Point(72, 109);
            TxtUserBirth.Name = "TxtUserBirth";
            TxtUserBirth.Size = new Size(169, 23);
            TxtUserBirth.TabIndex = 3;
            // 
            // TxtUserId
            // 
            TxtUserId.Location = new Point(72, 80);
            TxtUserId.Name = "TxtUserId";
            TxtUserId.Size = new Size(84, 23);
            TxtUserId.TabIndex = 2;
            // 
            // TxtUserNames
            // 
            TxtUserNames.Location = new Point(72, 46);
            TxtUserNames.Name = "TxtUserNames";
            TxtUserNames.Size = new Size(84, 23);
            TxtUserNames.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 155);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 0;
            label5.Text = "학과";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 308);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 0;
            label9.Text = "주소";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 268);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 0;
            label8.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 117);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 0;
            label4.Text = "생년월일";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 233);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 0;
            label7.Text = "전화번호";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 195);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 0;
            label3.Text = "학년";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(167, 195);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 0;
            label6.Text = "학점";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 83);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 0;
            label2.Text = " 학번";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 49);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "이름";
            // 
            // FrmStudentInfo
            // 
            ClientSize = new Size(724, 425);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmStudentInfo";
            Style = MetroFramework.MetroColorStyle.Black;
            Text = "나의 정보";
            ((System.ComponentModel.ISupportInitialize)DgvScore).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvScore;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label4;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox TxtUserId;
        private TextBox TxtUserNames;
        private TextBox TxtUserScore;
        private TextBox TxtUserAddr;
        private TextBox TxtuserEmail;
        private TextBox TxtUserMoblie;
        private TextBox TxtUserGrade;
        private TextBox TxtUserDept;
        private TextBox TxtUserBirth;
    }
}