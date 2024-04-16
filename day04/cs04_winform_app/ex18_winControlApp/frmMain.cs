namespace ex18_winControlApp
{
    public partial class frmMain : Form
    {
        Random random = new Random(); // Ʈ���� ����̸����� ����� ������
        public frmMain()
        {
            InitializeComponent();

            LsvDummy.Columns.Add("�̸�");
            LsvDummy.Columns.Add("����");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families; // ���� OS���� ��ġ�� ��Ʈ�� �� ������
            foreach (var Font in Fonts)
            {
                CboFonts.Items.Add(Font.Name);
            }
        }

        //����ü, ����, ���ڸ����� �����ϴ� �޼���

        void ChangeFont()
        {
            if (CboFonts.SelectedIndex < 0)  // �ƹ��͵� ���þȵ�
                return;

            FontStyle style = FontStyle.Regular;  // �Ϲ� ����(����X, ���Ÿ�X)�� �ʱ�ȭ

            if (ChkBold.Checked)  //���� üũ�ڽ��� üũ�ϸ�
                style |= FontStyle.Bold;

            if (chkItalic.Checked) // ���ڸ� üũ�ڽ��� üũ�ϸ�
                style |= FontStyle.Italic;

            TxtSampleText.Font = new Font((string)CboFonts.SelectedItem, 12, style);
        }

        void TreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                TreeToList(node);
            }
        }

        private void TreeToList(TreeNode node)
        {
            //throw new NotImplementedException();
            LsvDummy.Items.Add( // ����Ʈ�信 ������ �߰�
                new ListViewItem(
                    new string[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() }
                    )
                );
            foreach (TreeNode subNode in node.Nodes)
            {
                TreeToList(subNode);
            }
        }

        private void CboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        // Ʈ���� ��ũ�� �̺�Ʈ�ڵ鷯
        private void TrbDummy_Scroll(object sender, EventArgs e)
        {
            PrgDummy.Value = TrbDummy.Value; // Ʈ���� �����͸� �ű�� ���α׷����� ���� ����
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form FrmModal = new Form();
            FrmModal.Text = "���â";
            FrmModal.Width = 300;
            FrmModal.Height = 100;
            FrmModal.BackColor = Color.Red;
            FrmModal.ShowDialog();  // ���â ����
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form FrmModaless = new Form();
            FrmModaless.Text = "��޸���";
            FrmModaless.Width = 300;
            FrmModaless.Height = 100;
            FrmModaless.BackColor = Color.Green;
            FrmModaless.ShowDialog();  // ��޸���â ����
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            // �⺻���� �޽����ڽ� ����
            MessageBox.Show(TxtSampleText.Text, "�޽����ڽ�", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void BtnQuestion_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("���ƿ�?", "����", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("�� �ʹ� ����");
            }
            else if (res == DialogResult.No)
            {
                MessageBox.Show("�Ƴ� �Ⱦ!!");
            }
        }

        // ������ �����ư�� Ŭ�������� �߻��ϴ� �̺�Ʈ�ڵ鷯
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("���� �����Ͻðڽ��ϱ�?", "���Ῡ��",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) e.Cancel = true;

        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (TrvDummy.SelectedNode == null)
            { // �θ��带 �������� ������
                MessageBox.Show("������ ��尡 ����,", "���", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // ���̻� ������� �޼��� ����
            }
            TrvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            TrvDummy.SelectedNode.Expand();
            TreeToList();  // ����Ʈ�並 �ٽ� �׷��ش�
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "�̹��� ����";
            // Filter�� Ȯ���ڸ� �̹����θ� ����
            DlgOpenImage.Filter = "Image Files(*.bpm;*.jpg;*.png)|*.bpm;*.jpg;*.png";
            var res = DlgOpenImage.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                // MessageBox.Show(DlgOpenImage.FileName.ToString());
                PicNomal.Image = Bitmap.FromFile(DlgOpenImage.FileName);
            }

        }

        private void PicNomal_Click(object sender, EventArgs e)
        {
            if (PicNomal.SizeMode == PictureBoxSizeMode.Normal)
            {
                PicNomal.SizeMode = PictureBoxSizeMode.StretchImage;
            }else
            {
                PicNomal.SizeMode= PictureBoxSizeMode.Normal;   
            }
        }
    }
}
