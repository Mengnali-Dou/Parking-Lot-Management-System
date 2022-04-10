using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.FI
{
    public class data_FIDisbursement
    {
        public string DisNum { get; set; }
        public DateTime DisTime { get; set; }
        public string DisProject { get; set; }
        public float DisSum { get; set; }
        public string ChargeOperator { get; set; }
        public string DisComment { get; set; }
    }
}
