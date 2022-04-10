using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_4C.DB.TR
{
    public class data_TRVehicleTraffic
    {
        public string TraNum { get; set; }
        public DateTime TraTime { get; set; }
        public string TraType { get; set; }
        public string TraPlace { get; set; }
        public string OwnerName { get; set; }
        public string OwnerTel { get; set; }
        public string Traffic { get; set; }
        public string TraComment { get; set; }
    }
}
