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
namespace ShopQuanAo.GUI
{
    public partial class UserControl_sanpham : UserControl
    {
        public SANPHAM _sp;
        public UserControl_sanpham()
        {
            InitializeComponent();
        }

        private void UserControl_sanpham_Load(object sender, EventArgs e)
        {
            ptx_hinh.Image = Image.FromFile("Resources\\" + _sp.HINHANH);
            lbl_TenSP.Text = _sp.TENSP;
            lbl_gia.Text = _sp.DONGIA.ToString();
        }
    }
}
