using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_STORECHANGE
    {
        public string STORECHANGEID { get; set; }
        public string STORECHANGETYPE { get; set; }
        public string STORECHANGEORDERID { get; set; }
        public int FROMSTOREID { get; set; }
        public int TOSTOREID { get; set; }
        public int CASKCODE { get; set; }
        public int COMECONFIRMUSER { get; set; }
        public string COMEDATE { get; set; }
        public string INVENTORYSTATUSID { get; set; }
        public string INVOUCHERID { get; set; }
        public int ISCOME { get; set; }
        public int ISRECEIVE { get; set; }
        public int ISTRANSFERED { get; set; }
        public int ISURGENT { get; set; }
        public string OUTVOUCHERID { get; set; }
        public string RECEIVENOTE { get; set; }
        public string STORECHANGEDATE { get; set; }
        public int STORECHANGEUSER { get; set; }
        public int TOTALPACKING { get; set; }
        public int TOTALSHIPPINGCOST { get; set; }
        public int TOTALSIZE { get; set; }
        public int TOTALWEIGHT { get; set; }
        public int TOUSER1 { get; set; }
        public int TOUSER2 { get; set; }
        public string TRANSFEREDDATE { get; set; }
        public int TRANSFEREDUSER { get; set; }
        public string TRANSPORTVOUCHERID { get; set; }
        public int TRANSPORTVOUCHERUSER { get; set; }
        public int USERCREATE { get; set; }
        public int USERRECEIVE { get; set; }
    }
}
