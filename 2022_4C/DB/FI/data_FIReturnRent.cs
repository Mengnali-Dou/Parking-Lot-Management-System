using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.FI
{
    public class data_FIReturnRent
    {
        public string ReNum { get; set; }
        public DateTime ReTime { get; set; }
        public float ReSum { get; set; }
        public string ReOwnerID { get; set; }
        public string ReParking { get; set; }
        public string ChargeOperator { get; set; }
        public string ReComment { get; set; }
    }
}
