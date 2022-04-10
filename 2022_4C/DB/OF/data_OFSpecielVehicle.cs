using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.OF
{
    public class data_OFSpecielVehicle
    {
        public string OFSVNum { get; set; }
        public string LicensePlateNum { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime ExitTime { get; set; }
        public DateTime ParkingTime { get; set; }
        public string OFSVComment { get; set; }
    }
}
