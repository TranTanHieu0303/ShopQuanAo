
using ShopQuanAo.DAL;

namespace ShopQuanAo
{
    partial class SanPham
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
            System.Windows.Forms.Label mASPLabel;
            System.Windows.Forms.Label tENSPLabel;
            System.Windows.Forms.Label mOTALabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label tRANGTHAILabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label mALOAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.dataSet1 = new ShopQuanAo.DAL.DataSet1();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANPHAMTableAdapter = new ShopQuanAo.DAL.DataSet1TableAdapters.SANPHAMTableAdapter();
            this.tableAdapterManager = new ShopQuanAo.DAL.DataSet1TableAdapters.TableAdapterManager();
            this.sANPHAMDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lOAIComboBox = new System.Windows.Forms.ComboBox();
            this.lOAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_openfile = new System.Windows.Forms.Button();
            this.ptb_hinhanhNV = new System.Windows.Forms.PictureBox();
            this.mASPTextBox = new System.Windows.Forms.TextBox();
            this.tENSPTextBox = new System.Windows.Forms.TextBox();
            this.mOTATextBox = new System.Windows.Forms.TextBox();
            this.dONGIATextBox = new System.Windows.Forms.TextBox();
            this.tRANGTHAITextBox = new System.Windows.Forms.TextBox();
            this.sOLUONGTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Them = new System.Windows.Forms.ToolStripButton();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_CapNhat = new System.Windows.Forms.ToolStripButton();
            this.btn_HoanTac = new System.Windows.Forms.ToolStripButton();
            this.btn_LuuDaTa = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lOAITableAdapter = new ShopQuanAo.DAL.DataSet1TableAdapters.LOAITableAdapter();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            mASPLabel = new System.Windows.Forms.Label();
            tENSPLabel = new System.Windows.Forms.Label();
            mOTALabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            tRANGTHAILabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            mALOAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hinhanhNV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mASPLabel
            // 
            mASPLabel.AutoSize = true;
            mASPLabel.Location = new System.Drawing.Point(131, 67);
            mASPLabel.Name = "mASPLabel";
            mASPLabel.Size = new System.Drawing.Size(89, 15);
            mASPLabel.TabIndex = 0;
            mASPLabel.Text = "Mã Sản Phẩm:";
            mASPLabel.Click += new System.EventHandler(this.mASPLabel_Click);
            // 
            // tENSPLabel
            // 
            tENSPLabel.AutoSize = true;
            tENSPLabel.Location = new System.Drawing.Point(131, 93);
            tENSPLabel.Name = "tENSPLabel";
            tENSPLabel.Size = new System.Drawing.Size(92, 15);
            tENSPLabel.TabIndex = 2;
            tENSPLabel.Text = "Tên Sản Phẩm:";
            tENSPLabel.Click += new System.EventHandler(this.tENSPLabel_Click);
            // 
            // mOTALabel
            // 
            mOTALabel.AutoSize = true;
            mOTALabel.Location = new System.Drawing.Point(489, 93);
            mOTALabel.Name = "mOTALabel";
            mOTALabel.Size = new System.Drawing.Size(45, 15);
            mOTALabel.TabIndex = 6;
            mOTALabel.Text = "Mô Tả:";
            mOTALabel.Click += new System.EventHandler(this.mOTALabel_Click);
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(131, 119);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(55, 15);
            dONGIALabel.TabIndex = 8;
            dONGIALabel.Text = "Đơn Giá:";
            dONGIALabel.Click += new System.EventHandler(this.dONGIALabel_Click);
            // 
            // tRANGTHAILabel
            // 
            tRANGTHAILabel.AutoSize = true;
            tRANGTHAILabel.Location = new System.Drawing.Point(489, 38);
            tRANGTHAILabel.Name = "tRANGTHAILabel";
            tRANGTHAILabel.Size = new System.Drawing.Size(69, 15);
            tRANGTHAILabel.TabIndex = 10;
            tRANGTHAILabel.Text = "Trạng Thái:";
            tRANGTHAILabel.Click += new System.EventHandler(this.tRANGTHAILabel_Click);
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(489, 67);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(63, 15);
            sOLUONGLabel.TabIndex = 12;
            sOLUONGLabel.Text = "Số Lượng:";
            sOLUONGLabel.Click += new System.EventHandler(this.sOLUONGLabel_Click);
            // 
            // mALOAILabel
            // 
            mALOAILabel.AutoSize = true;
            mALOAILabel.Location = new System.Drawing.Point(131, 38);
            mALOAILabel.Name = "mALOAILabel";
            mALOAILabel.Size = new System.Drawing.Size(95, 15);
            mALOAILabel.TabIndex = 14;
            mALOAILabel.Text = "Loại Sản Phẩm:";
            mALOAILabel.Click += new System.EventHandler(this.mALOAILabel_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.dataSet1;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAPHANGTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = this.sANPHAMTableAdapter;
            this.tableAdapterManager.UpdateOrder = ShopQuanAo.DAL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VANTAYTableAdapter = null;
            // 
            // sANPHAMDataGridView
            // 
            this.sANPHAMDataGridView.AllowUserToDeleteRows = false;
            this.sANPHAMDataGridView.AutoGenerateColumns = false;
            this.sANPHAMDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sANPHAMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sANPHAMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.sANPHAMDataGridView.DataSource = this.sANPHAMBindingSource;
            this.sANPHAMDataGridView.Location = new System.Drawing.Point(12, 286);
            this.sANPHAMDataGridView.Name = "sANPHAMDataGridView";
            this.sANPHAMDataGridView.ReadOnly = true;
            this.sANPHAMDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sANPHAMDataGridView.Size = new System.Drawing.Size(872, 270);
            this.sANPHAMDataGridView.TabIndex = 1;
            this.sANPHAMDataGridView.SelectionChanged += new System.EventHandler(this.sANPHAMDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Sản Phẩm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENSP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Sản Phẩm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HINHANH";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hình Ảnh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MOTA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mô Tả";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn5.HeaderText = "Đơn Giá";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TRANGTHAI";
            this.dataGridViewTextBoxColumn6.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn7.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MALOAI";
            this.dataGridViewTextBoxColumn8.HeaderText = "Mã Loại";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lOAIComboBox);
            this.groupBox1.Controls.Add(this.btn_openfile);
            this.groupBox1.Controls.Add(this.ptb_hinhanhNV);
            this.groupBox1.Controls.Add(mASPLabel);
            this.groupBox1.Controls.Add(this.mASPTextBox);
            this.groupBox1.Controls.Add(tENSPLabel);
            this.groupBox1.Controls.Add(this.tENSPTextBox);
            this.groupBox1.Controls.Add(mOTALabel);
            this.groupBox1.Controls.Add(this.mOTATextBox);
            this.groupBox1.Controls.Add(dONGIALabel);
            this.groupBox1.Controls.Add(this.dONGIATextBox);
            this.groupBox1.Controls.Add(tRANGTHAILabel);
            this.groupBox1.Controls.Add(this.tRANGTHAITextBox);
            this.groupBox1.Controls.Add(sOLUONGLabel);
            this.groupBox1.Controls.Add(this.sOLUONGTextBox);
            this.groupBox1.Controls.Add(mALOAILabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 205);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Sản Phẩm";
            // 
            // lOAIComboBox
            // 
            this.lOAIComboBox.DataSource = this.lOAIBindingSource;
            this.lOAIComboBox.DisplayMember = "TENLOAI";
            this.lOAIComboBox.FormattingEnabled = true;
            this.lOAIComboBox.Location = new System.Drawing.Point(232, 35);
            this.lOAIComboBox.Name = "lOAIComboBox";
            this.lOAIComboBox.Size = new System.Drawing.Size(222, 23);
            this.lOAIComboBox.TabIndex = 17;
            this.lOAIComboBox.ValueMember = "MALOAI";
            // 
            // lOAIBindingSource
            // 
            this.lOAIBindingSource.DataMember = "LOAI";
            this.lOAIBindingSource.DataSource = this.dataSet1;
            // 
            // btn_openfile
            // 
            this.btn_openfile.Location = new System.Drawing.Point(16, 169);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(75, 23);
            this.btn_openfile.TabIndex = 17;
            this.btn_openfile.Text = "Open File";
            this.btn_openfile.UseVisualStyleBackColor = true;
            this.btn_openfile.Click += new System.EventHandler(this.btn_openfile_Click);
            // 
            // ptb_hinhanhNV
            // 
            this.ptb_hinhanhNV.Location = new System.Drawing.Point(6, 30);
            this.ptb_hinhanhNV.Name = "ptb_hinhanhNV";
            this.ptb_hinhanhNV.Size = new System.Drawing.Size(111, 133);
            this.ptb_hinhanhNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_hinhanhNV.TabIndex = 16;
            this.ptb_hinhanhNV.TabStop = false;
            // 
            // mASPTextBox
            // 
            this.mASPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "MASP", true));
            this.mASPTextBox.Location = new System.Drawing.Point(232, 64);
            this.mASPTextBox.Name = "mASPTextBox";
            this.mASPTextBox.Size = new System.Drawing.Size(222, 21);
            this.mASPTextBox.TabIndex = 1;
            this.mASPTextBox.TextChanged += new System.EventHandler(this.mASPTextBox_TextChanged);
            // 
            // tENSPTextBox
            // 
            this.tENSPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "TENSP", true));
            this.tENSPTextBox.Location = new System.Drawing.Point(232, 90);
            this.tENSPTextBox.Name = "tENSPTextBox";
            this.tENSPTextBox.Size = new System.Drawing.Size(222, 21);
            this.tENSPTextBox.TabIndex = 2;
            this.tENSPTextBox.TextChanged += new System.EventHandler(this.tENSPTextBox_TextChanged);
            // 
            // mOTATextBox
            // 
            this.mOTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "MOTA", true));
            this.mOTATextBox.Location = new System.Drawing.Point(582, 90);
            this.mOTATextBox.Multiline = true;
            this.mOTATextBox.Name = "mOTATextBox";
            this.mOTATextBox.Size = new System.Drawing.Size(258, 46);
            this.mOTATextBox.TabIndex = 6;
            this.mOTATextBox.TextChanged += new System.EventHandler(this.mOTATextBox_TextChanged);
            // 
            // dONGIATextBox
            // 
            this.dONGIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "DONGIA", true));
            this.dONGIATextBox.Location = new System.Drawing.Point(232, 116);
            this.dONGIATextBox.Name = "dONGIATextBox";
            this.dONGIATextBox.Size = new System.Drawing.Size(222, 21);
            this.dONGIATextBox.TabIndex = 3;
            this.dONGIATextBox.TextChanged += new System.EventHandler(this.dONGIATextBox_TextChanged);
            // 
            // tRANGTHAITextBox
            // 
            this.tRANGTHAITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "TRANGTHAI", true));
            this.tRANGTHAITextBox.Location = new System.Drawing.Point(582, 35);
            this.tRANGTHAITextBox.Name = "tRANGTHAITextBox";
            this.tRANGTHAITextBox.Size = new System.Drawing.Size(258, 21);
            this.tRANGTHAITextBox.TabIndex = 4;
            this.tRANGTHAITextBox.TextChanged += new System.EventHandler(this.tRANGTHAITextBox_TextChanged);
            // 
            // sOLUONGTextBox
            // 
            this.sOLUONGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "SOLUONG", true));
            this.sOLUONGTextBox.Location = new System.Drawing.Point(582, 64);
            this.sOLUONGTextBox.Name = "sOLUONGTextBox";
            this.sOLUONGTextBox.Size = new System.Drawing.Size(258, 21);
            this.sOLUONGTextBox.TabIndex = 5;
            this.sOLUONGTextBox.TextChanged += new System.EventHandler(this.sOLUONGTextBox_TextChanged);
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
            this.toolStrip1.Size = new System.Drawing.Size(896, 43);
            this.toolStrip1.TabIndex = 19;
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
            // lOAITableAdapter
            // 
            this.lOAITableAdapter.ClearBeforeFill = true;
            // 
            // openfile
            // 
            this.openfile.FileName = "openFileDialog1";
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 568);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sANPHAMDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hinhanhNV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private DAL.DataSet1TableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private DAL.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sANPHAMDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mASPTextBox;
        private System.Windows.Forms.TextBox tENSPTextBox;
        private System.Windows.Forms.TextBox mOTATextBox;
        private System.Windows.Forms.TextBox dONGIATextBox;
        private System.Windows.Forms.TextBox tRANGTHAITextBox;
        private System.Windows.Forms.TextBox sOLUONGTextBox;
        private System.Windows.Forms.Button btn_openfile;
        private System.Windows.Forms.PictureBox ptb_hinhanhNV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Them;
        private System.Windows.Forms.ToolStripButton btn_Xoa;
        private System.Windows.Forms.ToolStripButton btn_CapNhat;
        private System.Windows.Forms.ToolStripButton btn_LuuDaTa;
        private System.Windows.Forms.ToolStripButton btn_HoanTac;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.BindingSource lOAIBindingSource;
        private DAL.DataSet1TableAdapters.LOAITableAdapter lOAITableAdapter;
        private System.Windows.Forms.ComboBox lOAIComboBox;
        private System.Windows.Forms.OpenFileDialog openfile;
    }
}