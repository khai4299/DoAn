    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class PM_STORE
    {
        public int STOREID { get; set; }
        public int STOREMANAGER { get; set; }
        public string STORENAME { get; set; }
        public int STOREPHONENUM { get; set; }
        public string STORESHORTNAME { get; set; }
        public string CREATEDDATE { get; set; }
        public string STOREADDRESS { get; set; }
        public string STORETYPE { get; set; }
        public int ISACTIVE { get; set; }
        public int ISDELETED { get; set; }
        public int ISINPUTSTORE { get; set; }
    }
}
