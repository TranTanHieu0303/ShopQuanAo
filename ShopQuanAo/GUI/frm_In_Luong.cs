using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo.GUI
{
    public partial class frm_In_Luong : Form
    {
        public string _manv;
        public frm_In_Luong()
        {
            InitializeComponent();
        }

        private void frm_In_Luong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.FillTheoMa(this.dataSet1.NHANVIEN,_manv);
            // TODO: This line of code loads data into the 'dataSet1.BANGCHAMCONG' table. You can move, or remove it, as needed.
            this.bANGCHAMCONGTableAdapter.Fill(this.dataSet1.BANGCHAMCONG);
            // TODO: This line of code loads data into the 'dataSet1.CT_NGAYLAM' table. You can move, or remove it, as needed.
            this.cT_NGAYLAMTableAdapter.FillTheoMaNV(this.dataSet1.CT_NGAYLAM,_manv);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
