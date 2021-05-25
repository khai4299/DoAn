using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class TaoPhieuXuat
    {
        public PM_OUTPUTVOUCHER po { get; set; }
        public PM_PRODUCT pR { get; set; }
        public IEnumerable<PM_STORE> pS { get; set; }
    }
}
