using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_INPUTORDER
    {
        public string INPUTVOUCHERID { get; set; }
        public int AUTOSTORECHANGETOSTOREID { get; set; }
        public string CHECKREALINPUTNOTE { get; set; }
        public string CHECKREALINPUTTIME { get; set; }
        public int CHECKREALINPUTUSER { get; set; }
        public int CONFIRMUSER { get; set; }
        public string CUSTOMERADDRESS { get; set; }
        public int CUSTOMERID { get; set; }
        public string CUSTOMERNAME { get; set; }
        public int CUSTOMERPHONE { get; set; }
        public int DISCOUNT { get; set; }
        public string DISCOUNTREASONID { get; set; }
        public string INPUTCONTENT { get; set; }
        public string INPUTDATE { get; set; }
        public string INPUTTYPE { get; set; }
        public string INVOICEDATE { get; set; }
        public string INVOICESYMBOL { get; set; }
        public int ISCHECKREALINPUT { get; set; }
        public int ISCONFIRM { get; set; }
        public int ISSTORECHANGE { get; set; }
        public string ORDERID { get; set; }
        public int ORIGINATESTOREID { get; set; }
        public string PAYABLETIME { get; set; }
        public string PAYABLETYPE { get; set; }
        public string PROCESSNOTE { get; set; }
        public int PROCESSSTATUS { get; set; }
        public int PROCESSUSER { get; set; }
        public int REVIEWUSER { get; set; }
        public int STAFFUSER { get; set; }
        public int STOREID { get; set; }
        public int TAXID { get; set; }
        public float VAT { get; set; }
        public int TOTALAMOUNT { get; set; }
        public int TOTALAMOUNTBF { get; set; }
    }
}
