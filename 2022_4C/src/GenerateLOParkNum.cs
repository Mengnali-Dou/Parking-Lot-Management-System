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
    /// <summary>
    /// 自动生成停车场日志编号
    /// </summary>
    public class GenerateLOParkNum
    {
        public static string num()
        {
            int i = 1;
            string mantissa = null;
            
            DateTime date = DateTime.Now;
            date.ToShortDateString().ToString();

            string select = $"select LOPNum from LOPark where LOPDate = '{date}'";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataTable dt = new DataTable();
            inst.Fill(dt);
            i = dt.Rows.Count;

            

            if (i < 10)
            {
                mantissa = "00" + i.ToString();
            }
            else if (i >= 10 && i < 100)
            {
                mantissa = "0" + i.ToString();
            }
            else
            {
                mantissa = i.ToString();
            }

            return mantissa;
        }

        public static string generate()
        {
            string mantissa = num();

            DateTime date = DateTime.Now;
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;

            string y = null, m = null, d = null;

            if (year - 2000 < 10)
            {
                y = "0" + (year - 2000).ToString();
            }
            else
            {
                y = (year - 2000).ToString();
            }

            if (month < 10)
            {
                m = "0" + month.ToString();
            }
            else
            {
                m = month.ToString();
            }

            if (day < 10)
            {
                d = "0" + day.ToString();
            }
            else
            {
                d = day.ToString();
            }

            string LOPNum = "LOP" + y + m + d + mantissa;

            return LOPNum;
        }
    }
}
