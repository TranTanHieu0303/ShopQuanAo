using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo
{
    public partial class frm_ketnoi : Form
    {
        XuLy xl = new XuLy();
        public frm_ketnoi()
        {
            InitializeComponent();
        }

        private void frm_ketnoi_Load(object sender, EventArgs e)
        {
            cbb_Authentication.Items.Insert(0, "Windows Authentication");
            cbb_Authentication.Items.Insert(1, "SQL Server Authentication");
            cbb_Authentication.SelectedIndex = 0;
        }

        private void cbb_Authentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Authentication.SelectedIndex == 0)
            {
                txt_UerName.Enabled = false;
                txt_Pass.Enabled = false;
            }
            else
            {
                txt_UerName.Enabled = true;
                txt_Pass.Enabled = true;
            }
        }

        private void cbb_ServerName_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            cbb_ServerName.DataSource = dt;
            cbb_ServerName.DisplayMember = "ServerName";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_KetNoi_Click(object sender, EventArgs e)
        {
            string _ServerName = cbb_ServerName.Text;
            int _quyen = cbb_Authentication.SelectedIndex;
            string _Username = txt_UerName.Text;
            string _Pass = txt_Pass.Text;
            string con = "";
            if (_quyen == 1)
            {
                if (_ServerName.Length == 0 || _Username.Length == 0 || _Pass.Length == 0)
                    MessageBox.Show("Bạn cần nhâp đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    con = @"Server=" + _ServerName + ";Database=QL_SHOPQUANAO_1;User Id=" + _Username + ";Password=" + _Pass;
            }
            else
            {
                if (_ServerName.Length == 0)
                    MessageBox.Show("Bạn cần nhâp đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    con = @"Data Source=" + _ServerName + ";Initial Catalog=QL_SHOPQUANAO_1;Integrated Security=True";
            }
            if (xl.ketnoiBD(con))
                MessageBox.Show("thanh cong");
            else
                MessageBox.Show("that bai");
        }
    }
}
