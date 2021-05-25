using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_PURCHASINGORDERDETAIL
    {
        public string PODETAILID { get; set; }
        public string POID { get; set; }
        public int PRODUCTID { get; set; }
        public int IMEI { get; set; }
        public int QUANTITY { get; set; }
        public string INVENTORYSTATUS { get; set; }
        public int PRICE { get; set; }
    }
}
