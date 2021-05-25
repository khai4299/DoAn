using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_STORECHANGEORDERDETAIL
    {
        public string STORECHANGEORDERDETAILID { get; set; }
        public string STORECHANGEORDERID { get; set; }
        public int PRODUCTID { get; set; }
        public string INPUTTIME { get; set; }
        public string INVENTORYSTATUSID { get; set; }
        public string NOTE { get; set; }
        public int QUANTITY { get; set; }
        public int STORECHANGEQUANTITY { get; set; }
    }
}
