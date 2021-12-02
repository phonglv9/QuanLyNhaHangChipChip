﻿using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.BUSServices;
using _2_BUS.iBUSServices;
using _1_DAL.Models;
using _2_BUS.Models;
using System.Drawing;
using _3_GUI.Properties;

namespace _3_GUI
{
    public partial class FrmChuyenBan : Form
    {
        public event Action reloadBan;
        private FrmQLBan _FrmQLBan;
        public static int _IdBanCu;
        IQLBanAnService _qlBanAn;
        IQLHoaDon _qlHoaDon;
        iQLMenuService _qlMeniu;
        int _IdBan;
        HoaDon _hoaDon;
        BanAn _banAn;
        FrmMain frm;
        public FrmChuyenBan(FrmQLBan alo)
        {
            InitializeComponent();
            _qlBanAn = new QLBanAnService();
            _qlHoaDon = new QLHoaDon();
            _qlMeniu = new QLMenuService();
            _FrmQLBan = alo;
            LoadTableT1();
            LoadTableT2();

        }
        void LoadTableT2()
        {
            FlPanel2.Controls.Clear();
            foreach (BanAn x in _qlBanAn.GetTablesFromDB().Where(c => c.Floor == 2))
            {
                Button btn = new Button() { Width = x.Rong, Height = x.Cao };
                btn.Text = x.Name + Environment.NewLine + (x.TinhTrang == 1 ? "Trống" : "Có người");
                btn.Click += Btn_Click;
                btn.Tag = x;
                switch (x.TinhTrang)
                {
                    case 1:
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                FlPanel2.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as BanAn).Id;
            _IdBan = id;
            _banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _IdBanCu);
            BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == id);
            _hoaDon = _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == _IdBanCu && c.Status == true && c.DichVu == 1).FirstOrDefault();
            if (banAn.TinhTrang == 1)
            {
                if (_IdBanCu == id)
                {
                    MessageBox.Show("Vị trí bàn trùng nhau", "Thông báo");
                    return;
                }
                _hoaDon.Idtable = _IdBan;
                _qlHoaDon.UpdateHoaDon(_hoaDon);
                _banAn.TinhTrang = 1;
                _qlBanAn.UpdateBanAn(_banAn);                
                banAn.TinhTrang = 0;
                _qlBanAn.UpdateBanAn(banAn);
                reloadBan();                              
                this.Close();                
            }
            else if (banAn.TinhTrang == 0)
            {
                if (_IdBanCu == id)
                {
                    MessageBox.Show("Vị trí bàn trùng nhau", "Thông báo");
                    return;
                }
                HoaDon hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c => c.Idtable == _IdBan && c.Status == true && c.DichVu == 1);
                _hoaDon.TotalMoney = 0;
                _hoaDon.Status = false;
                _qlHoaDon.UpdateHoaDon(_hoaDon);
                List<HoaDonChiTiet> lstHDCT = _qlHoaDon.GetHoaDonCTFromDB().Where(c => c.Idbill == _hoaDon.Id).ToList();
                foreach (var x in lstHDCT)
                {
                    x.Idbill = hoaDon.Id;
                    _qlHoaDon.UpdateHoaDonCT(x);
                    hoaDon.TotalMoney += x.Price;
                }
                _qlHoaDon.UpdateHoaDon(hoaDon);
                _banAn.TinhTrang = 1;
                _qlBanAn.UpdateBanAn(_banAn);
                reloadBan();
                this.Close();
            }
        }

        void LoadTableT1()
        {
            FLPenal.Controls.Clear();
            foreach (BanAn x in _qlBanAn.GetTablesFromDB().Where(c => c.Floor == 1))
            {
                Button btn1 = new Button() { Width = x.Rong, Height = x.Cao };
                //Bitmap b = new Bitmap(@"C:\Users\XAPE\Desktop\TestGit-master\RestaurantApp\Resources\caiBan.png");                
                //btn.Image= b;
                btn1.Text = x.Name + Environment.NewLine + (x.TinhTrang == 1 ? "Trống" : "Có người");
                btn1.Click += Btn1_Click;
                btn1.Tag = x;
                switch (x.TinhTrang)
                {
                    case 1:
                        btn1.BackColor = Color.Aqua;
                        break;
                    default:
                        btn1.BackColor = Color.LightPink;
                        break;
                }
                FLPenal.Controls.Add(btn1);

            }
            //â
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as BanAn).Id;
            _IdBan = id;
            _banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == _IdBanCu);
            BanAn banAn = _qlBanAn.GetTablesFromDB().FirstOrDefault(c => c.Id == id);
            _hoaDon = _qlHoaDon.GetBillsFromDB().Where(c => c.Idtable == _IdBanCu && c.Status == true && c.DichVu == 1).FirstOrDefault();
            if (banAn.TinhTrang==1)
            {
                if (_IdBanCu==id)
                {
                    MessageBox.Show("Vị trí bàn trùng nhau","Thông báo");
                    return;
                }                
                _hoaDon.Idtable = _IdBan;
                _qlHoaDon.UpdateHoaDon(_hoaDon);
                _banAn.TinhTrang = 1;
                _qlBanAn.UpdateBanAn(_banAn);                
                banAn.TinhTrang = 0;
                _qlBanAn.UpdateBanAn(banAn);
                _FrmQLBan.LoadTableT1();
                reloadBan();
                this.Close();
                

            }
            else if (banAn.TinhTrang==0)
            {
                if (_IdBanCu == id)
                {
                    MessageBox.Show("Vị trí bàn trùng nhau", "Thông báo");
                    return;
                }
                HoaDon hoaDon = _qlHoaDon.GetBillsFromDB().FirstOrDefault(c=>c.Idtable==_IdBan && c.Status==true && c.DichVu==1);
                _hoaDon.TotalMoney = 0;
                _hoaDon.Status = false;
                _qlHoaDon.UpdateHoaDon(_hoaDon);
                List<HoaDonChiTiet> lstHDCT = _qlHoaDon.GetHoaDonCTFromDB().Where(c=>c.Idbill==_hoaDon.Id).ToList();
                foreach (var x in lstHDCT)
                {
                    x.Idbill = hoaDon.Id;
                    _qlHoaDon.UpdateHoaDonCT(x);
                    hoaDon.TotalMoney += x.Price;
                }
                _qlHoaDon.UpdateHoaDon(hoaDon);
                _banAn.TinhTrang = 1;
                _qlBanAn.UpdateBanAn(_banAn);
                reloadBan();
                this.Close();
                
            }
        }

        private void FrmChuyenBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            _FrmQLBan.LoadTableT1();
            _FrmQLBan.LoadTableT2();
            _FrmQLBan.Refresh();
        }
        public void getFrmMain(FrmMain forme)
        {
            frm = forme;
        }
    }
}