﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace NewBookRantalShopApp
{
    public partial class FrmBookInfo : MetroForm
    {
        private bool isNew = false;  // false => UPDATE, ture => INSERT
        
        public FrmBookInfo()
        {
            InitializeComponent();
        }

       
        private void FrmBookInfo_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            isNew = true;   
            TxtBookIdx.Text = TxtAuthor.Text = string.Empty;
            TxtBookIdx.ReadOnly = false; // 최초 입력할때는 PK값을 입력해줘야함.
            TxtBookIdx.Focus();    // 순번은 자동증가하기 때문에 입력불가
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           
            // 입력검증, 아이디와 비밀번호를 안 넣으면
            if (string.IsNullOrEmpty(TxtBookIdx.Text))
            {
                MessageBox.Show("구분코드를 입력하세요.");
                return;
            }


            if (string.IsNullOrEmpty(TxtAuthor.Text))
            {
                MessageBox.Show("구분명을 입력하세요.");
                return;
            }

      

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    conn.Open();

                    var query = "";
                    if (isNew)  // INSERT이면
                    {
                        query = @"INSERT INTO divtbl
                                       ( Division
                                       , Names)
                                  VALUES
                                       ( @Division
                                       , @Names)";

                    }
                    else
                    {
                        // UPDATE
                        query = @"UPDATE divtbl
                                 SET Names = @Names
                               WHERE Division = @Division";
                    }



                    SqlCommand cmd = new SqlCommand(query, conn);
                  
                    //SqlParameter prmUserIdx = new SqlParameter("@userIdx", TxtUserIdx.Text);
                    SqlParameter prmDivision = new SqlParameter("@Division", TxtBookIdx.Text);
                    SqlParameter prmNames = new SqlParameter("@Names",TxtAuthor.Text);  
                    //Command에 Parameter를 연결해줘야함.
                    //cmd.Parameters.Add(prmUserIdx);
                    cmd.Parameters.Add(prmDivision);
                    cmd.Parameters.Add(prmNames);

                    var result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        // this 메시지박스의 부모창이 누구냐, FrmLoginUSer
                        MetroMessageBox.Show(this, "저장성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("저장성공!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("저장실패!", "저장", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            RefreshData();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtBookIdx.Text))   // 사용자아이순번이 없으면
            { 
                MetroMessageBox.Show(this, "삭제할 구분값을 선택하세요", "오류", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            var answer = MetroMessageBox.Show(this, "정말 삭제하시겠습니까?", "삭제여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                var query = @"DELETE FROM divtbl   WHERE Division = @Division";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmDivision = new SqlParameter("@Division", TxtBookIdx.Text);
                cmd.Parameters.Add(prmDivision);

                var result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MetroMessageBox.Show(this, "삭제성공!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "삭제실패!", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

           TxtBookIdx.Text = TxtAuthor.Text=string.Empty;
            RefreshData();
        }

        //데이터그리드뷰에 데이터를 새로 부르기
        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();

                var query = @"SELECT [bookIdx]
                                      ,[Author]
                                      ,[Division]
                                      ,[Names]
                                      ,[ReleaseDate]
                                      ,[ISBN]
                                      ,[Price]
                                  FROM [dbo].[bookstbl]";   // 화면에 필요한 테이블 쿼리 변경

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "divtbl");

                DgvResult.DataSource = ds.Tables[0];
                DgvResult.ReadOnly = true;  // 수정불가
                DgvResult.Columns[0].HeaderText = "도서번호";
                DgvResult.Columns[1].HeaderText = "저자";
                DgvResult.Columns[2].HeaderText = "분류 코드";
                DgvResult.Columns[3].HeaderText = "도서 제목";
                DgvResult.Columns[4].HeaderText = "출판일";
                DgvResult.Columns[5].HeaderText = "ISBN";
                DgvResult.Columns[6].HeaderText = "도서 가격";
            }
        }

        private void DgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)  //아무것도 선택하지 않으면 -1
            {
                var selData = DgvResult.Rows[e.RowIndex];    // 내가 선택한 인덱스값
                TxtBookIdx.Text = selData.Cells[0].Value.ToString();
                TxtAuthor.Text = selData.Cells[1].Value.ToString();
                TxtBookIdx.ReadOnly = true;    // UPDATE시는 PK인 Division을 변경하면 안됨.

                isNew = false;  // UPDATE

            }
        }

    }
}
