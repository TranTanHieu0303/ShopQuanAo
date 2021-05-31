using ShopQuanAo.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo
{
    public partial class frm_DangNhap : Form
    {
        XuLy XL = new XuLy();
        KiemtraVanTay kt = new KiemtraVanTay();
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void cb_HienthiPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_HienthiPass.Checked)
                txt_Pass.UseSystemPasswordChar = false;
            else
                txt_Pass.UseSystemPasswordChar = true;
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            if (txt_Pass.TextLength == 0 || txt_UseName.TextLength == 0)
                MessageBox.Show("Thông tin đăng nhập không được để trống","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            {
                NHANVIEN NV = XL.DangNhap(txt_UseName.Text, txt_Pass.Text);
                if (NV == null)
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu của bạn không đúng. Vui lòng kiểm tra lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    //Form1 frm = new Form1();
                    //frm._nv = XL.DangNhap(txt_UseName.Text, txt_Pass.Text);
                    //frm.Show();
                    //this.Hide();
                    if (XL.ktChamCong(NV.MANV, DateTime.Now))
                    {
                        DialogResult dr = MessageBox.Show("Hôm nay bạn chưa hiện điểm danh, bạn cần điểm danh ngay bây giờ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            OpenFileDialog drl = new OpenFileDialog();
                            if (drl.ShowDialog() == DialogResult.OK)
                            {
                                if (kt.ktVantay(NV.MANV, drl.FileName))
                                    if (XL.ChamCong(NV.MANV, DateTime.Now))
                                    {
                                        MessageBox.Show("Điểm danh thanh công");
                                        Form1 frm = new Form1();
                                        frm._nv = XL.DangNhap(txt_UseName.Text, txt_Pass.Text);
                                        frm.Show();
                                        this.Hide();
                                    }
                                    else
                                        MessageBox.Show("Điểm danh không thành công");
                                else
                                    MessageBox.Show("Vân tay không trung khớp, vui lòng kiểm tra lại");


                            }
                        }
                    }
                    else
                    {
                        Form1 frm = new Form1();
                        frm._nv = XL.DangNhap(txt_UseName.Text, txt_Pass.Text);
                        frm.Show();
                        this.Hide();
                    }
                    
                }
            }
        }
    }
}
