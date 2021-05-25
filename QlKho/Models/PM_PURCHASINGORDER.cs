using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_PURCHASINGORDER
    {
        public int POID { get; set; }
        public string CREATEDATE { get; set; }
        public int STOREID { get; set; }
        public string SUPPLIERID { get; set; }
        public string DELIVERID { get; set; }
        public int EMPLOYEE_PO { get; set; }
    }
}
