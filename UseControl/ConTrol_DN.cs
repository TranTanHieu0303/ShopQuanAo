using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseControl
{
    public partial class ConTrol_DN : UserControl
    {
        public ConTrol_DN()
        {
            InitializeComponent();
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            if(txt_UseName.Text==null||txt_Pass.Text==null)
                MessageBox.Show(lbl_UseName.Text+" & "+lbl_Pass.Text+" Không được để trống","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

    }
}
