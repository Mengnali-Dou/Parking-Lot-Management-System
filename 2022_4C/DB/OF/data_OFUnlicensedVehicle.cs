using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.OF
{
    public class data_OFUnlicensedVehicle
    {
        public string OFUVNum { get; set; }
        public string Vehicle { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime ExitTime { get; set; }
        public DateTime ParkingTime { get; set; }
        public string PSSystemNum { get; set; }
        public string OPUVComment { get; set; }
    }
}
