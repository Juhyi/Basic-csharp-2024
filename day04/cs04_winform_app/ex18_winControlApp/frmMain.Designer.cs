namespace ex18_winControlApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            groupBox1 = new GroupBox();
            TxtSampleText = new TextBox();
            CboFonts = new ComboBox();
            chkItalic = new CheckBox();
            ChkBold = new CheckBox();
            label = new Label();
            groupBox2 = new GroupBox();
            PrgDummy = new ProgressBar();
            TrbDummy = new TrackBar();
            groupBox3 = new GroupBox();
            BtnQuestion = new Button();
            BtnMsgBox = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            groupBox4 = new GroupBox();
            BtnAddRoot = new Button();
            BtnAddChild = new Button();
            LsvDummy = new ListView();
            TrvDummy = new TreeView();
            groupBox5 = new GroupBox();
            BtnLoad = new Button();
            PicNomal = new PictureBox();
            DlgOpenImage = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicNomal).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtSampleText);
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(chkItalic);
            groupBox1.Controls.Add(ChkBold);
            groupBox1.Controls.Add(label);
            groupBox1.Font = new Font("나눔고딕", 8.999999F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 127);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "콤보박스, 체크박스, 텍스트 박스";
            // 
            // TxtSampleText
            // 
            TxtSampleText.Font = new Font("나눔고딕", 8.999999F);
            TxtSampleText.Location = new Point(26, 75);
            TxtSampleText.Name = "TxtSampleText";
            TxtSampleText.Size = new Size(392, 21);
            TxtSampleText.TabIndex = 4;
            TxtSampleText.Text = "Hellow,C#";
            // 
            // CboFonts
            // 
            CboFonts.Font = new Font("나눔고딕", 8.999999F);
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(71, 37);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(197, 22);
            CboFonts.TabIndex = 3;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("나눔고딕", 8.999999F, FontStyle.Italic);
            chkItalic.Location = new Point(348, 39);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(59, 18);
            chkItalic.TabIndex = 2;
            chkItalic.Text = "이텔릭";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Font = new Font("나눔고딕", 8.999999F, FontStyle.Bold);
            ChkBold.Location = new Point(292, 38);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(48, 18);
            ChkBold.TabIndex = 2;
            ChkBold.Text = "굵게";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("나눔고딕", 8.999999F);
            label.Location = new Point(26, 42);
            label.Name = "label";
            label.Size = new Size(29, 14);
            label.TabIndex = 0;
            label.Text = "폰트";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PrgDummy);
            groupBox2.Controls.Add(TrbDummy);
            groupBox2.Location = new Point(12, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(424, 124);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "트랙바, 프로그레스바";
            // 
            // PrgDummy
            // 
            PrgDummy.Location = new Point(26, 83);
            PrgDummy.Name = "PrgDummy";
            PrgDummy.Size = new Size(391, 23);
            PrgDummy.TabIndex = 3;
            // 
            // TrbDummy
            // 
            TrbDummy.Location = new Point(26, 32);
            TrbDummy.Maximum = 20;
            TrbDummy.Name = "TrbDummy";
            TrbDummy.Size = new Size(391, 45);
            TrbDummy.TabIndex = 2;
            TrbDummy.Scroll += TrbDummy_Scroll;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnQuestion);
            groupBox3.Controls.Add(BtnMsgBox);
            groupBox3.Controls.Add(BtnModaless);
            groupBox3.Controls.Add(BtnModal);
            groupBox3.Location = new Point(12, 275);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(424, 62);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "모달창,모달리스창";
            // 
            // BtnQuestion
            // 
            BtnQuestion.Location = new Point(329, 23);
            BtnQuestion.Name = "BtnQuestion";
            BtnQuestion.Size = new Size(88, 25);
            BtnQuestion.TabIndex = 1;
            BtnQuestion.Text = "...";
            BtnQuestion.UseVisualStyleBackColor = true;
            BtnQuestion.Click += BtnQuestion_Click;
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Location = new Point(221, 23);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(102, 25);
            BtnMsgBox.TabIndex = 0;
            BtnMsgBox.Text = "MessegeBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(112, 23);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(103, 25);
            BtnModaless.TabIndex = 0;
            BtnModaless.Text = "Modaless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(6, 23);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(100, 25);
            BtnModal.TabIndex = 0;
            BtnModal.Text = "Modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnAddRoot);
            groupBox4.Controls.Add(BtnAddChild);
            groupBox4.Controls.Add(LsvDummy);
            groupBox4.Controls.Add(TrvDummy);
            groupBox4.Location = new Point(12, 343);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(424, 190);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "트리뷰, 리스트뷰";
            // 
            // BtnAddRoot
            // 
            BtnAddRoot.Location = new Point(6, 149);
            BtnAddRoot.Name = "BtnAddRoot";
            BtnAddRoot.Size = new Size(90, 23);
            BtnAddRoot.TabIndex = 2;
            BtnAddRoot.Text = "루프추가";
            BtnAddRoot.UseVisualStyleBackColor = true;
            BtnAddRoot.Click += BtnAddRoot_Click;
            // 
            // BtnAddChild
            // 
            BtnAddChild.Location = new Point(112, 149);
            BtnAddChild.Name = "BtnAddChild";
            BtnAddChild.Size = new Size(92, 23);
            BtnAddChild.TabIndex = 2;
            BtnAddChild.Text = "자식추가";
            BtnAddChild.UseVisualStyleBackColor = true;
            BtnAddChild.Click += BtnAddChild_Click;
            // 
            // LsvDummy
            // 
            LsvDummy.Location = new Point(221, 22);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(196, 121);
            LsvDummy.TabIndex = 1;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.Details;
            // 
            // TrvDummy
            // 
            TrvDummy.Location = new Point(6, 22);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.Size = new Size(198, 121);
            TrvDummy.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(BtnLoad);
            groupBox5.Controls.Add(PicNomal);
            groupBox5.Location = new Point(442, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(419, 521);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "픽쳐박스";
            // 
            // BtnLoad
            // 
            BtnLoad.Location = new Point(338, 263);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(75, 23);
            BtnLoad.TabIndex = 1;
            BtnLoad.Text = "로드";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // PicNomal
            // 
            PicNomal.BackColor = SystemColors.ButtonShadow;
            PicNomal.Location = new Point(6, 22);
            PicNomal.Name = "PicNomal";
            PicNomal.Size = new Size(407, 235);
            PicNomal.TabIndex = 0;
            PicNomal.TabStop = false;
            PicNomal.Click += PicNomal_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 542);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "컨트롤 예제";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbDummy).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicNomal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtSampleText;
        private ComboBox CboFonts;
        private CheckBox chkItalic;
        private CheckBox ChkBold;
        private Label label;
        private GroupBox groupBox2;
        private ProgressBar PrgDummy;
        private TrackBar TrbDummy;
        private GroupBox groupBox3;
        private Button BtnMsgBox;
        private Button BtnModaless;
        private Button BtnModal;
        private Button BtnQuestion;
        private GroupBox groupBox4;
        private Button BtnAddRoot;
        private Button BtnAddChild;
        private ListView LsvDummy;
        private TreeView TrvDummy;
        private GroupBox groupBox5;
        private Button BtnLoad;
        private PictureBox PicNomal;
        private OpenFileDialog DlgOpenImage;
    }
}
