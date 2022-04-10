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
    /// 自动生成临时车辆订单订单号
    /// </summary>
    public class GeneratelOFTVNum
    {
        public static string num()
        {
            string mantissa = null;
            string select = $"select OFTVNum from OFTemporaryVehicle where EnterTime like '{DateTime.Now.ToShortDateString().ToString()}'";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataTable dt = new DataTable();
            inst.Fill(dt);
            int amount = dt.Rows.Count;

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

        public static string OFTVNum(string ParkNum)
        {
            string mantissa = num();
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

            string OFTVNum = "LDD" + y + m + d + ParkNum + mantissa;

            return OFTVNum;
        }
    }
}
