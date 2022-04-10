using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.PU
{
    public class data_PUEquipmentPurchasing
    {
        public string PurNum { get; set; }
        public DateTime PurName { get; set; }
        public string EquNum { get; set; }
        public int PurAmount { get; set; }
        public float PurSum { get; set; }
        public string ParkNum { get; set; }
        public string ChargeOperator { get; set; }
        public string PurComment { get; set; }
    }
}
