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
    public partial class TrangInPhieuNhap : Form
    {
        public string _MaPN;
        public TrangInPhieuNhap()
        {
            InitializeComponent();
        }

        private void TrangInPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PhieuNhap_view' table. You can move, or remove it, as needed.
            this.phieuNhap_viewTableAdapter.Fill(this.dataSet1.PhieuNhap_view,_MaPN);

            this.reportViewer1.RefreshReport();
        }
    }
}
