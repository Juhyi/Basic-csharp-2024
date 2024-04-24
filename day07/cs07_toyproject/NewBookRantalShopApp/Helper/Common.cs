using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NewBookRantalShopApp.Helper
{
    public class Common
    {
        // 정적으로 만드는 공통 연결 문자열
        public static string ConnString =  " Data Source=localhost;" +
                                            "Initial Catalog=BookRentalShop2024;" +
                                            "Persist Security Info=True;" +
                                            "User ID=sa;Encrypt=False;Password=mssql_p@ss";

        // 로그인 아이디
        public static string LoginId { get; set; }
        
        // 회원선택 팝업에서 대출화면으로 넘길데이터 정적프로퍼티들
        public static string SelMemberIdx {  get; set; }
        public static string SelMemberName { get; set; }
        public static string SelBookIdx { get; set; }
        public static string SelBookName { get; set; }


        // MD5 해시 알고리즈 암호화

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
