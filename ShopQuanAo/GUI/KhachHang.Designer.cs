using ShopQuanAo.DAL;

namespace ShopQuanAo
{
    partial class KhachHang
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label gIOITINHLabel;
            System.Windows.Forms.Label pASSLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.dataSet1 = new ShopQuanAo.DAL.DataSet1();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new ShopQuanAo.DAL.DataSet1TableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new ShopQuanAo.DAL.DataSet1TableAdapters.TableAdapterManager();
            this.kHACHHANGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mAKHTextBox = new System.Windows.Forms.TextBox();
            this.tENKHTextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.pASSTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Them = new System.Windows.Forms.ToolStripButton();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_CapNhat = new System.Windows.Forms.ToolStripButton();
            this.btn_HoanTac = new System.Windows.Forms.ToolStripButton();
            this.btn_LuuDaTa = new System.Windows.Forms.ToolStripButton();
            this.rdb_Nam = new System.Windows.Forms.RadioButton();
            this.rdb_Nu = new System.Windows.Forms.RadioButton();
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            gIOITINHLabel = new System.Windows.Forms.Label();
            pASSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.dataSet1;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGCHAMCONGTableAdapter = null;
            this.tableAdapterManager.CHUCVUTableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_NGAYLAMTableAdapter = null;
            this.tableAdapterManager.CT_NHAPHANGTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
            this.tableAdapterManager.LOAITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAPHANGTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShopQuanAo.DAL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VANTAYTableAdapter = null;
            // 
            // kHACHHANGDataGridView
            // 
            this.kHACHHANGDataGridView.AllowUserToAddRows = false;
            this.kHACHHANGDataGridView.AutoGenerateColumns = false;
            this.kHACHHANGDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kHACHHANGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kHACHHANGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.kHACHHANGDataGridView.DataSource = this.kHACHHANGBindingSource;
            this.kHACHHANGDataGridView.Location = new System.Drawing.Point(12, 284);
            this.kHACHHANGDataGridView.Name = "kHACHHANGDataGridView";
            this.kHACHHANGDataGridView.ReadOnly = true;
            this.kHACHHANGDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kHACHHANGDataGridView.Size = new System.Drawing.Size(924, 268);
            this.kHACHHANGDataGridView.TabIndex = 1;
            this.kHACHHANGDataGridView.SelectionChanged += new System.EventHandler(this.kHACHHANGDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Khách Hàng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Khách Hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số Điện Thoại";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn4.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GIOITINH";
            this.dataGridViewTextBoxColumn5.HeaderText = "Giới Tính";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PASS";
            this.dataGridViewTextBoxColumn7.HeaderText = "PASS";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_Nu);
            this.groupBox1.Controls.Add(this.rdb_Nam);
            this.groupBox1.Controls.Add(mAKHLabel);
            this.groupBox1.Controls.Add(this.mAKHTextBox);
            this.groupBox1.Controls.Add(tENKHLabel);
            this.groupBox1.Controls.Add(this.tENKHTextBox);
            this.groupBox1.Controls.Add(sDTLabel);
            this.groupBox1.Controls.Add(this.sDTTextBox);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.dIACHITextBox);
            this.groupBox1.Controls.Add(gIOITINHLabel);
            this.groupBox1.Controls.Add(pASSLabel);
            this.groupBox1.Controls.Add(this.pASSTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tài Khoản";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(21, 34);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(88, 13);
            mAKHLabel.TabIndex = 0;
            mAKHLabel.Text = "Mã Khách Hàng:";
            // 
            // mAKHTextBox
            // 
            this.mAKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "MAKH", true));
            this.mAKHTextBox.Location = new System.Drawing.Point(133, 31);
            this.mAKHTextBox.Name = "mAKHTextBox";
            this.mAKHTextBox.Size = new System.Drawing.Size(223, 20);
            this.mAKHTextBox.TabIndex = 1;
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(21, 60);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(92, 13);
            tENKHLabel.TabIndex = 2;
            tENKHLabel.Text = "Tên Khách Hàng:";
            // 
            // tENKHTextBox
            // 
            this.tENKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "TENKH", true));
            this.tENKHTextBox.Location = new System.Drawing.Point(133, 57);
            this.tENKHTextBox.Name = "tENKHTextBox";
            this.tENKHTextBox.Size = new System.Drawing.Size(223, 20);
            this.tENKHTextBox.TabIndex = 3;
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(21, 86);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(78, 13);
            sDTLabel.TabIndex = 4;
            sDTLabel.Text = "Số Điện Thoại:";
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(133, 83);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(223, 20);
            this.sDTTextBox.TabIndex = 5;
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(532, 34);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(44, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa Chỉ:";
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "DIACHI", true));
            this.dIACHITextBox.Location = new System.Drawing.Point(630, 31);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(245, 20);
            this.dIACHITextBox.TabIndex = 7;
            // 
            // gIOITINHLabel
            // 
            gIOITINHLabel.AutoSize = true;
            gIOITINHLabel.Location = new System.Drawing.Point(532, 60);
            gIOITINHLabel.Name = "gIOITINHLabel";
            gIOITINHLabel.Size = new System.Drawing.Size(54, 13);
            gIOITINHLabel.TabIndex = 8;
            gIOITINHLabel.Text = "Giới Tính:";
            // 
            // pASSLabel
            // 
            pASSLabel.AutoSize = true;
            pASSLabel.Location = new System.Drawing.Point(532, 86);
            pASSLabel.Name = "pASSLabel";
            pASSLabel.Size = new System.Drawing.Size(56, 13);
            pASSLabel.TabIndex = 10;
            pASSLabel.Text = "Mật Khẩu:";
            // 
            // pASSTextBox
            // 
            this.pASSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "PASS", true));
            this.pASSTextBox.Location = new System.Drawing.Point(630, 83);
            this.pASSTextBox.Name = "pASSTextBox";
            this.pASSTextBox.Size = new System.Drawing.Size(245, 20);
            this.pASSTextBox.TabIndex = 11;
            this.pASSTextBox.UseSystemPasswordChar = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Them,
            this.btn_Xoa,
            this.btn_CapNhat,
            this.btn_HoanTac,
            this.btn_LuuDaTa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(948, 43);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Them
            // 
            this.btn_Them.AutoSize = false;
            this.btn_Them.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 40);
            this.btn_Them.Text = "Thêm";
            this.btn_Them.ToolTipText = "Thêm tài khoản";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AutoSize = false;
            this.btn_Xoa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 40);
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.ToolTipText = "Xóa tài khoản";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.AutoSize = false;
            this.btn_CapNhat.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_CapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(140, 40);
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.ToolTipText = "Cập Nhật thông tin  tài khoản";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_HoanTac
            // 
            this.btn_HoanTac.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoanTac.Image = global::ShopQuanAo.Properties.Resources.arrow_undo_icon;
            this.btn_HoanTac.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_HoanTac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_HoanTac.Name = "btn_HoanTac";
            this.btn_HoanTac.Size = new System.Drawing.Size(134, 40);
            this.btn_HoanTac.Text = "Hoàn Tác";
            this.btn_HoanTac.ToolTipText = "Về Trạng Thái Cũ";
            this.btn_HoanTac.Click += new System.EventHandler(this.btn_HoanTac_Click);
            // 
            // btn_LuuDaTa
            // 
            this.btn_LuuDaTa.AutoSize = false;
            this.btn_LuuDaTa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuDaTa.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuDaTa.Image")));
            this.btn_LuuDaTa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_LuuDaTa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_LuuDaTa.Name = "btn_LuuDaTa";
            this.btn_LuuDaTa.Size = new System.Drawing.Size(100, 40);
            this.btn_LuuDaTa.Text = "Lưu";
            this.btn_LuuDaTa.ToolTipText = "Lưu tất cả thông tin đã chỉnh sữa vào DataBase";
            this.btn_LuuDaTa.Click += new System.EventHandler(this.btn_LuuDaTa_Click);
            // 
            // rdb_Nam
            // 
            this.rdb_Nam.AutoSize = true;
            this.rdb_Nam.Location = new System.Drawing.Point(630, 58);
            this.rdb_Nam.Name = "rdb_Nam";
            this.rdb_Nam.Size = new System.Drawing.Size(47, 17);
            this.rdb_Nam.TabIndex = 12;
            this.rdb_Nam.TabStop = true;
            this.rdb_Nam.Text = "Nam";
            this.rdb_Nam.UseVisualStyleBackColor = true;
            // 
            // rdb_Nu
            // 
            this.rdb_Nu.AutoSize = true;
            this.rdb_Nu.Location = new System.Drawing.Point(785, 58);
            this.rdb_Nu.Name = "rdb_Nu";
            this.rdb_Nu.Size = new System.Drawing.Size(39, 17);
            this.rdb_Nu.TabIndex = 13;
            this.rdb_Nu.TabStop = true;
            this.rdb_Nu.Text = "Nữ";
            this.rdb_Nu.UseVisualStyleBackColor = true;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 564);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kHACHHANGDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private DAL.DataSet1TableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private DAL.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView kHACHHANGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mAKHTextBox;
        private System.Windows.Forms.TextBox tENKHTextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private System.Windows.Forms.TextBox pASSTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Them;
        private System.Windows.Forms.ToolStripButton btn_Xoa;
        private System.Windows.Forms.ToolStripButton btn_CapNhat;
        private System.Windows.Forms.ToolStripButton btn_HoanTac;
        private System.Windows.Forms.ToolStripButton btn_LuuDaTa;
        private System.Windows.Forms.RadioButton rdb_Nu;
        private System.Windows.Forms.RadioButton rdb_Nam;
    }
}