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
    public class GeneratelPAParkingSpot
    {
        /// <summary>
        /// 自动生成停车位编号
        /// </summary>
        /// <param name="PANum"></param>
        /// <returns></returns>
        public static string num(string PANum)
        {
            string mantissa = null;
            string select = $"select * from PAParkingSpot where PANum = '{PANum}'";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataTable dt = new DataTable();
            inst.Fill(dt);
            int amount = dt.Rows.Count;
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

            string PSNum = PANum + mantissa;

            return PSNum;
        }

        /// <summary>
        /// 自动生成停车位系统编号
        /// </summary>
        /// <param name="PANum"></param>
        /// <param name="PSNum"></param>
        /// <returns></returns>
        public static string system_num(string PNum,string PSNum)
        {
            string PSSystemNum = "PS" + PNum.Substring(1) + PSNum;

            return PSSystemNum;
        }
    }
}
