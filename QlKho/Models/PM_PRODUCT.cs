using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_PRODUCT
    {
        public int PRODUCTID { get; set; }
        public int SUBGROUPID { get; set; }
        public string PRODUCTNAME { get; set; }
        public int IMEI { get; set; }
        public int MINSTORE { get; set; }
        public int OUTOFSTOCKWARNINGQUANTITY { get; set; }
        public int PRODUCTCOLORID { get; set; }
        public float PRODUCTLENGTH { get; set; }
        public float PRODUCTSIZE { get; set; }
        public int PRODUCTTYPEID { get; set; }
        public float PRODUCTWEIGHT { get; set; }
        public int SIZETYPE { get; set; }
        public string STATUSID { get; set; }
        public float VATIN { get; set; }
    }
}
