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
    public partial class test : Form
    {
        QLShopDataContext data = new QLShopDataContext();
        KiemtraVanTay kt = new KiemtraVanTay();
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.dataSet1.SANPHAM);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string manv = data.NHANVIENs.FirstOrDefault(nv=>nv.USERNAME=="Hieu"&&nv.PASS=="123").MANV.ToString();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                if (kt.ktVantay(manv, openFileDialog1.FileName))
                    MessageBox.Show("trung khop");
                else
                    MessageBox.Show("khong trung khop");
        }

        private void sANPHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
