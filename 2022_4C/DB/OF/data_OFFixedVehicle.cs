using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.OF
{
    public class data_OFFixedVehicle
    {
        public string OFFVNum { get; set; }
        public string LicensePlateNum { get; set; }
        public DateTime TopUpTime { get; set; }
        public DateTime TopUpDuration { get; set; }
        public DateTime ExpireTime { get; set; }
        public string PSSystemNum { get; set; }
        public string OFFVComment { get; set; }
    }
}
