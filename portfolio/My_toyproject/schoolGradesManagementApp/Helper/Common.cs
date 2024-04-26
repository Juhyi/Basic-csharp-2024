using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

namespace schoolGradesManagementApp.Helper
{
    internal class Common
    {
        // 정적으로 만드는 공통 연결 문자형
        public static string ConnString = "Data Source=localhost;" +
                                          "Initial Catalog=MyToyProject;" +
                                          "Persist Security Info=True;" +
                                          "User ID=sa; Trust Server Certificate=True;Password=mssql_p@ss";
        //로그인 아이디
        public static string LoginId { get; set; }

        public static bool IsLogout { get; set; }
        public static string LoginNames {  get; set; }

        public static string GetMD5Hash(MD5 md5Hash, string input)
        {
            // 입력문자열을 byte 배열로 변환한 뒤 MD5 해시 처리
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2")); // 16진수 문자로 각 글자를 전부 변환
            }

            return builder.ToString();
        }      
    }
}

