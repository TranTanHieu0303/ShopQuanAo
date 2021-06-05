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
using ShopQuanAo.BLL;
using ShopQuanAo.GUI;

namespace ShopQuanAo
{
    public partial class NhapHang : Form
    {
        List<SANPHAM> lst;
        DonHang don = new DonHang();
        XuLy xl = new XuLy();
        string maspchon;
        UserControl_sanpham usersp;
        public NhapHang()
        {
            InitializeComponent();
        }

        

        private void NhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CT_NHAPHANG' table. You can move, or remove it, as needed.
            this.cT_NHAPHANGTableAdapter.Fill(this.dataSet1.CT_NHAPHANG);
            // TODO: This line of code loads data into the 'dataSet1.NHAPHANG' table. You can move, or remove it, as needed.
            this.nHAPHANGTableAdapter.Fill(this.dataSet1.NHAPHANG);
            // TODO: This line of code loads data into the 'dataSet1.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.dataSet1.SANPHAM);
            setdatagridview(nHAPHANGDataGridView);
            setdatagridview(cT_NHAPHANGDataGridView);
        }
        public void setdatagridview(DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 10, FontStyle.Bold);
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            for(int i=  0; i<dataGridView.ColumnCount;i++)
            {
                dataGridView.Columns[i].DefaultCellStyle.Font = new Font("tahoma", 10);
            }    
        }
        public void catnhatphieunhap()
        {
            List<itemdonhang> l = don.lstSP;
            flowLP_hoadon.Controls.Clear();
            foreach (itemdonhang item in l)
            {
                UserControl_itemHoaDon u = new UserControl_itemHoaDon();
                u._sanp = item;
                u.btn_xoa.Tag = item.Masp;
                u.btn_xoa.Click += Btn_xoa_Click; ;
                flowLP_hoadon.Controls.Add(u);
            }

            lbl_tongtiennhap.Text = string.Format("{0:n0}", don.tongThanhTien());
            if (lbl_tongtiennhap.Text == "0")
                lbl_tienchu.Text = "";
            else
                lbl_tienchu.Text = xl.CHuyetsothanhchu(don.tongThanhTien()).ToUpperInvariant();
            
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            Button use = (Button)sender;
            don.Bo(use.Tag.ToString());
            catnhatphieunhap();
        }

        private void sANPHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
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
                user.Click += User_Click; ;
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

        private void txt_timkiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter||e.KeyCode==Keys.Tab)
                if (lst.Count == 1)
                {
                    maspchon = lst[0].MASP;
                    txt_sl.Enabled = true;
                    txt_sl.Focus();
                    txt_sl.ResetText();
                }
        }

        private void txt_sl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txt_GiaNhap.Enabled = true;
                txt_GiaNhap.Focus();
                txt_GiaNhap.ResetText();
            }
            
        }

        private void txt_sl_Leave(object sender, EventArgs e)
        {
            if (txt_sl.Value ==0)
                txt_sl.Focus();
        }

        private void txt_GiaNhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if(txt_GiaNhap.Text!="")
                {
                    don.Them(maspchon, (int)txt_sl.Value,int.Parse(txt_GiaNhap.Text));
                    catnhatphieunhap();
                    txt_sl.Enabled = false;
                    txt_GiaNhap.Enabled = false;
                    txt_sl.ResetText();
                    txt_GiaNhap.ResetText();
                    txt_timkiem.Focus();
                    txt_timkiem.ResetText() ;
                }    
            }
        }

        private void bnt_xuatphieunhap_Click(object sender, EventArgs e)
        {
            string ma = xl.Them_Ma_PN();
            bool kq = xl.LuuPN(ma, DateTime.Now, don.tongThanhTien(), don.lstSP);
            if(kq)
            {
                MessageBox.Show("Bạn Có Muốn Xuất Phiếu Nhập", "Thành công", MessageBoxButtons.YesNo);
                don = new DonHang();
                catnhatphieunhap();
                TrangInPhieuNhap frm = new TrangInPhieuNhap();
                frm._MaPN = ma;
                frm.ShowDialog();
                
            }    
        }

        private void cT_NHAPHANGDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(cT_NHAPHANGDataGridView.CurrentRow !=null)
            sANPHAMBindingSource.DataSource = xl.laySANPHAM(cT_NHAPHANGDataGridView.CurrentRow.Cells[1].Value.ToString());
        }

        private void txt_timmanhap_TextChanged(object sender, EventArgs e)
        {
            string ma =  txt_timmanhap.Text;
            this.nHAPHANGTableAdapter.FilltheoMa(this.dataSet1.NHAPHANG,ma); 

        }

        private void nHAPHANGDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(nHAPHANGDataGridView.CurrentRow!= null)
            {
                this.cT_NHAPHANGTableAdapter.FillTheoMa(this.dataSet1.CT_NHAPHANG, nHAPHANGDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                this.cT_NHAPHANGTableAdapter.FillTheoMa(this.dataSet1.CT_NHAPHANG, "");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.nHAPHANGTableAdapter.FillTheoNgay(this.dataSet1.NHAPHANG, dateTimePicker1.Value.ToString());
        }

        private void btn_lammoinh_Click(object sender, EventArgs e)
        {
            this.nHAPHANGTableAdapter.Fill(this.dataSet1.NHAPHANG);
        }

        private void btn_inPN_Click(object sender, EventArgs e)
        {
            TrangInPhieuNhap frm = new TrangInPhieuNhap();
            frm._MaPN = mANHAPTextBox.Text;
            frm.ShowDialog();
        }

        private void txt_GiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
