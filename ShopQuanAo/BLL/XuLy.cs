using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ShopQuanAo.DAL;
using ShopQuanAo.BLL;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace ShopQuanAo
{
    public class XuLy
    {
        QLShopDataContext data = new QLShopDataContext(ShopQuanAo.Properties.Settings.Default.connectionString);
        //SqlConnection cnn = new SqlConnection(ShopQuanAo.Properties.Settings.Default.connectionString);
        public bool ketnoiBD(string connec)
        {
            try
            {
                data = new QLShopDataContext(connec);
                data.Connection.Open();
                data.Connection.Close();
                Properties.Settings.Default.connectionString = connec;
                Properties.Settings.Default.Save();
                return true;
            }
            catch { return false; };
        }
        public NHANVIEN DangNhap(string _UseName, string _Pass)
        {
            NHANVIEN nv = data.NHANVIENs.FirstOrDefault(n => n.USERNAME == _UseName && n.PASS == _Pass);
            if (nv != null)
                return nv;
            else
                return null;
        }
        public bool ktChamCong(string _Manv, DateTime _ngaylam)
        {
           
                CT_NGAYLAM ct = data.CT_NGAYLAMs.FirstOrDefault(nl => nl.MANV == _Manv && nl.NGAYLAM == _ngaylam);
                if (ct == null)
                    return true;//thuc hien cham cong;
                else
                    return false;
                    //ct.MANV = _Manv;
                    //ct.NGAYLAM = _ngaylam;
                    //data.CT_NGAYLAMs.InsertOnSubmit(ct);
                    //data.SubmitChanges();
            
        }
        public bool ChamCong(string _Manv, DateTime _ngaylam)
        {
            try
            {
                CT_NGAYLAM ct = new CT_NGAYLAM();
                ct.MANV = _Manv;
                ct.NGAYLAM = _ngaylam;
                data.CT_NGAYLAMs.InsertOnSubmit(ct);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }

        }
        public CHUCVU Chucvu(string _MACV)
        {
            CHUCVU cv = data.CHUCVUs.FirstOrDefault(c => c.MACV == _MACV);
            return cv;
        }
        public  string CHuyetsothanhchu(int inputNumber, bool suffix = true)
        {
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            // -12345678.3445435 => "-12345678"
            string sNumber = inputNumber.ToString("#");
            double number = Convert.ToInt32(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }


            int ones, tens, hundreds;

            int positionDigit = sNumber.Length;   // last -> first

            string result = " ";


            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    // Check last 3 digits remain ### (hundreds tens ones)
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return result + (suffix ? " đồng chẵn" : "");
        }
        //San pham
        //+them san pham
        public bool ThemSP(string _mASP,string _TenSP,string _hinhAnh,string _mOTA,string _donGia, string _TrangThai,string _SoLuong,string _MaLoai)
        {
            try
            {
                SANPHAM sp = new SANPHAM();
                sp.MASP = _mASP;
                sp.TENSP = _TenSP;
                sp.HINHANH = _hinhAnh;
                sp.MOTA = _mOTA;
                sp.DONGIA = int.Parse(_donGia);
                sp.TRANGTHAI = _TrangThai;
                sp.SOLUONG = int.Parse(_SoLuong);
                sp.MALOAI = _MaLoai;
                data.SANPHAMs.InsertOnSubmit(sp);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        //cap nhat san pham
        public bool CapNhatSP(string _mASP, string _TenSP, string _hinhAnh, string _mOTA, string _donGia, string _TrangThai, string _SoLuong, string _MaLoai)
        {
            try
            {
                SANPHAM sp = data.SANPHAMs.FirstOrDefault(s=>s.MASP==_mASP);
                sp.TENSP = _TenSP;
                sp.HINHANH = _hinhAnh;
                sp.MOTA = _mOTA;
                sp.DONGIA = int.Parse(_donGia);
                sp.TRANGTHAI = _TrangThai;
                sp.SOLUONG = int.Parse(_SoLuong);
                sp.MALOAI = _MaLoai;
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
       //xoa san pham
        public bool XoaSP(string _mASP)
        {
            try
            {
                SANPHAM sp = data.SANPHAMs.FirstOrDefault(s => s.MASP == _mASP);
                if (sp != null)
                {
                    data.SANPHAMs.DeleteOnSubmit(sp);
                    data.SubmitChanges();
                    return true;
                }
                else
                    return false;
            }
            catch { return false; }
        }
       //lu hinh anh vao project
        public string LuuAnh( string pmasp, OpenFileDialog openFileDialog1,PictureBox ptx_HinhAnh)
        {
            string pHinhAnh;
            try
            {

                pHinhAnh = Path.GetFileName((openFileDialog1.FileName)).Trim();
                int d = pHinhAnh.Length;
                string duoi = pHinhAnh.Substring(d - 4);
                pHinhAnh = "H" + pmasp + duoi;
                int i = 0;
                while (System.IO.File.Exists(Application.StartupPath + "\\Resources\\" + pHinhAnh))
                {
                    pHinhAnh = "H" + pmasp + "_" + i + duoi;
                    i++;
                };
                switch (openFileDialog1.FilterIndex)
                {
                    case 1:
                        {
                            ptx_HinhAnh.Image.Save(Application.StartupPath + "\\Resources\\" + pHinhAnh, ImageFormat.Jpeg);
                        }
                        break;
                    case 2:
                        {
                            ptx_HinhAnh.Image.Save(Application.StartupPath + "\\Resources\\" + pHinhAnh, ImageFormat.Bmp);
                        }
                        break;
                    case 3:
                        {
                            ptx_HinhAnh.Image.Save(Application.StartupPath + "\\Resources\\" + pHinhAnh, ImageFormat.Gif);
                        }
                        break;
                    case 4:
                        {
                            ptx_HinhAnh.Image.Save(Application.StartupPath + "\\Resources\\" + pHinhAnh, ImageFormat.Png);
                        }
                        break;
                    default:
                        {
                            pHinhAnh = null;
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pHinhAnh = null;
            };
            return pHinhAnh;
        }
       //tao ma san pham moi
        public string Them_Ma_SP()
        {
            List<SANPHAM> lst = data.SANPHAMs.OrderByDescending(s => s.MASP).ToList();
            int Ma;
            if (lst.Count != 0)
                Ma = int.Parse(lst[0].MASP.Remove(0, 2));
            else
                Ma = 0;
            if (Ma + 1 < 10)
                return "SP00" + (Ma + 1);
            if (Ma + 1 < 100)
                return "SP0" + (Ma + 1);
            return "SP" + (Ma + 1);
        }
        // NHAN VIEN
        //tao ma nhan vien moi
        public string Them_Ma_NV()
        {
            List<NHANVIEN> lst = data.NHANVIENs.OrderByDescending(s => s.MANV).ToList();
            int Ma;
            if (lst.Count != 0)
                Ma = int.Parse(lst[0].MANV.Remove(0, 2));
            else
                Ma = 0;
            if (Ma + 1 < 10)
                return "NV00" + (Ma + 1);
            if (Ma + 1 < 100)
                return "NV0" + (Ma + 1);
            return "NV" + (Ma + 1);
        }
        //Them nhan vien moi
        public bool ThemNV(string _mANV, string _TenNV, string _hinhAnh, string _SDT, string _Gioitinh, string _useName, string _pass, string _MaCV)
        {
            try
            {
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = _mANV;
                nv.TENNV = _TenNV;
                nv.HINHANH = _hinhAnh;
                nv.SDT = _SDT;
                nv.GIOITINH = _Gioitinh;
                nv.USERNAME = _useName;
                nv.PASS = _pass;
                nv.CHUCVU = _MaCV;
                data.NHANVIENs.InsertOnSubmit(nv);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        //Cap nhat thoong tin nhan vien
        public bool CapNhatNV(string _mANV, string _TenNV, string _hinhAnh, string _SDT, string _Gioitinh, string _useName, string _pass, string _MaCV)
        {
            try
            {
                NHANVIEN nv = data.NHANVIENs.FirstOrDefault(n=>n.MANV==_mANV);
                nv.TENNV = _TenNV;
                nv.HINHANH = _hinhAnh;
                nv.SDT = _SDT;
                nv.GIOITINH = _Gioitinh;
                nv.USERNAME = _useName;
                nv.PASS = _pass;
                nv.CHUCVU = _MaCV;
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool XoaNV(string _mANV)
        {
            try
            {
                NHANVIEN nv = data.NHANVIENs.FirstOrDefault(n => n.MANV == _mANV);
                data.NHANVIENs.DeleteOnSubmit(nv);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public List<SANPHAM> dsSanPham_timkiem(string _tukhoa)
        {
            if (_tukhoa != "")
                return data.SANPHAMs.Where(sp => sp.MASP.Contains(_tukhoa) || sp.TENSP.Contains(_tukhoa)).ToList();
            return data.SANPHAMs.Where(sp => sp.MASP == _tukhoa).ToList();
        }
        //KhachHang
        //tao ma khach hang moi 
        public string Them_Ma_KH()
        {
            List<KHACHHANG> lst = data.KHACHHANGs.OrderByDescending(s => s.MAKH).ToList();
            int Ma;
            if (lst.Count != 0)
                Ma = int.Parse(lst[0].MAKH.Remove(0, 2));
            else
                Ma = 0;
            if (Ma + 1 < 10)
                return "KH00" + (Ma + 1);
            if (Ma + 1 < 100)
                return "KH0" + (Ma + 1);
            return "KH" + (Ma + 1);
        }
        //Them khach hang
        public bool ThemKH(string _mAKH, string _TenKH, string _SDT, string _Gioitinh, string _pass, string _daichi)
        {
            try
            {
                KHACHHANG kh = new KHACHHANG();
                kh.MAKH = _mAKH;
                kh.TENKH = _TenKH;
                kh.SDT = _SDT;
                kh.GIOITINH = _Gioitinh;
                kh.PASS = _pass;
                kh.DIACHI = _daichi;
                data.KHACHHANGs.InsertOnSubmit(kh);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public KHACHHANG timkhachhang(string _sdt)
        {
            return data.KHACHHANGs.FirstOrDefault(k => k.SDT == _sdt);
        }
        public string Them_Ma_HD()
        {
            List<HOADON> lst = data.HOADONs.OrderByDescending(s => s.MAHD).ToList();
            int Ma;
            if (lst.Count != 0)
                Ma = int.Parse(lst[0].MAHD.Remove(0, 2));
            else
                Ma = 0;
            if (Ma + 1 < 10)
                return "HD00" + (Ma + 1);
            if (Ma + 1 < 100)
                return "HD0" + (Ma + 1);
            return "HD" + (Ma + 1);
        }
        public bool LuuHD(string _maHD,string _maKH,string _maNV,DateTime _ngayBD,DateTime _ngayKT,string _giamgia,int _tongtien,string _trangthai,string _diachi,List<itemdonhang> _lst)
        {
            try
            {
                HOADON hd = new HOADON();
                hd.MAHD = _maHD;
                hd.MAKH = _maKH;
                hd.MANV = _maNV;
                hd.NGAYBD = _ngayBD;
                hd.NGAYKT = _ngayKT;
                hd.GIAMGIA = _giamgia;
                hd.TONGTIEN = _tongtien;
                hd.TRANGTHAI = _trangthai;
                hd.DIACHI = _diachi;
                data.HOADONs.InsertOnSubmit(hd);
                foreach (itemdonhang item in _lst)
                {
                    CT_HOADON ct = new CT_HOADON();
                    ct.MAHD = hd.MAHD;
                    ct.MASP = item.Masp;
                    ct.SOLUONG = item.soluong;
                    ct.DONGIA = item.dongia;
                    ct.GIAMGIA = null;
                    ct.THANHTIEN = item.thanhtien;
                    data.CT_HOADONs.InsertOnSubmit(ct);
                }
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool catnhatHD(string _maHD, string _maKH, string _maNV, DateTime _ngayBD, DateTime _ngayKT, string _giamgia, int _tongtien, string _trangthai, string _diachi, List<itemdonhang> _lst)
        {
            try
            {
                HOADON hd = data.HOADONs.FirstOrDefault(h => h.MAHD == _maHD);
                hd.MANV = _maNV;
                hd.NGAYBD = _ngayBD;
                hd.NGAYKT = _ngayKT;
                hd.GIAMGIA = _giamgia;
                hd.TONGTIEN = _tongtien;
                hd.TRANGTHAI = _trangthai;
                hd.DIACHI = _diachi;
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        //Lay Hoadoon theo ma
        public List<DAL.Hoadon_view> hoadontheoma(string ma)
        {
            List<DAL.Hoadon_view> a = data.Hoadon_views.Where(h => h.MAHD == ma).ToList();
            return a;
        }
        public List<CT_HOADON> dscthoadon(string _mashd)
        {
            return data.CT_HOADONs.Where(h => h.MAHD == _mashd).ToList();
        }
        //lay thong tin 
        //nhan vien theo ma
        public NHANVIEN layNhanVIen(string _maNV)
        {
            return data.NHANVIENs.FirstOrDefault(n => n.MANV == _maNV);
        }
        //khach hang
        public KHACHHANG layKHACHHANG(string _maKH)
        {
            return data.KHACHHANGs.FirstOrDefault(n => n.MAKH == _maKH);
        }
        //san pham
        public SANPHAM laySANPHAM(string _maSP)
        {
            return data.SANPHAMs.FirstOrDefault(n => n.MASP == _maSP);
        }
        public int tongdoanhthu(DateTime date,int chonloc)
        {
            try
            {
                if (chonloc == -1)
                    return data.HOADONs.Sum(s => s.TONGTIEN).Value;
                if (chonloc == 0)
                    return data.HOADONs.Sum(s => s.TONGTIEN).Value;
                if (chonloc == 1)
                    return data.HOADONs.Where(h => h.NGAYBD == date).Sum(s => s.TONGTIEN).Value;
                return data.HOADONs.Where(h => h.NGAYBD.Value.Month == date.Month && h.NGAYBD.Value.Year == date.Year).Sum(s => s.TONGTIEN).Value;
            }
            catch { return 0; }

        }
        public string sanphambanchaynhat(DateTime date, int chonloc)
        {
            
            try
            {
                var masp=
                from hd in data.HOADONs
                join ct in data.CT_HOADONs on hd.MAHD equals ct.MAHD
                select new { ct.MASP, ct.SOLUONG };
                if (chonloc == -1)
                    masp = from hd in data.HOADONs
                           join ct in data.CT_HOADONs on hd.MAHD equals ct.MAHD
                           select new { ct.MASP, ct.SOLUONG };
                else
                {
                    if (chonloc == 0)
                        masp = from hd in data.HOADONs
                               join ct in data.CT_HOADONs on hd.MAHD equals ct.MAHD
                               
                               select new { ct.MASP, ct.SOLUONG };
                    else
                    {
                        if (chonloc == 1)
                            masp = from hd in data.HOADONs
                                   join ct in data.CT_HOADONs on hd.MAHD equals ct.MAHD
                                   where hd.NGAYBD == date
                                   
                                   select new { ct.MASP, ct.SOLUONG };
                        else
                        {
                            if (chonloc == 2)
                                masp = from hd in data.HOADONs
                                       join ct in data.CT_HOADONs on hd.MAHD equals ct.MAHD
                                       where hd.NGAYBD.Value.Month == date.Month && hd.NGAYBD.Value.Year == date.Year
                                       select new { ct.MASP, ct.SOLUONG };
                        }
                    }
                }
                var a = masp.GroupBy(s => s.MASP).OrderByDescending(p => p.Sum(t => t.SOLUONG)).Take(1).ToList();
                return a[0].Key.ToString();
            }
            catch { return ""; }
            
        }
        public string khachhangmuanhieunhat(DateTime date, int chonloc)
        {

            try
            {
                var masp =
                from hd in data.HOADONs
                join ct in data.CT_HOADONs on hd.MAHD equals ct.MAHD
                select new { hd.MAKH, ct.SOLUONG };
                if (chonloc == -1)
                    masp = from hd in data.HOADONs
                           join ct in data.CT_HOADONs on hd.MAHD equals ct.MAHD
                           select new { hd.MAKH, ct.SOLUONG };
                else
                {
                    if (chonloc == 0)
                        masp = from hd in data.HOADONs
                               join ct in data.CT_HOADONs on hd.MAHD equals ct.MAHD
                               
                               select new { hd.MAKH, ct.SOLUONG };
                    else
                    {
                        if (chonloc == 1)
                            masp = from hd in data.HOADONs
                                   join ct in data.CT_HOADONs on hd.MAHD equals ct.MAHD
                                   where hd.NGAYBD == date
                                   
                                   select new { hd.MAKH, ct.SOLUONG };
                        else
                        {
                            if (chonloc == 2)
                                masp = from hd in data.HOADONs
                                       join ct in data.CT_HOADONs on hd.MAHD equals ct.MAHD
                                       where hd.NGAYBD.Value.Month == date.Month && hd.NGAYBD.Value.Year == date.Year
                                       select new { hd.MAKH, ct.SOLUONG };
                        }
                    }
                }
                var a = masp.GroupBy(s => s.MAKH).OrderByDescending(p => p.Sum(t => t.SOLUONG)).ToList();
                return a[0].Key.ToString();
            }
            catch { return ""; }

        }
        public string nhanviendoanhthucao(DateTime date, int chonloc)
        {

            try
            {
                var masp =
                from hd in data.HOADONs
                join ct in data.CT_HOADONs on hd.MAHD equals ct.MAHD
                select new { hd.MANV, ct.SOLUONG };
                if (chonloc == -1)
                    masp = from hd in data.HOADONs
                           join ct in data.CT_HOADONs on hd.MAHD equals ct.MAHD
                           select new { hd.MANV, ct.SOLUONG };
                else
                {
                    if (chonloc == 0)
                        masp = from hd in data.HOADONs
                               join ct in data.CT_HOADONs on hd.MAHD equals ct.MAHD
                               
                               select new { hd.MANV, ct.SOLUONG };
                    else
                    {
                        if (chonloc == 1)
                            masp = from hd in data.HOADONs
                                   join ct in data.CT_HOADONs on hd.MAHD equals ct.MAHD
                                   where hd.NGAYBD == date
                                   
                                   select new { hd.MANV, ct.SOLUONG };
                        else
                        {
                            if (chonloc == 2)
                                masp = from hd in data.HOADONs
                                       join ct in data.CT_HOADONs on hd.MAHD equals ct.MAHD
                                       where hd.NGAYBD.Value.Month == date.Month && hd.NGAYBD.Value.Year == date.Year
                                       select new { hd.MANV, ct.SOLUONG };
                        }
                    }
                }
                var a = masp.GroupBy(s => s.MANV).OrderByDescending(p => p.Sum(t => t.SOLUONG)).Take(1).ToList();
                return a[0].Key.ToString();
            }
            catch { return ""; }

        }
        //Them KHACH HANG
        public bool themKH(string _maKH, string _tenKH,string _SDt, string _diaChi,string _gioitinh,string _Pass)
        {
            try
            {
                KHACHHANG kh = new KHACHHANG();
                kh.MAKH = _maKH;
                kh.TENKH = _tenKH;
                kh.SDT = _SDt;
                kh.DIACHI = _diaChi;
                kh.GIOITINH = _gioitinh;
                kh.PASS = _Pass;
                data.KHACHHANGs.InsertOnSubmit(kh);
                data.SubmitChanges();
                return true;
            }catch { return false; }
        }
        //Cat nhat thong tin Khach hang
        public bool CapNhatKH(string _maKH, string _tenKH, string _SDt, string _diaChi, string _gioitinh, string _Pass)
        {
            try
            {
                KHACHHANG kh = data.KHACHHANGs.FirstOrDefault(k => k.MAKH == _maKH);
                if (kh != null)
                {
                    kh.TENKH = _tenKH;
                    kh.SDT = _SDt;
                    kh.DIACHI = _diaChi;
                    kh.GIOITINH = _gioitinh;
                    kh.PASS = _Pass;
                    data.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch { return false; }
        }
        //Xoa KHACH HANG
        public bool XoaKh(string _maKH)
        {
            try
            {
                KHACHHANG kh = data.KHACHHANGs.FirstOrDefault(k => k.MAKH == _maKH);
                if (kh != null)
                {
                    data.KHACHHANGs.DeleteOnSubmit(kh);
                    data.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch { return false; }
        }
        // PHIeu Nhap
        //Tao ma phieu nhap
        public string Them_Ma_PN()
        {
            List<NHAPHANG> lst = data.NHAPHANGs.OrderByDescending(s => s.MANHAP).ToList();
            int Ma;
            if (lst.Count != 0)
                Ma = int.Parse(lst[0].MANHAP.Remove(0, 2));
            else
                Ma = 0;
            if (Ma + 1 < 10)
                return "PN00" + (Ma + 1);
            if (Ma + 1 < 100)
                return "PN0" + (Ma + 1);
            return "PN" + (Ma + 1);
        }
        public bool LuuPN(string _maNhap, DateTime _ngayNHAP, int _tongtien, List<itemdonhang> _lst)
        {
            try
            {
                NHAPHANG nh = new NHAPHANG();
                nh.MANHAP = _maNhap;
                nh.NGAYNHAP = _ngayNHAP;
                nh.TONGTIEN = _tongtien;
                data.NHAPHANGs.InsertOnSubmit(nh);
                foreach (itemdonhang item in _lst)
                {
                    CT_NHAPHANG ct = new CT_NHAPHANG();
                    ct.MANHAP = nh.MANHAP;
                    ct.MASP = item.Masp;
                    ct.SOLUONG = item.soluong;
                    ct.DONGIA = item.dongia;
                    ct.THANHTIEN = item.thanhtien;
                    data.CT_NHAPHANGs.InsertOnSubmit(ct);
                }
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        //Tim Phieu Nhaapj
       
    }
}
