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
namespace ShopQuanAo.GUI
{
    public partial class TranginHoaDon : Form
    {
        public string _mahd;
        public TranginHoaDon()
        {
            InitializeComponent();
        }

        private void TranginHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Hoadon_view' table. You can move, or remove it, as needed.
            this.hoadon_viewTableAdapter.Fill(this.dataSet1.Hoadon_view);
            // TODO: This line of code loads data into the 'dataSet1.Hoadon_view' table. You can move, or remove it, as needed.
            this.hoadon_viewTableAdapter.FillTHeoMa(this.dataSet1.Hoadon_view,_mahd);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
