using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopQuanAo.DAL;
using ShopQuanAo.GUI;
using ShopQuanAo.BLL;
namespace ShopQuanAo
{
    public partial class HoaDon : Form
    {
        public NHANVIEN _nv;
        KHACHHANG _kh;
        XuLy xl = new XuLy();
        DonHang don = new DonHang();
        List<SANPHAM> lst;
        string maspchon;
        UserControl_sanpham usersp;
        public HoaDon()
        {
            InitializeComponent();
        }

        

        private void HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.dataSet1.SANPHAM);
            // TODO: This line of code loads data into the 'dataSet1.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.dataSet1.SANPHAM);
            // TODO: This line of code loads data into the 'dataSet1.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.dataSet1.NHANVIEN);
            // TODO: This line of code loads data into the 'dataSet1.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.dataSet1.KHACHHANG);
            // TODO: This line of code loads data into the 'dataSet1.CT_HOADON' table. You can move, or remove it, as needed.
            this.cT_HOADONTableAdapter.Fill(this.dataSet1.CT_HOADON);
            // TODO: This line of code loads data into the 'dataSet1.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.dataSet1.HOADON);
            // TODO: This line of code loads data into the 'dataSet1.HOADON' table. You can move, or remove it, as needed.
            if (don.lstSP.Count == 0)
            {
                txt_sdt.Enabled = false;
                txt_tenkh.Enabled = false;
                rdb_nam.Enabled = false;
                rdb_Nu.Enabled = false;
            }
            else
            {
                txt_sdt.Enabled = true;
            }
            loadthongtin();

        }
        public void loadthongtin()
        {
            string maSP = xl.sanphambanchaynhat(dtp_ngay.Value, cbb_Loc.SelectedIndex);
            string maKH = xl.khachhangmuanhieunhat(dtp_ngay.Value, cbb_Loc.SelectedIndex);
            string maNV = xl.nhanviendoanhthucao(dtp_ngay.Value, cbb_Loc.SelectedIndex);
            if (maSP != "" || maKH != "" || maNV != "")
            {
                lbl_tongdoanhthu.Text = xl.tongdoanhthu(dtp_ngay.Value, cbb_Loc.SelectedIndex).ToString();
                lbl_Spbanchay.Text = xl.laySANPHAM(xl.sanphambanchaynhat(dtp_ngay.Value, cbb_Loc.SelectedIndex)).TENSP;
                lbl_khmuanhieu.Text = xl.layKHACHHANG(xl.khachhangmuanhieunhat(dtp_ngay.Value, cbb_Loc.SelectedIndex)).TENKH;
                lbl_nhanviengioi.Text = xl.layNhanVIen(xl.nhanviendoanhthucao(dtp_ngay.Value, cbb_Loc.SelectedIndex)).TENNV;
            }
            else
            {
                lbl_tongdoanhthu.Text = "";
                lbl_khmuanhieu.Text = "";
                lbl_nhanviengioi.Text = "";
                lbl_Spbanchay.Text = "";
            }
        }
        public void catnhatdonhang()
        {
            List<itemdonhang> l = don.lstSP;
            flowLP_hoadon.Controls.Clear();
            foreach (itemdonhang item in l)
            {
                UserControl_itemHoaDon u = new UserControl_itemHoaDon();
                u._sanp = item;
                u.btn_xoa.Tag = item.Masp;
                u.btn_xoa.Click += Btn_xoa_Click;
                flowLP_hoadon.Controls.Add(u);
            }
            
            txt_tongtien.Text = string.Format("{0:n0}", don.tongThanhTien());
            if (txt_tongtien.Text == "0")
                lbl_tienchu.Text = "";
            else
                lbl_tienchu.Text = xl.CHuyetsothanhchu(don.tongThanhTien()).ToUpperInvariant();
            if (don.lstSP.Count == 0)
            {
                txt_sdt.Enabled = false;
                txt_tenkh.Enabled = false;
                rdb_nam.Enabled = false;
                rdb_Nu.Enabled = false;
            }
            else
            {
                txt_sdt.Enabled = true;
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            lst = xl.dsSanPham_timkiem(txt_timkiem.Text);
            flowLP_timkiemsp.Controls.Clear();
            foreach (SANPHAM item in lst)
            {
                UserControl_sanpham user = new UserControl_sanpham();
                user._sp = item;
                user.Click += User_Click;
                flowLP_timkiemsp.Controls.Add(user);
            }
        }

        private void User_Click(object sender, EventArgs e)
        {
            UserControl_sanpham us = (UserControl_sanpham)sender;
            maspchon = us._sp.MASP;
            txt_sl.Enabled = true;
            txt_sl.Focus();
            txt_sl.ResetText();
            us.BackColor = System.Drawing.Color.WhiteSmoke;
            if (usersp != null)
                usersp.BackColor = System.Drawing.Color.White;
            usersp = (UserControl_sanpham)sender;


        }

        private void txt_sl_Enter(object sender, EventArgs e)
        {
        }

        private void txt_timkiem_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_timkiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if(lst.Count==1)
                {
                    don.Them(lst[0].MASP);
                    catnhatdonhang();
                    txt_timkiem.Text = null;
                }
        }
        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            Button use = (Button)sender;
            don.Bo(use.Tag.ToString());
            catnhatdonhang();
        }

        private void txt_sl_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter||e.KeyCode==Keys.Tab)
            {
                don.Them(maspchon,(int)txt_sl.Value);
                catnhatdonhang();
                txt_sl.Enabled = false;
                txt_timkiem.Focus();
                txt_timkiem.Text = null;
            }
           
           
                
        }

        private void txt_sdt_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                _kh = xl.timkhachhang(txt_sdt.Text);
                if(_kh!=null)
                {
                    txt_tenkh.Enabled = true;
                    rdb_nam.Enabled = true;
                    rdb_Nu.Enabled = true;
                    txt_tenkh.Text = _kh.TENKH;
                    if (_kh.GIOITINH == "Nam")
                        rdb_nam.Checked = true;
                    else
                        rdb_Nu.Checked =true;
                }
                else
                {
                    MessageBox.Show("Chưa có thông tin khách hàng, Hãy tạo mới.", "Thông báo");
                    txt_tenkh.Enabled = true;
                    rdb_nam.Enabled = true;
                    rdb_Nu.Enabled = true;
                }
            }
            
        }
        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if(_kh==null)
            {
                _kh = new KHACHHANG();
                _kh.MAKH = xl.Them_Ma_KH();
                string gt;
                if (rdb_nam.Checked)
                    gt = "Nam";
                else
                    gt = "Nữ";
                xl.ThemKH(_kh.MAKH, txt_tenkh.Text, txt_sdt.Text, gt, null, null);



            }
            string mahd = xl.Them_Ma_HD();
            bool luu = xl.LuuHD(mahd, _kh.MAKH, _nv.MANV, DateTime.Now, DateTime.Now, null, don.tongThanhTien(), "Mua tại cửa hàng", "Cửa Hàng", don.lstSP);
            if (luu)
            {
                MessageBox.Show("Bạn Có Muốn Xuất Hóa Đơn", "Thành công", MessageBoxButtons.YesNo);
                don = new DonHang();
                catnhatdonhang();
                TranginHoaDon frm = new TranginHoaDon();
                frm._mahd = mahd;
                frm.Show();
            }
        }

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void hOADONDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void hOADONDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(hOADONDataGridView.CurrentRow !=null)
            {
                this.cT_HOADONTableAdapter.FillBy(this.dataSet1.CT_HOADON,hOADONDataGridView.CurrentRow.Cells[0].Value.ToString());
                if (hOADONDataGridView.CurrentRow.Cells[8].Value.ToString() == "Xác Nhận Đơn Hàng")
                {
                    nGAYKTDateTimePicker.Visible = false;
                    btn_GiaoHang.Visible = true;
                }
                else
                {
                    nGAYKTDateTimePicker.Visible = true;
                    btn_GiaoHang.Visible = false;
                }
                kHACHHANGBindingSource.DataSource = xl.layKHACHHANG(hOADONDataGridView.CurrentRow.Cells[1].Value.ToString());
                if (hOADONDataGridView.CurrentRow.Cells[2].Value.ToString() != "")
                    nHANVIENBindingSource.DataSource = xl.layNhanVIen(hOADONDataGridView.CurrentRow.Cells[2].Value.ToString());
                else
                    nHANVIENBindingSource.DataSource = new NHANVIEN();
            }   
            else
            {
                this.cT_HOADONTableAdapter.FillBy(this.dataSet1.CT_HOADON, "");
            }
        }

        private void cT_HOADONDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(cT_HOADONDataGridView.CurrentRow != null)
            {
                sANPHAMBindingSource.DataSource = xl.laySANPHAM(cT_HOADONDataGridView.CurrentRow.Cells[1].Value.ToString());
            }
        }

        private void btn_TiemkiemHD_Click(object sender, EventArgs e)
        {
            if (cbb_timkiem.SelectedIndex == -1)
                MessageBox.Show("Bạn cần tìm kiếm theo???", "Thông Báo");
            else
            {
                if (cbb_timkiem.SelectedIndex == 0)
                {
                    this.hOADONTableAdapter.FilltheoMAHD(this.dataSet1.HOADON, txt_timkiemHD.Text);
                    
                }
                else
                {
                    if (cbb_timkiem.SelectedIndex == 1)
                    {
                        KHACHHANG kh = xl.timkhachhang(txt_timkiemHD.Text);
                        if (kh != null)
                        {
                            this.hOADONTableAdapter.FillMaKH(this.dataSet1.HOADON, kh.MAKH);
                            
                        }
                        else
                            MessageBox.Show("Không tìm thấy khách hàng cần tìm", "Thông Báo");
                    }
                }
            }
            
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            if(cbb_Loc.SelectedIndex==-1)
            {
                MessageBox.Show("Bạn cần Lọc theo???", "Thông Báo");
            }    
            else
            {
                if (cbb_Loc.SelectedIndex == 0)
                {
                    this.hOADONTableAdapter.Fill(this.dataSet1.HOADON);
                    
                }
                else
                {
                    if (cbb_Loc.SelectedIndex == 1)
                    {
                        this.hOADONTableAdapter.FillTheongay(this.dataSet1.HOADON, dtp_ngay.Value.ToString());
                    }
                    else
                    {
                        this.hOADONTableAdapter.FillTheoThang(this.dataSet1.HOADON, dtp_ngay.Value.Month, dtp_ngay.Value.Year);
                    }    
                }
                loadthongtin();
            }    
        }

        private void cbb_Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_Loc.SelectedIndex ==3)
            {
                dtp_ngay.Enabled = false;
            }    
            else
                dtp_ngay.Enabled = true;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btn_inhoadon_Click(object sender, EventArgs e)
        {
            TranginHoaDon frm = new TranginHoaDon();
            frm._mahd = mAHDTextBox.Text;
            frm.Show();
        }
    }
}
