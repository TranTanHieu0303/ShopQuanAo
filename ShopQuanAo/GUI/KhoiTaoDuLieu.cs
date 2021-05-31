using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopQuanAo
{
    public partial class KhoiTaoDuLieu : Form
    {
        public KhoiTaoDuLieu()
        {
            InitializeComponent();
        }
        private Task ProcessData(List<string> lst, IProgress<ProcessReport> process)
        {
            int index = 1;
            int total = lst.Count;
            var ProcessReport = new ProcessReport();
            return Task.Run(() =>
            {
                for (int i = 0; i < total; i++)
                {
                    ProcessReport.PercentComplete = index++ * 100 / total;
                    process.Report(ProcessReport);
                    Thread.Sleep(10);
                }
            });
        }

        private async void KhoiTaoDuLieu_Load(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            for (int i = 0; i < 1000; i++)
                lst.Add(i.ToString());
            label1.Text = "Chuẩn bị thực thi";
            var process = new Progress<ProcessReport>();
            process.ProgressChanged += (o, report) =>
            {
                progressBar1.Visible = true;
                label1.Text = string.Format("Đang khởi tạo lại dữ liệu....{0}%", report.PercentComplete);
                progressBar1.Value = report.PercentComplete;
                progressBar1.Update();
            };
            await ProcessData(lst, process);
            MessageBox.Show("Khởi tạo dữ liệu thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Application.Restart();
        }
    }
}
