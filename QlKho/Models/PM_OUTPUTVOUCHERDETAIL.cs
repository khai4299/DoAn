using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_OUTPUTVOUCHERDETAIL
    {
        public string OUTPUTVOUCHERDETAILID { get; set; }
        public string OUTPUTVOUCHERID { get; set; }
        public int INSTOCKSTOREID { get; set; }
        public string INVENTORYSTATUSID { get; set; }
        public string OUTPUTTYPE { get; set; }
        public int PRODUCTID { get; set; }
        public int QUANTITY { get; set; }
        public string RELATEVOUCHERID { get; set; }
        public int REPLICATIONSTOREID { get; set; }
        public string SALEORDERDETAILID { get; set; }
    }
}
