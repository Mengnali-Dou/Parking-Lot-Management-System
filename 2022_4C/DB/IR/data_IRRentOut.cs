using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.IR
{
    public class data_IRRentOut
    {
        public string StallSystemNum { get; set; }
        public string CarOwnerID { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string ROComment { get; set; }
    }
}
