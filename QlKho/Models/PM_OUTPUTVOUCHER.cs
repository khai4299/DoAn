using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_OUTPUTVOUCHER
    {
        public string OUTPUTVOUCHERID { get; set; }
        public string ORDERID { get; set; }
        public string CUSTOMERADDRESS { get; set; }
        public string CUSTOMERNAME { get; set; }
        public int CUSTOMERPHONE { get; set; }
        public int ISERROR { get; set; }
        public int ISSTORECHANGE { get; set; }
        public int ORIGINATESTOREID { get; set; }
        public string OUTPUTCONTENT { get; set; }
        public string OUTPUTDATE { get; set; }
        public string PAYABLETIM { get; set; }
        public string PAYABLETYPE { get; set; }
        public int STAFFUSER { get; set; }
        public int STOREID { get; set; }
        public int USERNAME { get; set; }
    }
}
