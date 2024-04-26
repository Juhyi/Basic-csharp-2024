using MetroFramework.Forms;

namespace schoolGradesManagementApp
{
    partial class MainForm
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
            BtnLogout = new Button();
            BtnModify = new Button();
            BtnInfo = new Button();
            BtnCal = new Button();
            Btnissu = new Button();
            button1 = new Button();
            button6 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            LblLogin = new ToolStripStatusLabel();
            LblLoginNames = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnLogout
            // 
            BtnLogout.BackColor = Color.Transparent;
            BtnLogout.BackgroundImageLayout = ImageLayout.None;
            BtnLogout.FlatAppearance.BorderSize = 0;
            BtnLogout.FlatAppearance.MouseDownBackColor = Color.White;
            BtnLogout.FlatStyle = FlatStyle.Flat;
            BtnLogout.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnLogout.Image = Properties.Resources.Logout3;
            BtnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLogout.Location = new Point(6, 397);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(106, 31);
            BtnLogout.TabIndex = 1;
            BtnLogout.Text = "       로그아웃  ";
            BtnLogout.UseVisualStyleBackColor = false;
            BtnLogout.Click += BtnLogout_Click;
            // 
            // BtnModify
            // 
            BtnModify.FlatAppearance.BorderSize = 0;
            BtnModify.FlatStyle = FlatStyle.Flat;
            BtnModify.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnModify.Image = Properties.Resources.EditInfo;
            BtnModify.ImageAlign = ContentAlignment.TopCenter;
            BtnModify.Location = new Point(561, 63);
            BtnModify.Name = "BtnModify";
            BtnModify.Size = new Size(189, 179);
            BtnModify.TabIndex = 2;
            BtnModify.Text = "정보수정";
            BtnModify.TextAlign = ContentAlignment.BottomCenter;
            BtnModify.UseVisualStyleBackColor = true;
            // 
            // BtnInfo
            // 
            BtnInfo.FlatAppearance.BorderSize = 0;
            BtnInfo.FlatStyle = FlatStyle.Flat;
            BtnInfo.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnInfo.Image = Properties.Resources.StudentImpormation;
            BtnInfo.ImageAlign = ContentAlignment.TopCenter;
            BtnInfo.Location = new Point(307, 63);
            BtnInfo.Name = "BtnInfo";
            BtnInfo.Size = new Size(189, 179);
            BtnInfo.TabIndex = 2;
            BtnInfo.Text = "정보조회";
            BtnInfo.TextAlign = ContentAlignment.BottomCenter;
            BtnInfo.UseVisualStyleBackColor = true;
            BtnInfo.Click += BtnInfo_Click;
            // 
            // BtnCal
            // 
            BtnCal.FlatAppearance.BorderSize = 0;
            BtnCal.FlatStyle = FlatStyle.Flat;
            BtnCal.Font = new Font("맑은 고딕", 14F, FontStyle.Bold);
            BtnCal.Image = Properties.Resources.account;
            BtnCal.ImageAlign = ContentAlignment.TopCenter;
            BtnCal.Location = new Point(307, 248);
            BtnCal.Name = "BtnCal";
            BtnCal.Size = new Size(189, 179);
            BtnCal.TabIndex = 2;
            BtnCal.Text = "학점계산기";
            BtnCal.TextAlign = ContentAlignment.BottomCenter;
            BtnCal.UseVisualStyleBackColor = true;
            // 
            // Btnissu
            // 
            Btnissu.FlatAppearance.BorderSize = 0;
            Btnissu.FlatStyle = FlatStyle.Flat;
            Btnissu.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Btnissu.Image = Properties.Resources.증명서;
            Btnissu.ImageAlign = ContentAlignment.TopCenter;
            Btnissu.Location = new Point(561, 248);
            Btnissu.Name = "Btnissu";
            Btnissu.Size = new Size(189, 179);
            Btnissu.TabIndex = 2;
            Btnissu.Text = "    증명서 발급신청";
            Btnissu.TextAlign = ContentAlignment.BottomCenter;
            Btnissu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(14, 186);
            button1.Name = "button1";
            button1.Size = new Size(168, 23);
            button1.TabIndex = 5;
            button1.Text = "부경대학교 IoT 개발자 과정";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button6.Location = new Point(6, 203);
            button6.Name = "button6";
            button6.Size = new Size(295, 54);
            button6.TabIndex = 6;
            button6.Text = "학생관리 프로그램";
            button6.TextAlign = ContentAlignment.TopLeft;
            button6.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.White;
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Enabled = false;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, LblLogin, LblLoginNames });
            statusStrip1.Location = new Point(14, 12);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(333, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(43, 17);
            toolStripStatusLabel1.Text = "사용자";
            // 
            // LblLogin
            // 
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(121, 17);
            LblLogin.Text = "toolStripStatusLabel2";
            // 
            // LblLoginNames
            // 
            LblLoginNames.Name = "LblLoginNames";
            LblLoginNames.Size = new Size(121, 17);
            LblLoginNames.Text = "toolStripStatusLabel2";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(799, 441);
            Controls.Add(statusStrip1);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(Btnissu);
            Controls.Add(BtnCal);
            Controls.Add(BtnInfo);
            Controls.Add(BtnModify);
            Controls.Add(BtnLogout);
            Name = "MainForm";
            Style = MetroFramework.MetroColorStyle.Silver;
            TransparencyKey = Color.Empty;
            Activated += MainForm_Activated;
            FormClosing += MainForm_FormClosing_1;
            Load += MainForm_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnLogout;
        private Button BtnModify;
        private Button BtnInfo;
        private Button BtnCal;
        private Button Btnissu;
        private Button button1;
        private Button button6;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel LblLogin;
        private ToolStripStatusLabel LblLoginNames;
    }
}