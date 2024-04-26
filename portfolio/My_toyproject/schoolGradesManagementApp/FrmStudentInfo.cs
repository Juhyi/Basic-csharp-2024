using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace schoolGradesManagementApp
{
    public partial class FrmStudentInfo : MetroForm
    {
        public FrmStudentInfo()
        {
            InitializeComponent();

            RefreshData();
        }

        private void RefreshData()
        {

            
            string chkUserNames = string.Empty;

            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                var query = @"SELECT  [useridx]
                                      ,[userid]
                                      ,[grade]
                                      ,[birth]
                                      ,[departName]
                                      ,[score]
                                      ,[Names]
                                      ,[Mobile]
                                      ,[Email]
                                      ,[Address]
                                  FROM [dbo].[usertbl]
                                 WHERE userid = @userid";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlParameter prmUserId = new SqlParameter("@userid", Helper.Common.LoginId);
                cmd.Parameters.Add(prmUserId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "usertbl");

                TxtUserNames.Text = ds.Tables[0].Rows[0]["Names"].ToString();
                TxtUserId.Text = ds.Tables[0].Rows[0]["userId"].ToString();
                TxtUserBirth.Text = ds.Tables[0].Rows[0]["birth"].ToString();
                TxtUserDept.Text = ds.Tables[0].Rows[0]["departName"].ToString();
                TxtUserGrade.Text = ds.Tables[0].Rows[0]["grade"].ToString();

                TxtUserScore.Text = ds.Tables[0].Rows[0]["score"].ToString();
                TxtUserMoblie.Text = ds.Tables[0].Rows[0]["Mobile"].ToString();
                TxtuserEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                TxtUserAddr.Text = ds.Tables[0].Rows[0]["Address"].ToString();

                SqlDataReader reader = cmd.ExecuteReader();

                SqlParameter Names = new SqlParameter("@Names", Helper.Common.LoginId);
                cmd.Parameters.Add(Names);

                if (reader.Read())
                {
      
                    chkUserNames = reader["Names"] != null ? reader["Names"].ToString() : "-";
                    Helper.Common.LoginNames = chkUserNames;
                    
                }
            }


            using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
            {
                conn.Open();
                var query = @"SELECT   c.[course]
                                      ,c.[coursescore]
                                  FROM [userCourse] AS c
                                  JOIN usertbl AS  u
                                    ON c.userid = u.userid
                                ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "userCourse");

                DgvScore.DataSource = ds.Tables[0];
                DgvScore.ReadOnly = true; // 수정불가
                DgvScore.Columns[0].HeaderText = "수강과목";
                DgvScore.Columns[1].HeaderText = "성적";


                DgvScore.Columns[0].Width = 240;
                DgvScore.Columns[1].Width = 240;
            }



        }
    }
}
