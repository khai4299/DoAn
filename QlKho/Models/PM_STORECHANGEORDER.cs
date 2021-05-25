using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_STORECHANGEORDER
    {
        public string STORECHANGEORDERID { get; set; }
        public string STORECHANGEORDERTYPE { get; set; }
        public int STORECHANGESTATUS { get; set; }
        public string STORECHANGETYPEID { get; set; }
        public string ALLOWEDOUTPUTDATE { get; set; }
        public string DATECREATE { get; set; }
        public string DATEREVIEW { get; set; }
        public string EXPECTEDDELIVERYDATE { get; set; }
        public string EXPIRYDATE { get; set; }
        public int FROMSTOREID { get; set; }
        public string INPUTTIME { get; set; }
        public string INVENTORYSTATUSID { get; set; }
        public int ISREVIEW { get; set; }
        public int ISURGENT { get; set; }
        public string SALEORDERID { get; set; }
        public int STOCKTRANSFERDAYS { get; set; }
        public int TOSTOREID { get; set; }
        public int TOTALQUANTITY { get; set; }
        public int USERCREAT { get; set; }
        public int USERREVIE { get; set; }
    }
}
