using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.data
{
    public class database
    {
        // 获取数据库文件地址
        static string fileThis = Environment.CurrentDirectory;
        static string fileParent = Directory.GetParent(fileThis).FullName;
        static string fileDir = Directory.GetParent(fileParent).FullName;
        // 获取数据库地址
        static string sql = fileDir + @"\db_tcc.accdb";
        // 连接数据库
        static string conn = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{sql}'";
        static public OleDbConnection dbConn = new OleDbConnection(conn);
    }
}
