using ShopQuanAo.DAL;

namespace ShopQuanAo
{
    partial class NhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label tENNVLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label gIOITINHLabel;
            System.Windows.Forms.Label uSERNAMELabel;
            System.Windows.Forms.Label pASSLabel;
            System.Windows.Forms.Label cHUCVULabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Them = new System.Windows.Forms.ToolStripButton();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_CapNhat = new System.Windows.Forms.ToolStripButton();
            this.btn_HoanTac = new System.Windows.Forms.ToolStripButton();
            this.btn_LuuDaTa = new System.Windows.Forms.ToolStripButton();
            this.nHANVIENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ShopQuanAo.DAL.DataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cHUCVUComboBox = new System.Windows.Forms.ComboBox();
            this.cHUCVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rdb_Nu = new System.Windows.Forms.RadioButton();
            this.rdb_Nam = new System.Windows.Forms.RadioButton();
            this.btn_openfile = new System.Windows.Forms.Button();
            this.ptx_HinhAnh = new System.Windows.Forms.PictureBox();
            this.mANVTextBox = new System.Windows.Forms.TextBox();
            this.tENNVTextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.uSERNAMETextBox = new System.Windows.Forms.TextBox();
            this.pASSTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.cHUCVUTableAdapter = new ShopQuanAo.DAL.DataSet1TableAdapters.CHUCVUTableAdapter();
            this.nHANVIENTableAdapter = new ShopQuanAo.DAL.DataSet1TableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new ShopQuanAo.DAL.DataSet1TableAdapters.TableAdapterManager();
            mANVLabel = new System.Windows.Forms.Label();
            tENNVLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            gIOITINHLabel = new System.Windows.Forms.Label();
            uSERNAMELabel = new System.Windows.Forms.Label();
            pASSLabel = new System.Windows.Forms.Label();
            cHUCVULabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptx_HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(160, 54);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(95, 16);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã Nhân Viên:";
            // 
            // tENNVLabel
            // 
            tENNVLabel.AutoSize = true;
            tENNVLabel.Location = new System.Drawing.Point(160, 83);
            tENNVLabel.Name = "tENNVLabel";
            tENNVLabel.Size = new System.Drawing.Size(100, 16);
            tENNVLabel.TabIndex = 2;
            tENNVLabel.Text = "Tên Nhân Viên:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(160, 112);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(96, 16);
            sDTLabel.TabIndex = 6;
            sDTLabel.Text = "Số Điện Thoại:";
            // 
            // gIOITINHLabel
            // 
            gIOITINHLabel.AutoSize = true;
            gIOITINHLabel.Location = new System.Drawing.Point(516, 25);
            gIOITINHLabel.Name = "gIOITINHLabel";
            gIOITINHLabel.Size = new System.Drawing.Size(64, 16);
            gIOITINHLabel.TabIndex = 8;
            gIOITINHLabel.Text = "Giới Tính:";
            // 
            // uSERNAMELabel
            // 
            uSERNAMELabel.AutoSize = true;
            uSERNAMELabel.Location = new System.Drawing.Point(516, 54);
            uSERNAMELabel.Name = "uSERNAMELabel";
            uSERNAMELabel.Size = new System.Drawing.Size(106, 16);
            uSERNAMELabel.TabIndex = 10;
            uSERNAMELabel.Text = "Tên Đăng Nhập:";
            // 
            // pASSLabel
            // 
            pASSLabel.AutoSize = true;
            pASSLabel.Location = new System.Drawing.Point(516, 83);
            pASSLabel.Name = "pASSLabel";
            pASSLabel.Size = new System.Drawing.Size(69, 16);
            pASSLabel.TabIndex = 12;
            pASSLabel.Text = "Mật Khẩu :";
            // 
            // cHUCVULabel
            // 
            cHUCVULabel.AutoSize = true;
            cHUCVULabel.Location = new System.Drawing.Point(160, 25);
            cHUCVULabel.Name = "cHUCVULabel";
            cHUCVULabel.Size = new System.Drawing.Size(60, 16);
            cHUCVULabel.TabIndex = 14;
            cHUCVULabel.Text = "Chức Vụ:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 609);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.nHANVIENDataGridView);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin tài khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Them,
            this.btn_Xoa,
            this.btn_CapNhat,
            this.btn_HoanTac,
            this.btn_LuuDaTa});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(879, 43);
            this.toolStrip1.TabIndex = 23;
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
            // nHANVIENDataGridView
            // 
            this.nHANVIENDataGridView.AllowUserToAddRows = false;
            this.nHANVIENDataGridView.AllowUserToDeleteRows = false;
            this.nHANVIENDataGridView.AutoGenerateColumns = false;
            this.nHANVIENDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nHANVIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nHANVIENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.nHANVIENDataGridView.DataSource = this.nHANVIENBindingSource;
            this.nHANVIENDataGridView.Location = new System.Drawing.Point(12, 275);
            this.nHANVIENDataGridView.Name = "nHANVIENDataGridView";
            this.nHANVIENDataGridView.ReadOnly = true;
            this.nHANVIENDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nHANVIENDataGridView.Size = new System.Drawing.Size(858, 288);
            this.nHANVIENDataGridView.TabIndex = 22;
            this.nHANVIENDataGridView.SelectionChanged += new System.EventHandler(this.nHANVIENDataGridView_SelectionChanged_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Nhân Viên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENNV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Nhân Viên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HINHANH";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hình Ảnh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số Điện Thoại";
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
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "USERNAME";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tên Đăng Nhập";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PASS";
            this.dataGridViewTextBoxColumn7.HeaderText = "PASS";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CHUCVU";
            this.dataGridViewTextBoxColumn8.HeaderText = "CHUCVU";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cHUCVUComboBox);
            this.groupBox1.Controls.Add(this.rdb_Nu);
            this.groupBox1.Controls.Add(this.rdb_Nam);
            this.groupBox1.Controls.Add(this.btn_openfile);
            this.groupBox1.Controls.Add(this.ptx_HinhAnh);
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Controls.Add(this.mANVTextBox);
            this.groupBox1.Controls.Add(tENNVLabel);
            this.groupBox1.Controls.Add(this.tENNVTextBox);
            this.groupBox1.Controls.Add(sDTLabel);
            this.groupBox1.Controls.Add(this.sDTTextBox);
            this.groupBox1.Controls.Add(gIOITINHLabel);
            this.groupBox1.Controls.Add(uSERNAMELabel);
            this.groupBox1.Controls.Add(this.uSERNAMETextBox);
            this.groupBox1.Controls.Add(pASSLabel);
            this.groupBox1.Controls.Add(this.pASSTextBox);
            this.groupBox1.Controls.Add(cHUCVULabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 207);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // cHUCVUComboBox
            // 
            this.cHUCVUComboBox.DataSource = this.cHUCVUBindingSource;
            this.cHUCVUComboBox.DisplayMember = "TENCV";
            this.cHUCVUComboBox.FormattingEnabled = true;
            this.cHUCVUComboBox.Location = new System.Drawing.Point(285, 21);
            this.cHUCVUComboBox.Name = "cHUCVUComboBox";
            this.cHUCVUComboBox.Size = new System.Drawing.Size(190, 24);
            this.cHUCVUComboBox.TabIndex = 19;
            this.cHUCVUComboBox.ValueMember = "MACV";
            // 
            // cHUCVUBindingSource
            // 
            this.cHUCVUBindingSource.DataMember = "CHUCVU";
            this.cHUCVUBindingSource.DataSource = this.dataSet1;
            // 
            // rdb_Nu
            // 
            this.rdb_Nu.AutoSize = true;
            this.rdb_Nu.Location = new System.Drawing.Point(787, 23);
            this.rdb_Nu.Name = "rdb_Nu";
            this.rdb_Nu.Size = new System.Drawing.Size(43, 20);
            this.rdb_Nu.TabIndex = 19;
            this.rdb_Nu.TabStop = true;
            this.rdb_Nu.Text = "Nữ";
            this.rdb_Nu.UseVisualStyleBackColor = true;
            // 
            // rdb_Nam
            // 
            this.rdb_Nam.AutoSize = true;
            this.rdb_Nam.Location = new System.Drawing.Point(654, 22);
            this.rdb_Nam.Name = "rdb_Nam";
            this.rdb_Nam.Size = new System.Drawing.Size(55, 20);
            this.rdb_Nam.TabIndex = 18;
            this.rdb_Nam.TabStop = true;
            this.rdb_Nam.Text = "Nam";
            this.rdb_Nam.UseVisualStyleBackColor = true;
            // 
            // btn_openfile
            // 
            this.btn_openfile.Location = new System.Drawing.Point(30, 161);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(75, 23);
            this.btn_openfile.TabIndex = 17;
            this.btn_openfile.Text = "Open";
            this.btn_openfile.UseVisualStyleBackColor = true;
            this.btn_openfile.Click += new System.EventHandler(this.btn_openfile_Click);
            // 
            // ptx_HinhAnh
            // 
            this.ptx_HinhAnh.Location = new System.Drawing.Point(15, 30);
            this.ptx_HinhAnh.Name = "ptx_HinhAnh";
            this.ptx_HinhAnh.Size = new System.Drawing.Size(113, 125);
            this.ptx_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptx_HinhAnh.TabIndex = 16;
            this.ptx_HinhAnh.TabStop = false;
            // 
            // mANVTextBox
            // 
            this.mANVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "MANV", true));
            this.mANVTextBox.Location = new System.Drawing.Point(287, 51);
            this.mANVTextBox.Name = "mANVTextBox";
            this.mANVTextBox.Size = new System.Drawing.Size(188, 22);
            this.mANVTextBox.TabIndex = 1;
            // 
            // tENNVTextBox
            // 
            this.tENNVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "TENNV", true));
            this.tENNVTextBox.Location = new System.Drawing.Point(287, 80);
            this.tENNVTextBox.Name = "tENNVTextBox";
            this.tENNVTextBox.Size = new System.Drawing.Size(188, 22);
            this.tENNVTextBox.TabIndex = 3;
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(287, 109);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(188, 22);
            this.sDTTextBox.TabIndex = 7;
            // 
            // uSERNAMETextBox
            // 
            this.uSERNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "USERNAME", true));
            this.uSERNAMETextBox.Location = new System.Drawing.Point(654, 51);
            this.uSERNAMETextBox.Name = "uSERNAMETextBox";
            this.uSERNAMETextBox.Size = new System.Drawing.Size(188, 22);
            this.uSERNAMETextBox.TabIndex = 11;
            // 
            // pASSTextBox
            // 
            this.pASSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "PASS", true));
            this.pASSTextBox.Location = new System.Drawing.Point(654, 80);
            this.pASSTextBox.Name = "pASSTextBox";
            this.pASSTextBox.Size = new System.Drawing.Size(188, 22);
            this.pASSTextBox.TabIndex = 13;
            this.pASSTextBox.UseSystemPasswordChar = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(885, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bảng Lương Nhân Viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // cHUCVUTableAdapter
            // 
            this.cHUCVUTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.LOAITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.NHAPHANGTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShopQuanAo.DAL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VANTAYTableAdapter = null;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 609);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Name = "NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptx_HinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Them;
        private System.Windows.Forms.ToolStripButton btn_Xoa;
        private System.Windows.Forms.ToolStripButton btn_CapNhat;
        private System.Windows.Forms.ToolStripButton btn_HoanTac;
        private System.Windows.Forms.ToolStripButton btn_LuuDaTa;
        private System.Windows.Forms.DataGridView nHANVIENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cHUCVUComboBox;
        private System.Windows.Forms.BindingSource cHUCVUBindingSource;
        private System.Windows.Forms.RadioButton rdb_Nu;
        private System.Windows.Forms.RadioButton rdb_Nam;
        private System.Windows.Forms.Button btn_openfile;
        private System.Windows.Forms.PictureBox ptx_HinhAnh;
        private System.Windows.Forms.TextBox mANVTextBox;
        private System.Windows.Forms.TextBox tENNVTextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox uSERNAMETextBox;
        private System.Windows.Forms.TextBox pASSTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFile;
        private DAL.DataSet1TableAdapters.CHUCVUTableAdapter cHUCVUTableAdapter;
        private DAL.DataSet1TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private DAL.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
    }
}