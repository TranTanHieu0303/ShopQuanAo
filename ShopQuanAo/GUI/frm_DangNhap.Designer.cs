namespace ShopQuanAo
{
    partial class frm_DangNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DN = new System.Windows.Forms.Button();
            this.cb_HienthiPass = new System.Windows.Forms.CheckBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_UseName = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_UseName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(270, 178);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(91, 27);
            this.btn_Thoat.TabIndex = 15;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_DN
            // 
            this.btn_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DN.Location = new System.Drawing.Point(102, 178);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(91, 27);
            this.btn_DN.TabIndex = 14;
            this.btn_DN.Text = "Đăng Nhập";
            this.btn_DN.UseVisualStyleBackColor = true;
            this.btn_DN.Click += new System.EventHandler(this.btn_DN_Click);
            // 
            // cb_HienthiPass
            // 
            this.cb_HienthiPass.AutoSize = true;
            this.cb_HienthiPass.Location = new System.Drawing.Point(149, 136);
            this.cb_HienthiPass.Name = "cb_HienthiPass";
            this.cb_HienthiPass.Size = new System.Drawing.Size(15, 14);
            this.cb_HienthiPass.TabIndex = 13;
            this.cb_HienthiPass.UseVisualStyleBackColor = true;
            this.cb_HienthiPass.CheckedChanged += new System.EventHandler(this.cb_HienthiPass_CheckedChanged);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(169, 134);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(176, 20);
            this.txt_Pass.TabIndex = 12;
            this.txt_Pass.UseSystemPasswordChar = true;
            // 
            // txt_UseName
            // 
            this.txt_UseName.Location = new System.Drawing.Point(169, 92);
            this.txt_UseName.Name = "txt_UseName";
            this.txt_UseName.Size = new System.Drawing.Size(176, 20);
            this.txt_UseName.TabIndex = 11;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Title.Location = new System.Drawing.Point(97, 51);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(229, 25);
            this.lbl_Title.TabIndex = 10;
            this.lbl_Title.Text = "Thông tin đăng nhập";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(87, 137);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(56, 13);
            this.lbl_Pass.TabIndex = 9;
            this.lbl_Pass.Text = "PassWord";
            // 
            // lbl_UseName
            // 
            this.lbl_UseName.AutoSize = true;
            this.lbl_UseName.Location = new System.Drawing.Point(87, 95);
            this.lbl_UseName.Name = "lbl_UseName";
            this.lbl_UseName.Size = new System.Drawing.Size(57, 13);
            this.lbl_UseName.TabIndex = 8;
            this.lbl_UseName.Text = "Use Name";
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 261);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DN);
            this.Controls.Add(this.cb_HienthiPass);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_UseName);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_UseName);
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_DN;
        private System.Windows.Forms.CheckBox cb_HienthiPass;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_UseName;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_UseName;
    }
}