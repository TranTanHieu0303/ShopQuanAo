using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopQuanAo.DAL;
namespace ShopQuanAo.BLL
{
    public class itemdonhang
    {
        public string Masp { get; set; }
        public string tensp { get; set; }
        public int soluong { get; set; }
        public int dongia { get; set; }
        public int thanhtien {
            
            get { return soluong * dongia; } 
        }
        QLShopDataContext data = new QLShopDataContext();
        public itemdonhang(string ms)
        {
            SANPHAM sp = data.SANPHAMs.FirstOrDefault(s => s.MASP == ms);
            if(sp!=null)
            {
                Masp = sp.MASP;
                tensp = sp.TENSP;
                dongia = (int)sp.DONGIA;
                soluong = 1;
            }
        }
        public itemdonhang(string ms,int sl)
        {
            SANPHAM sp = data.SANPHAMs.FirstOrDefault(s => s.MASP == ms);
            if (sp != null)
            {
                Masp = sp.MASP;
                tensp = sp.TENSP;
                dongia = (int)sp.DONGIA;
                soluong = sl;
            }
        }
        public itemdonhang(string ms, int sl,int _gianhap)
        {
            SANPHAM sp = data.SANPHAMs.FirstOrDefault(s => s.MASP == ms);
            if (sp != null)
            {
                Masp = sp.MASP;
                tensp = sp.TENSP;
                dongia = _gianhap;
                soluong = sl;
            }
        }


    }
}
