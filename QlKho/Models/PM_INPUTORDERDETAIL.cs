using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_INPUTORDERDETAIL
    {
        public string INPUTVOUCHERDETAILID { get; set; }
        public string INPUTVOUCHERID { get; set; }
        public int PRODUCTID { get; set; }
        public int IMEI { get; set; }
        public string INPUTTIME { get; set; }
        public string PRODUCTIONDATE { get; set; }
        public int QUANTITY { get; set; }
        public int REPLICATIONSTOREID { get; set; }
        public string RETURNDATE { get; set; }
        public int SALEPRICE { get; set; }
        public int STANDARDPRICE { get; set; }
        public float VAT { get; set; }
        public float VATPERCENT { get; set; }
        public int ADJUSTPRICEUSER { get; set; }
        public string BUYINPUTVOUCHERDETAILID { get; set; }
        public string BUYINPUTVOUCHERID { get; set; }
        public string BUYINVOICEDATE { get; set; }
        public int BUYPRICE { get; set; }
        public float DISCOUNT { get; set; }
        public string INPUTCHANGEDATE { get; set; }
        public string INPUTDATE { get; set; }
        public int INPUTPRICE { get; set; }
        public string INVENTORYSTATUS { get; set; }
        public int ISADDINSTOCK { get; set; }
        public int ISCHECKREALINPUT { get; set; }
        public int ISRETURNPRODUCT { get; set; }
    }
}
