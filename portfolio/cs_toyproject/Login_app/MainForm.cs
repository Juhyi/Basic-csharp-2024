

namespace Login_app
{
    public partial class LoginMain : Form
    {

        private TextBox textBox;
        public LoginMain()
        {
            InitializeComponent();

            // �ؽ�Ʈ ���� ����
            textBox = new TextBox();
            textBox.Dock = DockStyle.Top;
            this.Controls.Add(textBox);

            // �̹��� �ε�
            string imagePath = "path_to_your_image_file.jpg"; // �̹��� ������ ��θ� �����ϼ���
            Image icon = Image.FromFile(imagePath);

            // �����ܰ� �ؽ�Ʈ ������ ���� ����
            int iconSpacing = 5;
            int iconTop = (textBox.Height - icon.Height) / 2;
            int iconLeft = iconSpacing;

            // �����ܰ� �Բ� �ؽ�Ʈ ���ڿ� �׸���
            textBox.Paint += (sender, e) =>
            {
                e.Graphics.DrawImage(icon, new Point(iconLeft, iconTop));
            };
        }
    }

        private void Btnlog_Click(object sender, EventArgs e)
        {
            
            string userID = id.Text;
            string userPassword = password.Text;

            if(userID.Equals("Myid") && userPassword.Equals("MyPassword"))
            {
                MessageBox.Show("�α��ο� �����߽��ϴ�.", "Login");
            }
            else
            {
                MessageBox.Show("�α��ο� �����߽��ϴ�.", "Login");
            }
        }
    }
}
