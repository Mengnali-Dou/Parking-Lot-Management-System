using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.FI
{
    public class data_FIVehicleCharge
    {
        public string ChargeNum { get; set; }
        public DateTime ChargeTime { get; set; }
        public float Cost { get; set; }
        public string OFNum { get; set; }
        public string ChargeOperator { get; set; }
        public string FIVCComment { get; set; }
    }
}
