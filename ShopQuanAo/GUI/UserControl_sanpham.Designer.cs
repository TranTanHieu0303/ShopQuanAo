
namespace ShopQuanAo.GUI
{
    partial class UserControl_sanpham
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_TenSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_gia = new System.Windows.Forms.Label();
            this.ptx_hinh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptx_hinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TenSP
            // 
            this.lbl_TenSP.AutoSize = true;
            this.lbl_TenSP.Location = new System.Drawing.Point(75, 26);
            this.lbl_TenSP.Name = "lbl_TenSP";
            this.lbl_TenSP.Size = new System.Drawing.Size(35, 13);
            this.lbl_TenSP.TabIndex = 1;
            this.lbl_TenSP.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "VND";
            // 
            // lbl_gia
            // 
            this.lbl_gia.Location = new System.Drawing.Point(295, 26);
            this.lbl_gia.Name = "lbl_gia";
            this.lbl_gia.Size = new System.Drawing.Size(130, 13);
            this.lbl_gia.TabIndex = 3;
            this.lbl_gia.Text = "100000";
            this.lbl_gia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ptx_hinh
            // 
            this.ptx_hinh.Location = new System.Drawing.Point(3, 3);
            this.ptx_hinh.Name = "ptx_hinh";
            this.ptx_hinh.Size = new System.Drawing.Size(66, 66);
            this.ptx_hinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptx_hinh.TabIndex = 0;
            this.ptx_hinh.TabStop = false;
            // 
            // UserControl_sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_gia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_TenSP);
            this.Controls.Add(this.ptx_hinh);
            this.Name = "UserControl_sanpham";
            this.Size = new System.Drawing.Size(476, 72);
            this.Load += new System.EventHandler(this.UserControl_sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptx_hinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptx_hinh;
        private System.Windows.Forms.Label lbl_TenSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_gia;
    }
}
