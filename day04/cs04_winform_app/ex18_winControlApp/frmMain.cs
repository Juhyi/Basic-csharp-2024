namespace ex18_winControlApp
{
    public partial class frmMain : Form
    {
        Random random = new Random(); // 트리뷰 노드이름으로 사용할 랜덤값
        public frmMain()
        {
            InitializeComponent();

            LsvDummy.Columns.Add("이름");
            LsvDummy.Columns.Add("깊이");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families; // 현재 OS내에 설치된 폰트를 다 가져와
            foreach (var Font in Fonts)
            {
                CboFonts.Items.Add(Font.Name);
            }
        }

        //글자체, 볼드, 이텔릭으로 변경하는 메서드

        void ChangeFont()
        {
            if (CboFonts.SelectedIndex < 0)  // 아무것도 선택안됨
                return;

            FontStyle style = FontStyle.Regular;  // 일반 글자(볼드X, 이탤릭X)로 초기화

            if (ChkBold.Checked)  //굵게 체크박스를 체크하면
                style |= FontStyle.Bold;

            if (chkItalic.Checked) // 이텔릭 체크박스를 체크하면
                style |= FontStyle.Italic;

            TxtSampleText.Font = new Font((string)CboFonts.SelectedItem, 12, style);
        }

        void TreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                TreeToList(node);
            }
        }

        private void TreeToList(TreeNode node)
        {
            //throw new NotImplementedException();
            LsvDummy.Items.Add( // 리스트뷰에 아이템 추가
                new ListViewItem(
                    new string[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() }
                    )
                );
            foreach (TreeNode subNode in node.Nodes)
            {
                TreeToList(subNode);
            }
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

        // 트래바 스크롤 이벤트핸들러
        private void TrbDummy_Scroll(object sender, EventArgs e)
        {
            PrgDummy.Value = TrbDummy.Value; // 트랙바 포인터를 옮기면 프로그래스바 값이 변경
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form FrmModal = new Form();
            FrmModal.Text = "모달창";
            FrmModal.Width = 300;
            FrmModal.Height = 100;
            FrmModal.BackColor = Color.Red;
            FrmModal.ShowDialog();  // 모달창 띠우기
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form FrmModaless = new Form();
            FrmModaless.Text = "모달리스";
            FrmModaless.Width = 300;
            FrmModaless.Height = 100;
            FrmModaless.BackColor = Color.Green;
            FrmModaless.ShowDialog();  // 모달리스창 띠우기
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            // 기본적인 메시지박스 사용법
            MessageBox.Show(TxtSampleText.Text, "메시지박스", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void BtnQuestion_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("좋아용?", "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("웅 너무 좋앙");
            }
            else if (res == DialogResult.No)
            {
                MessageBox.Show("아녀 싫어여!!");
            }
        }

        // 윈도우 종료버튼을 클릭했을때 발생하는 이벤트핸들러
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("정말 종료하시겠습니까?", "종료여부",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) e.Cancel = true;

        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (TrvDummy.SelectedNode == null)
            { // 부모노드를 선택하지 않으면
                MessageBox.Show("선택한 노드가 없음,", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 더이상 진행없이 메서드 종료
            }
            TrvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            TrvDummy.SelectedNode.Expand();
            TreeToList();  // 리스트뷰를 다시 그려준다
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "이미지 열기";
            // Filter는 확장자를 이미지로만 한정
            DlgOpenImage.Filter = "Image Files(*.bpm;*.jpg;*.png)|*.bpm;*.jpg;*.png";
            var res = DlgOpenImage.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                // MessageBox.Show(DlgOpenImage.FileName.ToString());
                PicNomal.Image = Bitmap.FromFile(DlgOpenImage.FileName);
            }

        }

        private void PicNomal_Click(object sender, EventArgs e)
        {
            if (PicNomal.SizeMode == PictureBoxSizeMode.Normal)
            {
                PicNomal.SizeMode = PictureBoxSizeMode.StretchImage;
            }else
            {
                PicNomal.SizeMode= PictureBoxSizeMode.Normal;   
            }
        }
    }
}
