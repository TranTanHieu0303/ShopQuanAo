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
namespace ShopQuanAo
{
    public partial class SanPham : Form
    {
        XuLy xl = new XuLy();
        string pHinhAnh;
        bool chonanh = false;
        public SanPham()
        {
            InitializeComponent();
        }

        private void sANPHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
        public void settext(bool set)
        {
            lOAIComboBox.Enabled = set;
            mASPTextBox.Enabled = set;
            tENSPTextBox.Enabled = set;
            dONGIATextBox.Enabled = set;
            tRANGTHAITextBox.Enabled = set;
            mOTATextBox.Enabled = set;
            sOLUONGTextBox.Enabled = set;

        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.LOAI' table. You can move, or remove it, as needed.
            this.lOAITableAdapter.Fill(this.dataSet1.LOAI);
            // TODO: This line of code loads data into the 'dataSet1.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.dataSet1.SANPHAM);
            btn_openfile.Visible = false;
            btn_HoanTac.Visible = false;
            btn_LuuDaTa.Visible = false;
            settext(false);
            setdatagridview(sANPHAMDataGridView);

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
        private void mASPLabel_Click(object sender, EventArgs e)
        {

        }

        private void mASPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tENSPLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENSPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hINHANHLabel_Click(object sender, EventArgs e)
        {

        }

        private void hINHANHTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mOTALabel_Click(object sender, EventArgs e)
        {

        }

        private void mOTATextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dONGIALabel_Click(object sender, EventArgs e)
        {

        }

        private void dONGIATextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tRANGTHAILabel_Click(object sender, EventArgs e)
        {

        }

        private void tRANGTHAITextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sOLUONGLabel_Click(object sender, EventArgs e)
        {

        }

        private void sOLUONGTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mALOAILabel_Click(object sender, EventArgs e)
        {

        }

        private void mALOAITextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sANPHAMDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (sANPHAMDataGridView.CurrentRow != null)
            {
                if (sANPHAMDataGridView.CurrentRow.Cells[2].Value.ToString() != "")
                {
                    pHinhAnh = sANPHAMDataGridView.CurrentRow.Cells[2].Value.ToString();
                    ptb_hinhanhNV.Image = Image.FromFile("Resources\\" +pHinhAnh );
                    lOAIComboBox.SelectedValue = sANPHAMDataGridView.CurrentRow.Cells[7].Value.ToString();
                }
                else
                {
                    ptb_hinhanhNV.Image = Image.FromFile("Resources\\erorr.png");
                }    
                
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            sANPHAMDataGridView.ClearSelection();
            sANPHAMDataGridView.AllowUserToAddRows = true;
            settextnull();
            btn_CapNhat.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_LuuDaTa.Visible = true;
            btn_HoanTac.Visible = true;
            btn_openfile.Visible = true;
            mASPTextBox.Text = xl.Them_Ma_SP();
            settext(true);
            mASPTextBox.Enabled = false;
        }

        private void btn_HoanTac_Click(object sender, EventArgs e)
        {
            if (btn_Them.Enabled)
            {
                sANPHAMDataGridView.AllowUserToAddRows = false;
                settext(false);
                btn_CapNhat.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_LuuDaTa.Visible = false;
                btn_HoanTac.Visible = false;
                btn_openfile.Visible = false;
                this.sANPHAMTableAdapter.Fill(this.dataSet1.SANPHAM);
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
                    settext(false);
                    this.sANPHAMTableAdapter.Fill(this.dataSet1.SANPHAM);
                }
            }

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_LuuDaTa.Visible = true;
            btn_HoanTac.Visible = true;
            btn_openfile.Visible = true;
            settext(true);
            mASPTextBox.Enabled = false;
        }
        public void settextnull()
        {
            tENSPTextBox.Text = null;
            dONGIATextBox.Text = null;
            tRANGTHAITextBox.Text = null;
            sOLUONGTextBox.Text = null;
            mOTATextBox.Text = null;
            ptb_hinhanhNV.Image = Image.FromFile("Resources\\add_hinh.jpg");
        }

        private void btn_openfile_Click(object sender, EventArgs e)
        {
            openfile.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            openfile.Title = "Open an Image File";
            DialogResult dr = openfile.ShowDialog();
            if (dr == DialogResult.OK)
            {

                ptb_hinhanhNV.Image = Image.FromFile(openfile.FileName);
                chonanh = true;

            }
        }

        private void btn_LuuDaTa_Click(object sender, EventArgs e)
        {
            if(chonanh)
                pHinhAnh  = xl.LuuAnh( mASPTextBox.Text, openfile, ptb_hinhanhNV.Image);
            
            if(btn_Them.Enabled)
            {
                bool kq = xl.ThemSP(mASPTextBox.Text, tENSPTextBox.Text, pHinhAnh, mOTATextBox.Text, dONGIATextBox.Text, tRANGTHAITextBox.Text, sOLUONGTextBox.Text, lOAIComboBox.SelectedValue.ToString()); 
                if(kq)
                {
                    MessageBox.Show("Thêm Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                btn_CapNhat.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_LuuDaTa.Visible = false;
                btn_HoanTac.Visible = false;
                btn_openfile.Visible = false;
                this.sANPHAMTableAdapter.Fill(this.dataSet1.SANPHAM);
            }
            else
            {
                bool kq = xl.CapNhatSP(mASPTextBox.Text, tENSPTextBox.Text, pHinhAnh, mOTATextBox.Text, dONGIATextBox.Text, tRANGTHAITextBox.Text, sOLUONGTextBox.Text, lOAIComboBox.SelectedValue.ToString());
                if (kq)
                {
                    MessageBox.Show("Cập Nhật Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cật Nhật Không Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_LuuDaTa.Visible = false;
                btn_HoanTac.Visible = false;
                btn_openfile.Visible = false;
                settext(false);
                this.sANPHAMTableAdapter.Fill(this.dataSet1.SANPHAM);
            }
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            {
                bool kq = xl.XoaSP(mASPTextBox.Text);
                if (kq)
                {
                    MessageBox.Show("Xóa Thành Công", "Xóa Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.sANPHAMTableAdapter.Fill(this.dataSet1.SANPHAM);
                }
                else
                    MessageBox.Show("Xóa Không Thành Công", "Xóa Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dONGIATextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

        private void sOLUONGTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
