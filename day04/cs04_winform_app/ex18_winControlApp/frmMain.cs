namespace ex18_winControlApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
    }
}
