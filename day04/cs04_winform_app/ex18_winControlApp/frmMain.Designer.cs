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
            groupBox1 = new GroupBox();
            TxtSampleText = new TextBox();
            CboFonts = new ComboBox();
            chkItalic = new CheckBox();
            ChkBold = new CheckBox();
            label = new Label();
            groupBox1.SuspendLayout();
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
            groupBox1.Size = new Size(436, 127);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "콤보박스, 체크박스, 텍스트 박스";
            // 
            // TxtSampleText
            // 
            TxtSampleText.Font = new Font("나눔고딕", 8.999999F);
            TxtSampleText.Location = new Point(26, 75);
            TxtSampleText.Name = "TxtSampleText";
            TxtSampleText.Size = new Size(384, 21);
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
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 594);
            Controls.Add(groupBox1);
            Name = "frmMain";
            Text = "컨트롤 예제";
            Load += frmMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtSampleText;
        private ComboBox CboFonts;
        private CheckBox chkItalic;
        private CheckBox ChkBold;
        private Label label;
    }
}
