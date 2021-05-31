using ShopQuanAo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new test());
            try
            {
                QLShopDataContext data = new QLShopDataContext(Properties.Settings.Default.connectionString);
                data.Connection.Open();
                data.Connection.Close();
                Application.Run(new frm_DangNhap());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Application.Run(new frm_ketnoi());
            }
            
        }
    }
}
