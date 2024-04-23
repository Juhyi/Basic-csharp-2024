using MetroFramework.Forms;

namespace schoolGradesManagementApp
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        private bool isLogin = false;

        private string connstring = "Data Source=localhost;" +
                                    "Initial Catalog=BookRentalShop2024;" +
                                    "Persist Security Info=True;" +
                                    "User ID=sa;Encrypt=False";

        public bool IsLogin
        {
            get { return isLogin; }
            set { isLogin = value; }
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        #region "로그인, 취소버튼 이벤트핸들러"
        // 취소버튼 클릭 이벤트핸들러
        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // 취소 누르면 무조건 종료됨.
        }

        // 로그인 클릭 이벤트핸들러

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool isFail = false;
            string errMsg = string.Empty;

            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                isFail = true;
                errMsg += "Email 혹은 ID를 입력하세요.\n";
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                isFail = true;
                errMsg += "Password를 입력하세요.\n";
            }

            if (isFail == true)
            {
                MessageBox.Show(errMsg, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        #endregion

        #region "아이디 비밀번호 텍스트 초기창"


        // 아이디, 비밀번호 텍스트창 클릭시 원래 있던 텍스트 비워짐.
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            TxtPassword.Text = "";
        }

        private void TxtUserId_TextChanged(object sender, EventArgs e)
        {
            // TxtUserId.Text = string.Empty;
        }
        #endregion



        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtPassword.Focus();  //패스워드로 포커스 이동
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnLogin_Click(sender, e);
            }
        }

        private void ChkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShowPass.Checked == true)
            {
                TxtPassword.PasswordChar = default(char);
            }
            else
            {
                TxtPassword.PasswordChar = '●';
            }
        }
    }
}
