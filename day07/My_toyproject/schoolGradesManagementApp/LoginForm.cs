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

        #region "�α���, ��ҹ�ư �̺�Ʈ�ڵ鷯"
        // ��ҹ�ư Ŭ�� �̺�Ʈ�ڵ鷯
        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // ��� ������ ������ �����.
        }

        // �α��� Ŭ�� �̺�Ʈ�ڵ鷯

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool isFail = false;
            string errMsg = string.Empty;

            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                isFail = true;
                errMsg += "Email Ȥ�� ID�� �Է��ϼ���.\n";
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                isFail = true;
                errMsg += "Password�� �Է��ϼ���.\n";
            }

            if (isFail == true)
            {
                MessageBox.Show(errMsg, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        #endregion

        #region "���̵� ��й�ȣ �ؽ�Ʈ �ʱ�â"


        // ���̵�, ��й�ȣ �ؽ�Ʈâ Ŭ���� ���� �ִ� �ؽ�Ʈ �����.
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
                TxtPassword.Focus();  //�н������ ��Ŀ�� �̵�
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
                TxtPassword.PasswordChar = '��';
            }
        }
    }
}
