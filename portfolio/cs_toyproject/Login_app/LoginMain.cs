

namespace Login_app
{
    public partial class LoginMain : Form
    {
      
        public LoginMain()
        {
            InitializeComponent();
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
