using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.BA
{
    public class data_BALeave
    {
        public string LNum { get; set; }
        public string EmployeeID { get; set; }
        public DateTime LeaveTime { get; set; }
        public DateTime BackTime { get; set; }
        public string LeaveCause { get; set; }
        public string LComment { get; set; }
    }
}
