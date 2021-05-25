using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_CURRENTINSTOCK
    {
        public string INVENTORYSTATUSID { get; set; }
        public int LOCKQUANTITY { get; set; }
        public int QUANTITY { get; set; }
        public int SCORDERLOCKQUANTITY { get; set; }
        public int STATUSLOCKQUANTITY { get; set; }
        public int STORECHANGEQUANTITY { get; set; }
        public int STOREID { get; set; }
        public int PRODUCTID { get; set; }
    }
}
