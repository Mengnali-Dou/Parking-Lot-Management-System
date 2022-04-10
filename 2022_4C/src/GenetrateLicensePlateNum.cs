using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.src
{
    public class GenetrateLicensePlateNum
    {
        public static string LicensePlateNum(string ID)
        {
            string num = "WT" + ID + "0";

            return num;
        }
    }
}
