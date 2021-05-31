namespace ShopQuanAo
{
    partial class frm_ketnoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_KetNoi = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.cbb_ServerName = new System.Windows.Forms.ComboBox();
            this.cbb_Authentication = new System.Windows.Forms.ComboBox();
            this.txt_UerName = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(83, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết nối dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Authentication :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password :";
            // 
            // btn_KetNoi
            // 
            this.btn_KetNoi.Location = new System.Drawing.Point(30, 254);
            this.btn_KetNoi.Name = "btn_KetNoi";
            this.btn_KetNoi.Size = new System.Drawing.Size(85, 36);
            this.btn_KetNoi.TabIndex = 5;
            this.btn_KetNoi.Text = "Kết nối";
            this.btn_KetNoi.UseVisualStyleBackColor = true;
            this.btn_KetNoi.Click += new System.EventHandler(this.btn_KetNoi_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(191, 254);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(85, 36);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // cbb_ServerName
            // 
            this.cbb_ServerName.FormattingEnabled = true;
            this.cbb_ServerName.Location = new System.Drawing.Point(108, 84);
            this.cbb_ServerName.Name = "cbb_ServerName";
            this.cbb_ServerName.Size = new System.Drawing.Size(198, 21);
            this.cbb_ServerName.TabIndex = 7;
            this.cbb_ServerName.DropDown += new System.EventHandler(this.cbb_ServerName_DropDown);
            // 
            // cbb_Authentication
            // 
            this.cbb_Authentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Authentication.FormattingEnabled = true;
            this.cbb_Authentication.Location = new System.Drawing.Point(108, 121);
            this.cbb_Authentication.Name = "cbb_Authentication";
            this.cbb_Authentication.Size = new System.Drawing.Size(198, 21);
            this.cbb_Authentication.TabIndex = 8;
            this.cbb_Authentication.SelectedIndexChanged += new System.EventHandler(this.cbb_Authentication_SelectedIndexChanged);
            // 
            // txt_UerName
            // 
            this.txt_UerName.Location = new System.Drawing.Point(108, 153);
            this.txt_UerName.Name = "txt_UerName";
            this.txt_UerName.Size = new System.Drawing.Size(198, 20);
            this.txt_UerName.TabIndex = 9;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(108, 187);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(198, 20);
            this.txt_Pass.TabIndex = 10;
            // 
            // frm_ketnoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 320);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_UerName);
            this.Controls.Add(this.cbb_Authentication);
            this.Controls.Add(this.cbb_ServerName);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_KetNoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_ketnoi";
            this.Text = "Kết nối dữ liệu";
            this.Load += new System.EventHandler(this.frm_ketnoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_KetNoi;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ComboBox cbb_ServerName;
        private System.Windows.Forms.ComboBox cbb_Authentication;
        private System.Windows.Forms.TextBox txt_UerName;
        private System.Windows.Forms.TextBox txt_Pass;
    }
}