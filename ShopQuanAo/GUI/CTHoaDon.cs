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
    public partial class CTHoaDon : Form
    {
        public CTHoaDon()
        {
            InitializeComponent();
        }

        private void cT_HOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cT_HOADONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void CTHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CT_HOADON' table. You can move, or remove it, as needed.
            this.cT_HOADONTableAdapter.Fill(this.dataSet1.CT_HOADON);

        }
    }
}
