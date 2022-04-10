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
    public class GenerateFVOwnerID
    {
        public static string FVOwnerID()
        {
            DateTime date = DateTime.Now;
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;

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

            string mantissa = null;
            string select = $"select FVOwnerID from VOFixedVehicle where FVOwnerID like 'FV{y}{m}{d}%'";
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

            return mantissa;
        }
    }
}
