using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.LO
{
    public class data_LOEnterExit
    {
        public string LOEENum { get; set; }
        public string OrderFormNum { get; set; }
        public string PSSystemNum { get; set; }
        public string VehicleType { get; set; }
        public string VehicleNum { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime ExitTime { get; set; }
        public DateTime LOEEParkTime { get; set; }
        public string LOEEComment { get; set; }
    }
}
