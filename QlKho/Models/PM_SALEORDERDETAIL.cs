using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_SALEORDERDETAIL
    {
        public string SALEORDERDETAILID { get; set; }
        public string SALEORDERID { get; set; }
        public int PRODUCTID { get; set; }
        public int IMEI { get; set; }
        public int QUANTITY { get; set; }
        public string INPUTTIME { get; set; }
        public string OUTPUTTYPE { get; set; }
        public string INPUTVOUCHERDETAILID { get; set; }
        public int INVENTORYSTATUSID { get; set; }
        public int ISOUTPUT { get; set; }
        public string NOTE { get; set; }
        public int SALEPRICE { get; set; }
        public float VAT { get; set; }
    }
}
