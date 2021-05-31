using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopQuanAo.BLL;
namespace ShopQuanAo
{
    public partial class KhachHang : Form
    {
        XuLy xl = new XuLy();
        public KhachHang()
        {
            InitializeComponent();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.dataSet1.KHACHHANG);
            // TODO: This line of code loads data into the 'dataSet1.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.dataSet1.KHACHHANG);
            btn_LuuDaTa.Visible = false;
            btn_HoanTac.Visible = false;
            settext(false);
        }
        public void settext(bool set)
        {
            mAKHTextBox.Enabled = set;
            tENKHTextBox.Enabled = set;
            sDTTextBox.Enabled = set;
            dIACHITextBox.Enabled = set;
            rdb_Nam.Enabled = set;
            rdb_Nu.Enabled = set;
            pASSTextBox.Enabled = set;
        }
        public void setnull()
        {
            mAKHTextBox.Text = null;
            tENKHTextBox.Text = null;
            sDTTextBox.Text = null;
            dIACHITextBox.Text = null;
            pASSTextBox.Text = null;
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void kHACHHANGDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(kHACHHANGDataGridView.CurrentRow !=null)
            {
                if (kHACHHANGDataGridView.CurrentRow.Cells[4].Value.ToString() == "Nam")
                {
                    rdb_Nam.Checked = true;
                }
                else
                    rdb_Nu.Checked = true;
            }    
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            setnull();
            settext(true);
            mAKHTextBox.Text = xl.Them_Ma_KH();
            mAKHTextBox.Enabled = false;
            btn_CapNhat.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_HoanTac.Visible = true;
            btn_LuuDaTa.Visible = true;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            settext(true);
            mAKHTextBox.Enabled = false;
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_HoanTac.Visible = true;
            btn_LuuDaTa.Visible = true;
        }

        private void btn_HoanTac_Click(object sender, EventArgs e)
        {
            if(btn_Them.Enabled)
            {
                btn_CapNhat.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_LuuDaTa.Visible = false;
                btn_HoanTac.Visible = false;
                settext(false);
                this.kHACHHANGTableAdapter.Fill(this.dataSet1.KHACHHANG);
            }
            else
            {
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_LuuDaTa.Visible = false;
                btn_HoanTac.Visible = false;
                settext(false);
                this.kHACHHANGTableAdapter.Fill(this.dataSet1.KHACHHANG);
            }
        }

        private void btn_LuuDaTa_Click(object sender, EventArgs e)
        {
            string gioitinh="";
            if (rdb_Nam.Checked)
                gioitinh = "Nam";
            if (rdb_Nu.Checked)
                gioitinh = "Nữ";
            if(btn_Them.Enabled)
            {
                bool kq = xl.themKH(mAKHTextBox.Text, tENKHTextBox.Text, sDTTextBox.Text, dIACHITextBox.Text, gioitinh, pASSTextBox.Text);
                if(kq)
                {
                    MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                else
                    MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_CapNhat.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_LuuDaTa.Visible = false;
                btn_HoanTac.Visible = false;
                settext(false);
                this.kHACHHANGTableAdapter.Fill(this.dataSet1.KHACHHANG);
            }
            else
            {
                bool kq = xl.CapNhatKH(mAKHTextBox.Text, tENKHTextBox.Text, sDTTextBox.Text, dIACHITextBox.Text, gioitinh, pASSTextBox.Text);
                if (kq)
                {
                    MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Them.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_LuuDaTa.Visible = false;
                btn_HoanTac.Visible = false;
                settext(false);
                this.kHACHHANGTableAdapter.Fill(this.dataSet1.KHACHHANG);
            } 
                
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn Có Chắn Muốn Xóa Tài khoản Này", "Xóa Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(hoi == DialogResult.Yes)
            {
                bool kq = xl.XoaKh(mAKHTextBox.Text);
                if(kq)
                {
                    MessageBox.Show("Thành Công", "Xóa Tài Khoản", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Thất Bại", "Xóa Tài Khoản", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.kHACHHANGTableAdapter.Fill(this.dataSet1.KHACHHANG);
            }    
        }
    }
}
