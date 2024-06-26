﻿namespace BookRentalShopApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            MesBookRental = new MenuStrip();
            StsBookRantal = new StatusStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            MesBookRental.SuspendLayout();
            StsBookRantal.SuspendLayout();
            SuspendLayout();
            // 
            // MesBookRental
            // 
            MesBookRental.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            MesBookRental.Location = new Point(0, 0);
            MesBookRental.Name = "MesBookRental";
            MesBookRental.Size = new Size(800, 24);
            MesBookRental.TabIndex = 1;
            MesBookRental.Text = "menuStrip1";
            // 
            // StsBookRantal
            // 
            StsBookRantal.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            StsBookRantal.Location = new Point(0, 449);
            StsBookRantal.Name = "StsBookRantal";
            StsBookRantal.Size = new Size(800, 22);
            StsBookRantal.TabIndex = 2;
            StsBookRantal.Text = "statusStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(57, 20);
            toolStripMenuItem1.Text = "파일(&F)";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(62, 20);
            toolStripMenuItem2.Text = "관리(&M)";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(72, 20);
            toolStripMenuItem3.Text = "도움말(&H)";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(83, 17);
            toolStripStatusLabel1.Text = "로그인 아이디";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(40, 17);
            toolStripStatusLabel2.Text = "UserId";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(109, 17);
            toolStripStatusLabel3.Text = "LastLoginDataTime";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 471);
            Controls.Add(StsBookRantal);
            Controls.Add(MesBookRental);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = MesBookRental;
            Name = "FrmMain";
            Text = "책 대여점 v1.1";
            Load += FrmMain_Load;
            MesBookRental.ResumeLayout(false);
            MesBookRental.PerformLayout();
            StsBookRantal.ResumeLayout(false);
            StsBookRantal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MesBookRental;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private StatusStrip StsBookRantal;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
    }
}
