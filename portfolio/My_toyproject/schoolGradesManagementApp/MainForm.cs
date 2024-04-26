using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Data.SqlClient;

namespace schoolGradesManagementApp
{
    // 각 화면 초기화


    public partial class MainForm : MetroForm
    {

        public MainForm()
        {
            InitializeComponent();
        }

        // 폼로드 이벤트 핸들러, 로그인 창 먼저 띄우기
        private void MainForm_Load(object sender, EventArgs e)
        {
            Helper.Common.IsLogout = false;
            LoginForm frm = new LoginForm();
            frm.TopMost = true; // 위도우화면 가장 상단에
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();

            LblLogin.Text = Helper.Common.LoginId;
            LblLoginNames.Text = Helper.Common.LoginNames;

        }



        Form ShowActiveForm(Form form, Type type)
        {
            if (form == null) // 화면이 한번도 안열었으면
            {
                form = Activator.CreateInstance(type) as Form;  // 타입은 클래스타입
                form.MdiParent = this;  // 자식창의 부모는 FrmMain
                form.WindowState = FormWindowState.Normal;
                form.Show();
            }
            else
            {

                if (form.IsDisposed) // 창이 한번 닫혔으면
                {
                    form = Activator.CreateInstance(type) as Form;  // 타입은 클래스타입
                    form.MdiParent = this;  // 자식창의 부모는 FrmMain
                    form.WindowState = FormWindowState.Normal;
                    form.Show();
                }
                else // 창을 그냥 최소화, 열려있으면
                {
                    form.Activate();    //화면에 열려있는 창을 활성화
                }
            }
            return form;
        }


        // 종료버튼 이벤트 헨들러
        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show(this, "종료 하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true; // 종료 안됨
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private bool isLogin = false;

        public bool IsLogin
        {
            get { return isLogin; }
            set { isLogin = value; }
        }


        // 로그아웃버튼 이벤트 헨들러
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "로그아웃 하시겠습니까?", "로그아웃 여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Helper.Common.IsLogout = true; // 로그아웃.
                LoginForm pmf = new LoginForm();
                this.Hide();
                pmf.curParent = this;
                pmf.Show();
            }
        }

        //
        private void BtnInfo_Click(object sender, EventArgs e)
        {
            FrmStudentInfo frmStudentInfo = new FrmStudentInfo();
            frmStudentInfo.ShowDialog();
        }

     

        private void MainForm_Activated(object sender, EventArgs e)
        {
            LblLogin.Text = Helper.Common.LoginId;
            LblLoginNames.Text = Helper.Common.LoginNames;
        }
    }
}
