using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class TaoPhieuNhap
    {
        public PM_INPUTORDER pi { get; set; }
        public PM_PRODUCT pR { get; set; }
        public IEnumerable<PM_STORE> pS { get; set; }
        public IEnumerable<SP_TaoPhieuNhap> ispt { get; set; }
        public SP_TaoPhieuNhap spt { get; set; }
        public TaoPhieuNhap_Temp tpnt { get; set; }
    }
}
