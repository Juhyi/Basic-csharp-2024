namespace MyExplorer
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            TxtPath = new TextBox();
            BtnOpen = new Button();
            label1 = new Label();
            SpcExplorer = new SplitContainer();
            TrvFolder = new TreeView();
            imageSmallicon = new ImageList(components);
            LsvFile = new ListView();
            ClhTitle = new ColumnHeader();
            ClhType = new ColumnHeader();
            ClhModifiledData = new ColumnHeader();
            ClhSize = new ColumnHeader();
            imageLargeicon = new ImageList(components);
            CmsFiles = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripTextBox3 = new ToolStripTextBox();
            toolStripTextBox4 = new ToolStripTextBox();
            toolStripTextBox5 = new ToolStripTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpcExplorer).BeginInit();
            SpcExplorer.Panel1.SuspendLayout();
            SpcExplorer.Panel2.SuspendLayout();
            SpcExplorer.SuspendLayout();
            CmsFiles.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(TxtPath);
            panel1.Controls.Add(BtnOpen);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 47);
            panel1.TabIndex = 0;
            // 
            // TxtPath
            // 
            TxtPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtPath.Location = new Point(49, 13);
            TxtPath.Name = "TxtPath";
            TxtPath.ReadOnly = true;
            TxtPath.Size = new Size(690, 23);
            TxtPath.TabIndex = 2;
            // 
            // BtnOpen
            // 
            BtnOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnOpen.Location = new Point(745, 12);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(69, 24);
            BtnOpen.TabIndex = 1;
            BtnOpen.Text = "열기";
            BtnOpen.UseVisualStyleBackColor = true;
            BtnOpen.Click += BtnOpen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "경로";
            // 
            // SpcExplorer
            // 
            SpcExplorer.Dock = DockStyle.Fill;
            SpcExplorer.Location = new Point(0, 47);
            SpcExplorer.Name = "SpcExplorer";
            // 
            // SpcExplorer.Panel1
            // 
            SpcExplorer.Panel1.Controls.Add(TrvFolder);
            // 
            // SpcExplorer.Panel2
            // 
            SpcExplorer.Panel2.Controls.Add(LsvFile);
            SpcExplorer.Size = new Size(826, 426);
            SpcExplorer.SplitterDistance = 275;
            SpcExplorer.TabIndex = 1;
            // 
            // TrvFolder
            // 
            TrvFolder.BorderStyle = BorderStyle.None;
            TrvFolder.Dock = DockStyle.Fill;
            TrvFolder.ImageIndex = 0;
            TrvFolder.ImageList = imageSmallicon;
            TrvFolder.Location = new Point(0, 0);
            TrvFolder.Name = "TrvFolder";
            TrvFolder.SelectedImageIndex = 0;
            TrvFolder.Size = new Size(275, 426);
            TrvFolder.TabIndex = 0;
            TrvFolder.BeforeExpand += TrvFolder_BeforeExpand;
            TrvFolder.AfterSelect += TrvFolder_AfterSelect;
            // 
            // imageSmallicon
            // 
            imageSmallicon.ColorDepth = ColorDepth.Depth32Bit;
            imageSmallicon.ImageStream = (ImageListStreamer)resources.GetObject("imageSmallicon.ImageStream");
            imageSmallicon.TransparentColor = Color.Transparent;
            imageSmallicon.Images.SetKeyName(0, "hard-drive.png");
            imageSmallicon.Images.SetKeyName(1, "folder-normal.png");
            imageSmallicon.Images.SetKeyName(2, "folder-open.png");
            imageSmallicon.Images.SetKeyName(3, "file-exe.png");
            imageSmallicon.Images.SetKeyName(4, "file-normal.png");
            imageSmallicon.Images.SetKeyName(5, "txt.png");
            // 
            // LsvFile
            // 
            LsvFile.BorderStyle = BorderStyle.None;
            LsvFile.Columns.AddRange(new ColumnHeader[] { ClhTitle, ClhType, ClhModifiledData, ClhSize });
            LsvFile.Dock = DockStyle.Fill;
            LsvFile.LargeImageList = imageLargeicon;
            LsvFile.Location = new Point(0, 0);
            LsvFile.Name = "LsvFile";
            LsvFile.Size = new Size(547, 426);
            LsvFile.SmallImageList = imageSmallicon;
            LsvFile.TabIndex = 0;
            LsvFile.UseCompatibleStateImageBehavior = false;
            LsvFile.View = View.Details;
            LsvFile.MouseDown += LsvFile_MouseDown;
            // 
            // ClhTitle
            // 
            ClhTitle.Text = "이름";
            ClhTitle.Width = 200;
            // 
            // ClhType
            // 
            ClhType.DisplayIndex = 2;
            ClhType.Text = "유형";
            ClhType.Width = 100;
            // 
            // ClhModifiledData
            // 
            ClhModifiledData.DisplayIndex = 1;
            ClhModifiledData.Text = "수정일자";
            ClhModifiledData.Width = 100;
            // 
            // ClhSize
            // 
            ClhSize.Text = "크기";
            ClhSize.TextAlign = HorizontalAlignment.Right;
            ClhSize.Width = 100;
            // 
            // imageLargeicon
            // 
            imageLargeicon.ColorDepth = ColorDepth.Depth32Bit;
            imageLargeicon.ImageStream = (ImageListStreamer)resources.GetObject("imageLargeicon.ImageStream");
            imageLargeicon.TransparentColor = Color.Transparent;
            imageLargeicon.Images.SetKeyName(0, "hard-drive.png");
            imageLargeicon.Images.SetKeyName(1, "folder-normal.png");
            imageLargeicon.Images.SetKeyName(2, "folder-open.png");
            imageLargeicon.Images.SetKeyName(3, "file-exe.png");
            imageLargeicon.Images.SetKeyName(4, "file-normal.png");
            imageLargeicon.Images.SetKeyName(5, "txt.png");
            // 
            // CmsFiles
            // 
            CmsFiles.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            CmsFiles.Name = "CmsFiles";
            CmsFiles.Size = new Size(99, 26);
            CmsFiles.Text = "보기";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2, toolStripTextBox3, toolStripTextBox4, toolStripTextBox5 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(98, 22);
            toolStripMenuItem1.Text = "보기";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            toolStripTextBox1.Text = "큰 아이콘";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 23);
            toolStripTextBox2.Text = "작은 아이콘";
            // 
            // toolStripTextBox3
            // 
            toolStripTextBox3.Name = "toolStripTextBox3";
            toolStripTextBox3.Size = new Size(100, 23);
            toolStripTextBox3.Text = "목록";
            // 
            // toolStripTextBox4
            // 
            toolStripTextBox4.Name = "toolStripTextBox4";
            toolStripTextBox4.Size = new Size(100, 23);
            toolStripTextBox4.Text = "자세히";
            // 
            // toolStripTextBox5
            // 
            toolStripTextBox5.Name = "toolStripTextBox5";
            toolStripTextBox5.Size = new Size(100, 23);
            toolStripTextBox5.Text = "타일";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 473);
            Controls.Add(SpcExplorer);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "내 탐색기 v1.0";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            SpcExplorer.Panel1.ResumeLayout(false);
            SpcExplorer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SpcExplorer).EndInit();
            SpcExplorer.ResumeLayout(false);
            CmsFiles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TxtPath;
        private Button BtnOpen;
        private Label label1;
        private SplitContainer SpcExplorer;
        private TreeView TrvFolder;
        private ListView LsvFile;
        private ColumnHeader ClhTitle;
        private ColumnHeader ClhType;
        private ColumnHeader ClhModifiledData;
        private ColumnHeader ClhSize;
        private ImageList imageSmallicon;
        private ImageList imageLargeicon;
        private ContextMenuStrip CmsFiles;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripTextBox toolStripTextBox3;
        private ToolStripTextBox toolStripTextBox4;
        private ToolStripTextBox toolStripTextBox5;
    }
}
