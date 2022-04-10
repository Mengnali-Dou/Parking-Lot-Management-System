using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.OF
{
    public class data_OFIdleRent
    {
        public string OFIRNum { get; set; }
        public string PSSystemNum { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime ExitTime { get; set; }
        public DateTime ParkingTime { get; set; }
        public float Cost { get; set; }
        public string OFIRComment { get; set; }
    }
}
