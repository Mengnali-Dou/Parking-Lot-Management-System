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
    public class UserInformation
    {
        public static string id()
        {
            string select = "select ID from Cache where Num = 1";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataTable dt = new DataTable();
            inst.Fill(dt);

            string id = dt.Rows[0][0].ToString();

            return id;
        }

        public static string user()
        {
            string select = "select PersonalName from Cache where Num = 1";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataTable dt = new DataTable();
            inst.Fill(dt);

            string name = dt.Rows[0][0].ToString();

            return name;
        }

        public static string ASNum()
        {
            string select = "select ASNum from Cache where Num = 1";
            OleDbDataAdapter inst = new OleDbDataAdapter(select, database.dbConn);
            DataTable dt = new DataTable();
            inst.Fill(dt);

            string ASNum = dt.Rows[0][0].ToString();

            return ASNum;
        }
    }
}
