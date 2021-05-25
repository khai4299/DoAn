using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_CURRENTINSTOCKDETAIL
    {
        public string INPUTVOUCHERDETAILID { get; set; }
        public string INVENTORYSTATUSID { get; set; }
        public int ISORDER { get; set; }
        public string NOTE { get; set; }
        public int PRODUCTID { get; set; }
        public int ORDERID { get; set; }
        public string INPUTTIME { get; set; }
        public int STOREID { get; set; }
    }
}
