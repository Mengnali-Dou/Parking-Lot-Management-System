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
    public class InsertUserInformation
    {
        public static void id(string id)
        {
            string update = $"update Cache set ID = '{id}' where Num = 1";
            OleDbCommand cmd = new OleDbCommand(update, database.dbConn);
            cmd.ExecuteNonQuery();
        }

        public static void user(string name)
        {
            string update = $"update Cache set PersonalName = '{name}' where Num = 1";
            OleDbCommand cmd = new OleDbCommand(update, database.dbConn);
            cmd.ExecuteNonQuery();
        }

        public static void ASNum(string ASNum)
        {
            string update = $"update Cache set ASNum = '{ASNum}' where Num = 1";
            OleDbCommand cmd = new OleDbCommand(update, database.dbConn);
            cmd.ExecuteNonQuery();
        }
    }
}
