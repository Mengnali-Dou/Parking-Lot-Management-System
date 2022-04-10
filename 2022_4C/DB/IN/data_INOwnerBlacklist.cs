using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.IN
{
    public class data_INOwnerBlacklist
    {
        public string OwnerID { get; set; }
        public string OwnerName { get; set; }
        public string OSignReason { get; set; }
        public DateTime OSignTime { get; set; }
        public string OOperator { get; set; }
        public string OComment { get; set; }
    }
}
