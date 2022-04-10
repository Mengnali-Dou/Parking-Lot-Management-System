using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.PU
{
    public class data_PUEngineeringConstruction
    {
        public string ConNum { get; set; }
        public string ItemNum { get; set; }
        public string ItemName { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndTime { get; set; }
        public string ConPark { get; set; }
        public float ConSum { get; set; }
        public string ChargeOperator { get; set; }
        public string ConComment { get; set; }
    }
}
