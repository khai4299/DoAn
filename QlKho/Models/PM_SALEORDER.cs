using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_SALEORDER
    {
        public string SALEORDERID { get; set; }
        public string BIRTHDAY { get; set; }
        public string CONTACTGENDER { get; set; }
        public int CONTACTIDCARD { get; set; }
        public int CONTACTPHONE { get; set; }
        public string CREATEDATE { get; set; }
        public string DELIVERYADDRESS { get; set; }
        public string DELIVERYTIME { get; set; }
        public int DELIVERYUSER { get; set; }
        public int INPUTUSER { get; set; }
        public int ISDELIVERY { get; set; }
        public int ISINCOME { get; set; }
        public int ISOUTPRODUCT { get; set; }
        public int ISREVIEWED { get; set; }
        public int ORIGINATESTOREID { get; set; }
        public string OUTPRODUCTDATE { get; set; }
        public int OUTPUTSTOREID { get; set; }
        public int OUTPUTUSER { get; set; }
        public string PAYABLETYPEID { get; set; }
        public int STAFFUSER { get; set; }
        public int TOTALAMOUNT { get; set; }
        public int TOTALPAID { get; set; }
        public int TOTALQUANTITY { get; set; }
        public string VOUCHERCONCERN { get; set; }
    }
}
