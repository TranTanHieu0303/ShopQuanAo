using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopQuanAo.DAL;
namespace ShopQuanAo
{
    public partial class Form1 : Form
    {
        public Form _frm;
        XuLy XL = new XuLy();
        public NHANVIEN _nv;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnSanPham_Click(object sender, EventArgs e)   //Button Sản Phẩm//
        {
            dismdirent();
            SanPham fr = new SanPham();
            fr.MdiParent = this;
            fr.MaximizeBox = true;
            fr.Show();
        }
        public void disconnect(Form f)
        {
            foreach (Form fr in this.MdiChildren)
            {
                if (fr.GetType() == f.GetType() && fr != f)
                {
                    fr.Dispose();
                    fr.Close();
                }
            }
        }
        public void dismdirent()
        {
            Form[] childArray = this.MdiChildren;
            foreach (Form childForm in childArray)
            {
                childForm.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //if (ActiveMdiChild != null)
            //    ActiveMdiChild.Close();
            if (XL.Chucvu(_nv.CHUCVU.ToString()).TENCV.ToString() == "Admin")
            {
                btnSanPham.Enabled = true;
                btnHD.Enabled = true;
                btnNhanVien.Enabled = true;
                btnNhapHang.Enabled = true;
                btnKH.Enabled = true;
            }
            else
            {
                btnSanPham.Enabled = true;
                btnNhapHang.Enabled = true;
                btnHD.Enabled = true;
                btnNhanVien.Visible = false;
                btnKH.Enabled = true;
                SanPham fr = new SanPham();
                fr.MdiParent = this;
                fr.MaximizeBox = true;
                fr.Show();
            }
            ptb_hinhanh.Image = Image.FromFile("Resources\\" + _nv.HINHANH.ToString());
            lbl_MANV.Text = _nv.MANV.ToString();
            lbl_TenNv.Text = _nv.TENNV.ToString();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)   //Button Nhân Viên//
        {
            dismdirent();
            NhanVien fr = new NhanVien();
            fr.MdiParent = this;
            fr.Show();
            

        }

        private void btnHD_Click(object sender, EventArgs e)          //Button Hóa Đơn//
        {
            dismdirent();
            HoaDon fr = new HoaDon();
            fr.MdiParent = this;
            fr._nv = _nv;
            fr.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)         //Button Thoát//
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnDX_Click(object sender, EventArgs e)           //Button Khách Hàng//
        {
            dismdirent();
            KhachHang fr = new KhachHang();
            fr.MdiParent = this;
            fr.Show();

        }

        private void btnLoad_Click(object sender, EventArgs e)          //Button Load lại dữ liệu//
        {
            KhoiTaoDuLieu fr = new KhoiTaoDuLieu();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)          //Button Nhập Hàng//
        {
            dismdirent();
            NhapHang fr = new NhapHang();
            fr.MdiParent = this;
            fr.Show();
            

        }


        private void btnDX_Click_1(object sender, EventArgs e) //button Đăng Xuất
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                this._frm.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
