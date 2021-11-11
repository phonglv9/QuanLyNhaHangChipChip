﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS.iBUSServices;
using _1_DAL.Models;
using _1_DAL.DALServices;
using _1_DAL.iDALServices;
using _2_BUS.Models;

namespace _2_BUS.BUSServices
{
    public class QLHoaDon : IQLHoaDon
    {
        IHoaDonChiTietService _HDCT;
        iHoaDonService _HD;
        List<ViewHoaDon> _lstViewHD;
        public QLHoaDon()
        {
            _HD = new HoaDonService();
            _HDCT = new HoaDonChiTietService();
        }
        public string AddHoaDon(HoaDon HoaDon)
        {
            return _HD.AddHoaDon(HoaDon);
        }        

        public string AddHoaDonCT(HoaDonChiTiet HoaDon)
        {
            return _HDCT.AddHoaDon(HoaDon);
        }

        public string DeleteHoaDon(HoaDon HoaDon)
        {
            return _HD.DeleteHoaDon(HoaDon);
        }        

        public string DeleteHoaDonCT(HoaDonChiTiet HoaDon)
        {
            return _HDCT.DeleteHoaDon(HoaDon);
        }

        public List<HoaDon> GetBillsFromDB()
        {
            return _HD.GetBillsFromDB();
        }

        public List<HoaDonChiTiet> GetHoaDonCTFromDB()
        {
            return _HDCT.GetHoaDonCTFromDB();
        }

        public List<ViewHoaDon> GetListDSHoaDon()
        {
            return _lstViewHD = (from a in _HD.GetBillsFromDB()
                                 join b in _HDCT.GetHoaDonCTFromDB()
                                 on a.Id equals b.Idbill
                                 select new ViewHoaDon() 
                                 {

                                 }).ToList();
        }

        public string SaveHoaDon()
        {
            return _HD.SaveHoaDon();
        }

        public string SaveHoaDonChiTiet()
        {
            return _HDCT.SaveHoaDon();
        }

        public string UpdateHoaDon(HoaDon HoaDon)
        {
            return _HD.UpdateHoaDon(HoaDon);
        }        

        public string UpdateHoaDonCT(HoaDonChiTiet HoaDon)
        {
            return _HDCT.UpdateHoaDon(HoaDon);
        }
    }
}
