using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_STORECHANGEDETAIL
    {
        public string STORECHANGEDETAILID { get; set; }
        public int STORECHANGEID { get; set; }
        public int QUANTITY { get; set; }
        public int IMEI { get; set; }
        public string STORECHANGEORDERDETAILID { get; set; }
        public string OUTPUTVOUCHERDETAILID { get; set; }
        public string INPUTVOUCHERDETAILID { get; set; }
        public string INPUTTIME { get; set; }
        public string INVENTORYSTATUSID { get; set; }
        public int TOTALSIZE { get; set; }
        public int TOTALWEIGHT { get; set; }
    }
}
