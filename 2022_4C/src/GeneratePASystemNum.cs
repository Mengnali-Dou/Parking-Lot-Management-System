using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.src
{
    public class GeneratePASystemNum
    {
        public static string letter(int i)
        {
            int ascii = i + 65;    // 字母的ASCII码
            string letter = ((char)ascii).ToString();    // 字母

            return letter;
        }

        public static string PASystemNum(string letter, string PSystemNum)
        {
            string PANum = PSystemNum.Substring(1);    // 停车场编号
            string PASystemNum = "PA" + PANum + letter;

            return PASystemNum;
        }
    }
}
