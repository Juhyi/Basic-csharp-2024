using MetroFramework.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;



namespace schoolGradesManagementApp
{
    public partial class LoginForm : MetroForm
    {
        private bool isLogin = false;

        public MainForm curParent = null;
        
        public bool IsLogin
        {
            get { return isLogin; }
            set { isLogin = value; }
        }

        public LoginForm()
        {
            InitializeComponent();

            string empty = string.Empty;
            TxtUserId.Text = empty;
            TxtPassword.Text = string.Empty;
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

            MainForm mainForm = new MainForm();

            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                isFail = true;
                errMsg += "학번을 입력하세요.\n";
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
            // DB연계
            IsLogin = LoginProcess();   // 로그인을 성공하면 True, 실패하면 False
            if (IsLogin)
            {
                if (Helper.Common.IsLogout == false) { // 최초 로그인시
                    this.Close();
                } 
                else // 로그아웃 후 재로그인
                {
                    curParent.Show();
                    this.Close();
                }
            }
        }
        #endregion



        // 로그인 DB연계 시작
        private bool LoginProcess()
        {
            var md5Hash = MD5.Create();

            string userId = TxtUserId.Text;
            string password = TxtPassword.Text;
            string chkUserId = string.Empty;
            string chkPassword = string.Empty;



            /*
             * 1. Connection 생성, 오픈
             * 2. 쿼리 문자열 작성
             * 3. SqlCommand 명령 객체 생성
             * 4. SqlParameter 객체 생성
             * 5. Select SqlDataReader 또는 SqlDataSet 객체 사용
             * 6. CUD 작업 SqlCommand.ExecuteQuery()
             * 7. Connection 닫기
             */

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();

                string query = @"SELECT userid
                                      ,[password]
                                   FROM usertbl
                                  WHERE userId = @userId
                                    AND [password] = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmUserId = new SqlParameter("@userId", userId);
                //SqlParameter prmPassword = new SqlParameter("@Password", Helper.Common.GetMD5Hash(md5Hash, password));
                SqlParameter prmPassword = new SqlParameter("@Password", password);

                cmd.Parameters.Add(prmUserId);
                cmd.Parameters.Add(prmPassword);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    chkUserId = reader["userId"] != null ? reader["userId"].ToString() : "-";   // 유저아이디가 null일때 = 변경
                    chkPassword = reader["password"] != null ? reader["password"].ToString() : "-";
                    Helper.Common.LoginId = chkUserId;  // 로그인된 아이디.



                    return true;
                }
                else
                {
                    MessageBox.Show("로그인 정보가 없습니다.", "DB오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }


            }
        }


        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnLogin_Click(sender, e);
            }
        }

        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtPassword.Focus();  //패스워드로 포커스 이동
            }
        }

        // 비밀번호 보기 클릭
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
