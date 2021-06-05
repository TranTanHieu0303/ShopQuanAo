using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopQuanAo.GUI;
using ShopQuanAo.BLL;

namespace ShopQuanAo
{
    public partial class NhanVien : Form
    {
        XuLy xl = new XuLy();
        string pHinhAnh;
        bool chonanh = false;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
        public void settext(bool set)
        {
            cHUCVUComboBox.Enabled = set;
            mANVTextBox.Enabled = set;
            tENNVTextBox.Enabled = set;
            sDTTextBox.Enabled = set;
            rdb_Nam.Enabled = set;
            rdb_Nu.Enabled = set;
            uSERNAMETextBox.Enabled = set;
            pASSTextBox.Enabled = set;
            dONLUONGTextBox.Enabled = set;

        }
        public void setnull()
        {

            mANVTextBox.Text = null;
            tENNVTextBox.Text= null;
            sDTTextBox.Text = null;
            uSERNAMETextBox.Text = null;
            pASSTextBox.Text = null;
            dONLUONGTextBox.Text = null;
            dONLUONGTextBox.Text = null;
            sOCONGTextBox.Text = null;
            tONGLUONGTextBox.Text = null;
            ptx_HinhAnh.Image = Image.FromFile("Resources\\add_hinh.jpg");

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CT_NGAYLAM' table. You can move, or remove it, as needed.
            this.cT_NGAYLAMTableAdapter.Fill(this.dataSet1.CT_NGAYLAM);
            // TODO: This line of code loads data into the 'dataSet1.BANGCHAMCONG' table. You can move, or remove it, as needed.
            this.bANGCHAMCONGTableAdapter.Fill(this.dataSet1.BANGCHAMCONG);
            // TODO: This line of code loads data into the 'dataSet1.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.dataSet1.CHUCVU);
            // TODO: This line of code loads data into the 'dataSet1.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.dataSet1.NHANVIEN);
            btn_LuuDaTa.Visible = false;
            btn_HoanTac.Visible = false;
            btn_openfile.Visible = false;
            sOCONGTextBox.Enabled = false;
            tONGLUONGTextBox.Enabled = false;
            settext(false);

            setdatagridview(nHANVIENDataGridView);
        }
        public void setdatagridview(DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 10, FontStyle.Bold);
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                dataGridView.Columns[i].DefaultCellStyle.Font = new Font("tahoma", 10);
            }
        }
        private void nHANVIENBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void nHANVIENDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //ptx_HinhAnh.Image = Image.FromFile("Resources\\quanly.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            nHANVIENDataGridView.ClearSelection();
            nHANVIENDataGridView.AllowUserToAddRows = true;
            btn_CapNhat.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_LuuDaTa.Visible = true;
            btn_HoanTac.Visible = true;
            btn_openfile.Visible = true;
            btn_inbangluong.Visible = false;
            btn_TraLuong.Visible = false;
            btn_vantay.Visible = true;
            settext(true);
            setnull();
            mANVTextBox.Text = xl.Them_Ma_NV();
            mANVTextBox.Enabled = false;
        }

        private void btn_HoanTac_Click(object sender, EventArgs e)
        {
            if (btn_Them.Enabled)
            {
                nHANVIENDataGridView.AllowUserToAddRows = false;
                btn_CapNhat.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_LuuDaTa.Visible = false;
                btn_HoanTac.Visible = false;
                btn_openfile.Visible = false;
                btn_inbangluong.Visible = true;
                btn_TraLuong.Visible = true;
                settext(false);
                this.nHANVIENTableAdapter.Fill(this.dataSet1.NHANVIEN);
            }
            else
            {
                if (btn_CapNhat.Enabled)
                {
                    btn_Them.Enabled = true;
                    btn_Xoa.Enabled = true;
                    btn_LuuDaTa.Visible = false;
                    btn_HoanTac.Visible = false;
                    btn_openfile.Visible = false;
                    btn_inbangluong.Visible = true;
                    btn_TraLuong.Visible = true;
                    settext(false);
                    this.nHANVIENTableAdapter.Fill(this.dataSet1.NHANVIEN);
                }
            }
            chonanh = false;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_LuuDaTa.Visible = true;
            btn_HoanTac.Visible = true;
            btn_openfile.Visible = true;
            btn_inbangluong.Visible = false;
            btn_TraLuong.Visible = false;
            btn_vantay.Visible = true;
            settext(true);
            mANVTextBox.Enabled = false;
        }

        private void btn_LuuDaTa_Click(object sender, EventArgs e)
        {
            
            string gioitinh="Nam";
            if (chonanh)
                pHinhAnh = xl.LuuAnh(mANVTextBox.Text, openFile, ptx_HinhAnh.Image);
            if (rdb_Nam.Checked)
                gioitinh = "Nam";
            if (rdb_Nu.Checked)
                gioitinh = "Nữ";
            if(btn_Them.Enabled)
            {
                bool kq = xl.ThemNV(mANVTextBox.Text,tENNVTextBox.Text,pHinhAnh,sDTTextBox.Text,gioitinh,uSERNAMETextBox.Text,pASSTextBox.Text,cHUCVUComboBox.SelectedValue.ToString(),int.Parse(dONLUONGTextBox.Text));
                if (kq)
                    MessageBox.Show("Thêm Nhân Viên Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm Nhân Viên Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_CapNhat.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_LuuDaTa.Visible = false;
                btn_HoanTac.Visible = false;
                btn_openfile.Visible = false;
                settext(false);
                this.nHANVIENTableAdapter.Fill(this.dataSet1.NHANVIEN);
            }
            else  
            {
                bool kq = xl.CapNhatNV(mANVTextBox.Text, tENNVTextBox.Text, pHinhAnh, sDTTextBox.Text, gioitinh, uSERNAMETextBox.Text, pASSTextBox.Text, cHUCVUComboBox.SelectedValue.ToString(), int.Parse(dONLUONGTextBox.Text));
                if (kq)
                    MessageBox.Show("Cập Nhật Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_LuuDaTa.Visible = false;
                btn_HoanTac.Visible = false;
                btn_openfile.Visible = false;
                settext(false);
                this.nHANVIENTableAdapter.Fill(this.dataSet1.NHANVIEN);
            }
        }

        private void btn_openfile_Click(object sender, EventArgs e)
        {
            openFile.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            openFile.Title = "Open an Image File";
            DialogResult dr = openFile.ShowDialog();
            if (dr == DialogResult.OK)
            {

                ptx_HinhAnh.Image = Image.FromFile(openFile.FileName);
                chonanh = true;

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                bool kq = xl.XoaNV(mANVTextBox.Text);
                if (kq)
                {
                    MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.nHANVIENTableAdapter.Fill(this.dataSet1.NHANVIEN);
                }

            }
        }

        private void nHANVIENDataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            if (nHANVIENDataGridView.CurrentRow != null)
            {
                if (nHANVIENDataGridView.CurrentRow.Cells[2].Value.ToString() != "")
                {
                    pHinhAnh = nHANVIENDataGridView.CurrentRow.Cells[2].Value.ToString();
                    ptx_HinhAnh.Image = Image.FromFile("Resources\\" + pHinhAnh);
                    cHUCVUComboBox.SelectedValue = nHANVIENDataGridView.CurrentRow.Cells[7].Value.ToString();
                    bANGCHAMCONGBindingSource.DataSource = xl.layNhanVIen(nHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString());
                    cT_NGAYLAMTableAdapter.FillTheoMaNV(this.dataSet1.CT_NGAYLAM, mANVTextBox.Text);
                    btn_vantay.Visible = xl.vantay(nHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString());
                    if (nHANVIENDataGridView.CurrentRow.Cells[4].Value.ToString() == "Nam")
                        rdb_Nam.Checked = true;
                    else
                        rdb_Nu.Checked = true;
                   
                }
                else
                {
                    ptx_HinhAnh.Image = Image.FromFile("Resources\\erorr.png");
                }
            }
        }

        private void btn_vantay_Click(object sender, EventArgs e)
        {
            openFile.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            openFile.Title = "Open an Image File";
            DialogResult dr = openFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string hinh = xl.LuuAnh(xl.Them_Ma_VT(), openFile,Image.FromFile(openFile.FileName));
                if (btn_Them.Enabled)
                {
                    if (xl.themVanTay(mANVTextBox.Text, hinh))
                        MessageBox.Show("Thêm Thành Công");
                }
                else
                {
                    if (btn_CapNhat.Enabled)
                    {
                        if (xl.capnhatVanTay(mANVTextBox.Text, hinh))
                            MessageBox.Show("Cập Nhật Thành Công");
                    }
                }
            }
        }

        private void btn_inbangluong_Click(object sender, EventArgs e)
        {
            frm_In_Luong frm = new frm_In_Luong();
            frm._manv = mANVTextBox.Text;
            frm.Show();
        }

        private void btn_TraLuong_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sDTTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dONLUONGTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
