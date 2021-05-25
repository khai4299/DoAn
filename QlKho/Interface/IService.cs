using QlKho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Interface
{
    public interface IService
    {
        IEnumerable<PM_STORE> GetAllStore();
        void TaoPhieuNhap(PM_INPUTORDER pi);
        void TaoPhieuNhap_NoSubmit(PM_INPUTORDER pi);
        void TaoPhieuNhap_Temp(TaoPhieuNhap_Temp tpnt, TaoPhieuNhap tpn);
        IEnumerable<SP_TaoPhieuNhap> GetAllThemSanPham (List<SP_TaoPhieuNhap> list, SP_TaoPhieuNhap t);

        void TaoPhieuXuat(PM_OUTPUTVOUCHER po);

        IEnumerable<PM_INPUTORDER> TraCuuPhieuNhap(TraCuuPhieuNhap traCuuPhieuNhap);
        IEnumerable<PM_OUTPUTVOUCHER> TraCuuPhieuXuat(TraCuuPhieuXuat traCuuPhieuXuat);
        IEnumerable<PM_INPUTORDER> GetAllPM_INPUTORDER();
    }
}
