namespace UseControl
{
    partial class ConTrol_DN
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
            this.lbl_UseName = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txt_UseName = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.cb_HienthiPass = new System.Windows.Forms.CheckBox();
            this.btn_DN = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_UseName
            // 
            this.lbl_UseName.AutoSize = true;
            this.lbl_UseName.Location = new System.Drawing.Point(36, 59);
            this.lbl_UseName.Name = "lbl_UseName";
            this.lbl_UseName.Size = new System.Drawing.Size(57, 13);
            this.lbl_UseName.TabIndex = 0;
            this.lbl_UseName.Text = "Use Name";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(36, 101);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(56, 13);
            this.lbl_Pass.TabIndex = 1;
            this.lbl_Pass.Text = "PassWord";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Title.Location = new System.Drawing.Point(46, 15);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(229, 25);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Thông tin đăng nhập";
            // 
            // txt_UseName
            // 
            this.txt_UseName.Location = new System.Drawing.Point(118, 56);
            this.txt_UseName.Name = "txt_UseName";
            this.txt_UseName.Size = new System.Drawing.Size(176, 20);
            this.txt_UseName.TabIndex = 3;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(118, 98);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(176, 20);
            this.txt_Pass.TabIndex = 4;
            // 
            // cb_HienthiPass
            // 
            this.cb_HienthiPass.AutoSize = true;
            this.cb_HienthiPass.Location = new System.Drawing.Point(98, 100);
            this.cb_HienthiPass.Name = "cb_HienthiPass";
            this.cb_HienthiPass.Size = new System.Drawing.Size(15, 14);
            this.cb_HienthiPass.TabIndex = 5;
            this.cb_HienthiPass.UseVisualStyleBackColor = true;
            // 
            // btn_DN
            // 
            this.btn_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DN.Location = new System.Drawing.Point(51, 124);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(91, 27);
            this.btn_DN.TabIndex = 6;
            this.btn_DN.Text = "Đăng Nhập";
            this.btn_DN.UseVisualStyleBackColor = true;
            this.btn_DN.Click += new System.EventHandler(this.btn_DN_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(219, 124);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(91, 27);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // ConTrol_DN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DN);
            this.Controls.Add(this.cb_HienthiPass);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_UseName);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_UseName);
            this.Name = "ConTrol_DN";
            this.Size = new System.Drawing.Size(345, 166);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UseName;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txt_UseName;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.CheckBox cb_HienthiPass;
        private System.Windows.Forms.Button btn_DN;
        private System.Windows.Forms.Button btn_Thoat;
    }
}
