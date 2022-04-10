using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.LO
{
    public class data_LOIdleRent
    {
        public string LOIRNum { get; set; }
        public string PSSystemNum { get; set; }
        public string ParkingVehicle { get; set; }
        public DateTime ParkingTime { get; set; }
        public DateTime LeaveTime { get; set; }
        public string IRComment { get; set; }
    }
}
