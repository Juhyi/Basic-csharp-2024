namespace BookRentalShopApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // �� ���� ������ null
            // �� ���� ������ null���� ���� �� �ֵ��� ������� ��� Nullable
            int? a = null;
            MessageBox.Show(a.ToString());
        }
    }
}
