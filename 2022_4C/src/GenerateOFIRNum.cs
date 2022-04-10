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
    public class GenerateOFIRNum
    {
        public static string num()
        {
            string mantissa = null;
            string select = $"select count(OFIRNum) from OFIdleRent where OFIRNum like '*{DateTime.Now.ToShortDateString()}*'";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataTable dt = new DataTable();
            inst.Fill(dt);
            int amount = Convert.ToInt32(dt.Rows[0][0]);

            if (amount < 10)
            {
                mantissa = "0000" + amount.ToString();
            }
            else if (amount < 100)
            {
                mantissa = "000" + amount.ToString();
            }
            else if (amount < 1000)
            {
                mantissa = "00" + amount.ToString();
            }
            else if (amount < 10000)
            {
                mantissa = "0" + amount.ToString();
            }
            else
            {
                mantissa = amount.ToString();
            }

            return mantissa;
        }

        public static string OFIRNum(string park)
        {
            DateTime dt = DateTime.Now;
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;

            string y, m, d;
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

            string mantissa = num();
            string OFIRNum = "XCZ" + y + m + d +park + mantissa;

            return OFIRNum;
        }
    }
}
