using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Models
{
    public class TraCuuPhieuXuat
    {
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]

        public IEnumerable<PM_STORE> pS { get; set; }
        public IEnumerable<PM_OUTPUTVOUCHER> po { get; set; }
        public string TuKhoa { get; set; }
        public string Kho { get; set; }
        [DataType(DataType.Date)]
        public DateTime TuNgay { get; set; }
        [DataType(DataType.Date)]
        public DateTime DenNgay { get; set; }
        public string HinhThucXuat { get; set; }
    }
}
