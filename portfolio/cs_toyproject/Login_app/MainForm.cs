

namespace Login_app
{
    public partial class LoginMain : Form
    {

        private TextBox textBox;
        public LoginMain()
        {
            InitializeComponent();

            // 텍스트 상자 생성
            textBox = new TextBox();
            textBox.Dock = DockStyle.Top;
            this.Controls.Add(textBox);

            // 이미지 로드
            string imagePath = "path_to_your_image_file.jpg"; // 이미지 파일의 경로를 지정하세요
            Image icon = Image.FromFile(imagePath);

            // 아이콘과 텍스트 상자의 간격 설정
            int iconSpacing = 5;
            int iconTop = (textBox.Height - icon.Height) / 2;
            int iconLeft = iconSpacing;

            // 아이콘과 함께 텍스트 상자에 그리기
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
                MessageBox.Show("로그인에 성공했습니다.", "Login");
            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.", "Login");
            }
        }
    }
}
