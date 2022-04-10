using _2022_4C.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.src
{
    public class GenerateDisNum
    {
        public static string num()
        {
            string mantissa = null;
            string select = $"select count(DisNum) from FIDisbursement where DisNum like '*{GenerateYMD.YMD()}*'";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataTable dt = new DataTable();
            inst.Fill(dt);
            int amount = Convert.ToInt32(dt.Rows[0][0]);

            if (amount < 10)
            {
                mantissa = "00" + amount.ToString();
            }
            else if (amount < 100)
            {
                mantissa = "0" + amount.ToString();
            }
            else
            {
                mantissa = amount.ToString();
            }

            return mantissa;
        }

        public static string DisNum(string park)
        {
            string DisNum = "ZC" + GenerateYMD.YMD() + park + num();

            return DisNum;
        }
    }
}
