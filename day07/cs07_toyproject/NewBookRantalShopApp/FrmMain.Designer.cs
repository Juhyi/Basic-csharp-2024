﻿namespace NewBookRantalShopApp
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLoginUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuBookDivision = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBookInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMember = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuBookRental = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblLoginid = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "파일(&F)";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItem3.Text = "끝내기(&X)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuLoginUsers,
            this.toolStripSeparator1,
            this.MnuBookDivision,
            this.MnuBookInfo,
            this.MnuMember,
            this.toolStripSeparator2,
            this.MnuBookRental});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem2.Text = "관리(&M)";
            // 
            // MnuLoginUsers
            // 
            this.MnuLoginUsers.Image = ((System.Drawing.Image)(resources.GetObject("MnuLoginUsers.Image")));
            this.MnuLoginUsers.Name = "MnuLoginUsers";
            this.MnuLoginUsers.Size = new System.Drawing.Size(178, 22);
            this.MnuLoginUsers.Text = "로그인 사용자 관리";
            this.MnuLoginUsers.Click += new System.EventHandler(this.MnuLoginUsers_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // MnuBookDivision
            // 
            this.MnuBookDivision.Name = "MnuBookDivision";
            this.MnuBookDivision.Size = new System.Drawing.Size(178, 22);
            this.MnuBookDivision.Text = "책 장르 관리";
            this.MnuBookDivision.Click += new System.EventHandler(this.MnuBookDivision_Click);
            // 
            // MnuBookInfo
            // 
            this.MnuBookInfo.Image = global::NewBookRantalShopApp.Properties.Resources.book;
            this.MnuBookInfo.Name = "MnuBookInfo";
            this.MnuBookInfo.Size = new System.Drawing.Size(178, 22);
            this.MnuBookInfo.Text = "책 정보 관리";
            this.MnuBookInfo.Click += new System.EventHandler(this.MnuBookInfo_Click);
            // 
            // MnuMember
            // 
            this.MnuMember.Image = global::NewBookRantalShopApp.Properties.Resources.member;
            this.MnuMember.Name = "MnuMember";
            this.MnuMember.Size = new System.Drawing.Size(178, 22);
            this.MnuMember.Text = "도서 회원 관리";
            this.MnuMember.Click += new System.EventHandler(this.MnuMember_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // MnuBookRental
            // 
            this.MnuBookRental.Image = global::NewBookRantalShopApp.Properties.Resources.rental;
            this.MnuBookRental.Name = "MnuBookRental";
            this.MnuBookRental.Size = new System.Drawing.Size(178, 22);
            this.MnuBookRental.Text = "대출 관리";
            this.MnuBookRental.Click += new System.EventHandler(this.MnuBookRental_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAbout});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // MnuAbout
            // 
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(175, 22);
            this.MnuAbout.Text = "이 프로그램은...(&A)";
            this.MnuAbout.Click += new System.EventHandler(this.MnuAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblLoginid});
            this.statusStrip1.Location = new System.Drawing.Point(20, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(866, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel1.Text = "로그인아이디";
            // 
            // LblLoginid
            // 
            this.LblLoginid.Name = "LblLoginid";
            this.LblLoginid.Size = new System.Drawing.Size(121, 17);
            this.LblLoginid.Text = "toolStripStatusLabel2";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 609);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "책 대여점 v1.2";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MnuLoginUsers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MnuBookDivision;
        private System.Windows.Forms.ToolStripMenuItem MnuBookInfo;
        private System.Windows.Forms.ToolStripMenuItem MnuMember;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MnuBookRental;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.ToolStripStatusLabel LblLoginid;
    }
}

