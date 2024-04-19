

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
                MessageBox.Show("로그인에 성공했습니다.", "Login");
            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.", "Login");
            }
        }
    }
}
