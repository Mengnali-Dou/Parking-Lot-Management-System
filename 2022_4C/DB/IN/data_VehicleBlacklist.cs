using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.IN
{
    public class data_VehicleBlacklist
    {
        public string VehicleNum { get; set; }
        public string VSignReason { get; set; }
        public DateTime VSignDate { get; set; }
        public string VOperator { get; set; }
        public string VBComment { get; set; }
    }
}
