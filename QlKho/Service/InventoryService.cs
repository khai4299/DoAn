using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using QlKho.Interface;
using QlKho.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QlKho.Service
{
    public class InventoryService : IService
    {
        private readonly string _connectString;
  

        public InventoryService(IConfiguration _configuration)
        {
            _connectString = _configuration.GetConnectionString("OracleDBConnection");
        }

        public IEnumerable<PM_STORE> GetAllStore()
        {
            List<PM_STORE> stoList = new List<PM_STORE>();
            using (OracleConnection con = new OracleConnection(_connectString))
            {
                string queryString = "Select STOREID from PM_STORE";
                OracleCommand command = new OracleCommand(queryString, con);
                    con.Open();
                OracleDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        PM_STORE store = new PM_STORE
                        {
                            STOREID = Convert.ToInt32(reader["STOREID"]),
                        };
                        stoList.Add(store);
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
            return stoList;
        }
        public IEnumerable<PM_INPUTORDER> GetAllPM_INPUTORDER()
        {
            List<PM_INPUTORDER> stoList = new List<PM_INPUTORDER>();
            using (OracleConnection con = new OracleConnection(_connectString))
            {
                string queryString = "Select * from PM_INPUTORDER";
                OracleCommand command = new OracleCommand(queryString, con);
                con.Open();
                OracleDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        PM_INPUTORDER store = new PM_INPUTORDER();
                        stoList.Add(store);
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
            return stoList;
        }
        public void TaoPhieuNhap(PM_INPUTORDER pi)
        {
            System.Diagnostics.Debug.WriteLine("Log" + pi.AUTOSTORECHANGETOSTOREID);
            try
            {
                using (OracleConnection con = new OracleConnection(_connectString))
                {
                    string queryString = "Insert into PM_INPUTORDER(INPUTVOUCHERID,AUTOSTORECHANGETOSTOREID,CUSTOMERNAME,CUSTOMERADDRESS,CUSTOMERPHONE,TAXID,CHECKREALINPUTNOTE) values" +
                        "('" + pi.INPUTVOUCHERID + "','" + pi.AUTOSTORECHANGETOSTOREID + "','" + pi.CUSTOMERNAME + "','" +
                        pi.CUSTOMERADDRESS + "','" + pi.CUSTOMERPHONE + "','" + pi.TAXID + "','" + pi.CHECKREALINPUTNOTE + "') ";
                    //string queryString = "Insert into PM_INPUTORDER(INPUTVOUCHERID) VALUES ('+"+pi.INPUTVOUCHERID.ToString()+"+')";
                    OracleCommand command = new OracleCommand(queryString, con);
                    con.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void TaoPhieuNhap_NoSubmit(PM_INPUTORDER pi)
        {
            System.Diagnostics.Debug.WriteLine("Log" + pi.AUTOSTORECHANGETOSTOREID);
            try
            {
                using (OracleConnection con = new OracleConnection(_connectString))
                {
                    string queryString = "Insert into PM_INPUTORDER(INPUTVOUCHERID,AUTOSTORECHANGETOSTOREID,CUSTOMERNAME,CUSTOMERADDRESS,CUSTOMERPHONE,TAXID,CHECKREALINPUTNOTE) values" +
                        "('" + pi.INPUTVOUCHERID + "','" + pi.AUTOSTORECHANGETOSTOREID + "','" + pi.CUSTOMERNAME + "','" +
                        pi.CUSTOMERADDRESS + "','" + pi.CUSTOMERPHONE + "','" + pi.TAXID + "','" + pi.CHECKREALINPUTNOTE + "') ";
                    //string queryString = "Insert into PM_INPUTORDER(INPUTVOUCHERID) VALUES ('+"+pi.INPUTVOUCHERID.ToString()+"+')";
                    OracleCommand command = new OracleCommand(queryString, con);
                    con.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        public IEnumerable<PM_INPUTORDER> TraCuuPhieuNhap(TraCuuPhieuNhap traCuuPhieuNhap)
        {
            Debug.WriteLine("Log" + traCuuPhieuNhap.TuKhoa);
            List<PM_INPUTORDER> stoList = new List<PM_INPUTORDER>();
            using (OracleConnection con = new OracleConnection(_connectString))
            {
                string queryString = "Select * from PM_INPUTORDER where INPUTVOUCHERID like '%" + traCuuPhieuNhap.TuKhoa +
                    "%' and AUTOSTORECHANGETOSTOREID like '%" + traCuuPhieuNhap.Kho + "%'" +
                " and INPUTDATE BETWEEN TO_DATE ('" + traCuuPhieuNhap.TuNgay.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY')" +
                "AND TO_DATE('" + traCuuPhieuNhap.DenNgay.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY')" +
                "and PAYABLETYPE like '%" + traCuuPhieuNhap.HinhThucNhap + "%' and PROCESSSTATUS like '%" + traCuuPhieuNhap.TrangThaiNhap + "%'";
                Debug.WriteLine("Log" + queryString);
                OracleCommand command = new OracleCommand(queryString, con);
                con.Open();
                OracleDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        PM_INPUTORDER store = new PM_INPUTORDER()
                        {
                            INPUTVOUCHERID = reader["INPUTVOUCHERID"].ToString(),
                            AUTOSTORECHANGETOSTOREID = Convert.ToInt32(reader["AUTOSTORECHANGETOSTOREID"]),
                            INPUTDATE = reader["INPUTDATE"].ToString(),
                            CUSTOMERNAME = reader["CUSTOMERNAME"].ToString(),
                            TOTALAMOUNTBF = Convert.ToInt32(reader["TOTALAMOUNTBF"]),
                            PROCESSSTATUS = Convert.ToInt32(reader["PROCESSSTATUS"])
                        };
                        Debug.WriteLine("Log" + stoList.Count());
                        stoList.Add(store);
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            return stoList;


        }
        public IEnumerable<PM_OUTPUTVOUCHER> TraCuuPhieuXuat(TraCuuPhieuXuat traCuuPhieuXuat)
        {
            Debug.WriteLine("Log" + traCuuPhieuXuat.TuKhoa);
            List<PM_OUTPUTVOUCHER> stoList = new List<PM_OUTPUTVOUCHER>();
            using (OracleConnection con = new OracleConnection(_connectString))
            {
                string queryString = "Select * from PM_OUTPUTVOUCHER where OUTPUTVOUCHERID like '%" + traCuuPhieuXuat.TuKhoa +
                    "%' and STOREID like '%" + traCuuPhieuXuat.Kho + "%'" +
                " and OUTPUTDATE BETWEEN TO_DATE ('" + traCuuPhieuXuat.TuNgay.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY')" +
                "AND TO_DATE('" + traCuuPhieuXuat.DenNgay.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY')" +
                "and PAYABLETYPE like '%" + traCuuPhieuXuat.HinhThucXuat + "%'";
                Debug.WriteLine("Log" + queryString);
                OracleCommand command = new OracleCommand(queryString, con);
                con.Open();
                OracleDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        PM_OUTPUTVOUCHER store = new PM_OUTPUTVOUCHER()
                        {
                            OUTPUTVOUCHERID = reader["OUTPUTVOUCHERID"].ToString(),
                            ORIGINATESTOREID = Convert.ToInt32(reader["ORIGINATESTOREID"]),
                            OUTPUTDATE = reader["OUTPUTDATE"].ToString(),
                            CUSTOMERNAME = reader["CUSTOMERNAME"].ToString()
                            //TOTALAMOUNTBF = Convert.ToInt32(reader["TOTALAMOUNTBF"]),
                            //PROCESSSTATUS = Convert.ToInt32(reader["PROCESSSTATUS"])
                        };
                        Debug.WriteLine("Log" + stoList.Count());
                        stoList.Add(store);
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            return stoList;
        }

        public void TaoPhieuXuat(PM_OUTPUTVOUCHER po)
        {
            System.Diagnostics.Debug.WriteLine("Log" + po.OUTPUTVOUCHERID);
            try
            {
                using (OracleConnection con = new OracleConnection(_connectString))
                {
                    string queryString = "Insert into PM_OUTPUTVOUCHER(OUTPUTVOUCHERID,STOREID,CUSTOMERNAME,CUSTOMERADDRESS,CUSTOMERPHONE) values" +
                        "('" + po.OUTPUTVOUCHERID + "','" + po.STOREID + "','" + po.CUSTOMERNAME + "','" +
                        po.CUSTOMERADDRESS + "','" + po.CUSTOMERPHONE + "')";
                    //string queryString = "Insert into PM_INPUTORDER(INPUTVOUCHERID) VALUES ('+"+pi.INPUTVOUCHERID.ToString()+"+')";
                    OracleCommand command = new OracleCommand(queryString, con);
                    con.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<SP_TaoPhieuNhap> GetAllThemSanPham(List<SP_TaoPhieuNhap> list, SP_TaoPhieuNhap t)
        {
            list.Add(t);
            return list;
        }
        public void TaoPhieuNhap_Temp(TaoPhieuNhap_Temp tpnt, TaoPhieuNhap tpn)
        {
            tpnt.maphieu = tpn.pi.INPUTVOUCHERID;
        }
    }
}
