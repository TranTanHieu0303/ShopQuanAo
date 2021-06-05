using ShopQuanAo.DAL;

namespace ShopQuanAo
{
    partial class NhapHang
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
            System.Windows.Forms.Label dONGIALabel1;
            System.Windows.Forms.Label sOLUONGLabel1;
            System.Windows.Forms.Label tENSPLabel;
            System.Windows.Forms.Label mASPLabel;
            System.Windows.Forms.Label mANHAPLabel1;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label tHANHTIENLabel;
            System.Windows.Forms.Label mANHAPLabel;
            System.Windows.Forms.Label nGAYNHAPLabel;
            System.Windows.Forms.Label tONGTIENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapHang));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gr = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_tienchu = new System.Windows.Forms.Label();
            this.bnt_xuatphieunhap = new System.Windows.Forms.Button();
            this.lbl_tongtiennhap = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLP_timkiemsp = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.txt_GiaNhap = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_sl = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLP_hoadon = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nHAPHANGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHAPHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ShopQuanAo.DAL.DataSet1();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dONGIATextBox1 = new System.Windows.Forms.TextBox();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sOLUONGTextBox1 = new System.Windows.Forms.TextBox();
            this.tENSPTextBox = new System.Windows.Forms.TextBox();
            this.mASPTextBox = new System.Windows.Forms.TextBox();
            this.cT_NHAPHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mANHAPTextBox1 = new System.Windows.Forms.TextBox();
            this.sOLUONGTextBox = new System.Windows.Forms.TextBox();
            this.dONGIATextBox = new System.Windows.Forms.TextBox();
            this.tHANHTIENTextBox = new System.Windows.Forms.TextBox();
            this.cT_NHAPHANGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_CapNhat = new System.Windows.Forms.ToolStripButton();
            this.btn_inbangluong = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_timmanhap = new System.Windows.Forms.TextBox();
            this.mANHAPTextBox = new System.Windows.Forms.TextBox();
            this.nGAYNHAPDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tONGTIENTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.sANPHAMTableAdapter = new ShopQuanAo.DAL.DataSet1TableAdapters.SANPHAMTableAdapter();
            this.tableAdapterManager = new ShopQuanAo.DAL.DataSet1TableAdapters.TableAdapterManager();
            this.cT_NHAPHANGTableAdapter = new ShopQuanAo.DAL.DataSet1TableAdapters.CT_NHAPHANGTableAdapter();
            this.nHAPHANGTableAdapter = new ShopQuanAo.DAL.DataSet1TableAdapters.NHAPHANGTableAdapter();
            dONGIALabel1 = new System.Windows.Forms.Label();
            sOLUONGLabel1 = new System.Windows.Forms.Label();
            tENSPLabel = new System.Windows.Forms.Label();
            mASPLabel = new System.Windows.Forms.Label();
            mANHAPLabel1 = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            tHANHTIENLabel = new System.Windows.Forms.Label();
            mANHAPLabel = new System.Windows.Forms.Label();
            nGAYNHAPLabel = new System.Windows.Forms.Label();
            tONGTIENLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gr.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sl)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHAPHANGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAPHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_NHAPHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_NHAPHANGDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dONGIALabel1
            // 
            dONGIALabel1.AutoSize = true;
            dONGIALabel1.Location = new System.Drawing.Point(8, 107);
            dONGIALabel1.Name = "dONGIALabel1";
            dONGIALabel1.Size = new System.Drawing.Size(56, 13);
            dONGIALabel1.TabIndex = 6;
            dONGIALabel1.Text = "Giá Bán:";
            // 
            // sOLUONGLabel1
            // 
            sOLUONGLabel1.AutoSize = true;
            sOLUONGLabel1.Location = new System.Drawing.Point(8, 84);
            sOLUONGLabel1.Name = "sOLUONGLabel1";
            sOLUONGLabel1.Size = new System.Drawing.Size(51, 13);
            sOLUONGLabel1.TabIndex = 4;
            sOLUONGLabel1.Text = "SL còn:";
            // 
            // tENSPLabel
            // 
            tENSPLabel.AutoSize = true;
            tENSPLabel.Location = new System.Drawing.Point(8, 57);
            tENSPLabel.Name = "tENSPLabel";
            tENSPLabel.Size = new System.Drawing.Size(53, 13);
            tENSPLabel.TabIndex = 3;
            tENSPLabel.Text = "Tên SP:";
            // 
            // mASPLabel
            // 
            mASPLabel.AutoSize = true;
            mASPLabel.Location = new System.Drawing.Point(8, 25);
            mASPLabel.Name = "mASPLabel";
            mASPLabel.Size = new System.Drawing.Size(48, 13);
            mASPLabel.TabIndex = 2;
            mASPLabel.Text = "Mã SP:";
            // 
            // mANHAPLabel1
            // 
            mANHAPLabel1.AutoSize = true;
            mANHAPLabel1.Location = new System.Drawing.Point(13, 66);
            mANHAPLabel1.Name = "mANHAPLabel1";
            mANHAPLabel1.Size = new System.Drawing.Size(61, 13);
            mANHAPLabel1.TabIndex = 0;
            mANHAPLabel1.Text = "Mã Phập:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(13, 95);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(99, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "Số Lượng Nhập:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(13, 121);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(64, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Giá Nhập:";
            // 
            // tHANHTIENLabel
            // 
            tHANHTIENLabel.AutoSize = true;
            tHANHTIENLabel.Location = new System.Drawing.Point(13, 147);
            tHANHTIENLabel.Name = "tHANHTIENLabel";
            tHANHTIENLabel.Size = new System.Drawing.Size(76, 13);
            tHANHTIENLabel.TabIndex = 8;
            tHANHTIENLabel.Text = "Thành Tiền:";
            // 
            // mANHAPLabel
            // 
            mANHAPLabel.AutoSize = true;
            mANHAPLabel.Location = new System.Drawing.Point(28, 105);
            mANHAPLabel.Name = "mANHAPLabel";
            mANHAPLabel.Size = new System.Drawing.Size(62, 13);
            mANHAPLabel.TabIndex = 2;
            mANHAPLabel.Text = "Mã Nhập:";
            // 
            // nGAYNHAPLabel
            // 
            nGAYNHAPLabel.AutoSize = true;
            nGAYNHAPLabel.Location = new System.Drawing.Point(28, 134);
            nGAYNHAPLabel.Name = "nGAYNHAPLabel";
            nGAYNHAPLabel.Size = new System.Drawing.Size(74, 13);
            nGAYNHAPLabel.TabIndex = 4;
            nGAYNHAPLabel.Text = "Ngày Nhập:";
            // 
            // tONGTIENLabel
            // 
            tONGTIENLabel.AutoSize = true;
            tONGTIENLabel.Location = new System.Drawing.Point(28, 157);
            tONGTIENLabel.Name = "tONGTIENLabel";
            tONGTIENLabel.Size = new System.Drawing.Size(69, 13);
            tONGTIENLabel.TabIndex = 6;
            tONGTIENLabel.Text = "Tổng Tiền:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1177, 581);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1169, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhập Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1163, 549);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo Phiếu Phập Hàng Mới";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.22904F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.77096F));
            this.tableLayoutPanel2.Controls.Add(this.gr, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox6, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.33962F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.66038F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1157, 530);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // gr
            // 
            this.gr.Controls.Add(this.label4);
            this.gr.Controls.Add(this.label3);
            this.gr.Controls.Add(this.lbl_tienchu);
            this.gr.Controls.Add(this.bnt_xuatphieunhap);
            this.gr.Controls.Add(this.lbl_tongtiennhap);
            this.gr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr.Location = new System.Drawing.Point(641, 343);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(513, 184);
            this.gr.TabIndex = 8;
            this.gr.TabStop = false;
            this.gr.Text = "Thanh Toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bằng Chữ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng tiền";
            // 
            // lbl_tienchu
            // 
            this.lbl_tienchu.Location = new System.Drawing.Point(156, 64);
            this.lbl_tienchu.Name = "lbl_tienchu";
            this.lbl_tienchu.Size = new System.Drawing.Size(353, 54);
            this.lbl_tienchu.TabIndex = 5;
            this.lbl_tienchu.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bnt_xuatphieunhap
            // 
            this.bnt_xuatphieunhap.Location = new System.Drawing.Point(314, 127);
            this.bnt_xuatphieunhap.Name = "bnt_xuatphieunhap";
            this.bnt_xuatphieunhap.Size = new System.Drawing.Size(177, 38);
            this.bnt_xuatphieunhap.TabIndex = 6;
            this.bnt_xuatphieunhap.Text = "Xuất Phiếu Nhập";
            this.bnt_xuatphieunhap.UseVisualStyleBackColor = true;
            this.bnt_xuatphieunhap.Click += new System.EventHandler(this.bnt_xuatphieunhap_Click);
            // 
            // lbl_tongtiennhap
            // 
            this.lbl_tongtiennhap.Location = new System.Drawing.Point(243, 16);
            this.lbl_tongtiennhap.Name = "lbl_tongtiennhap";
            this.lbl_tongtiennhap.Size = new System.Drawing.Size(266, 23);
            this.lbl_tongtiennhap.TabIndex = 4;
            this.lbl_tongtiennhap.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel4);
            this.groupBox5.Controls.Add(this.panel2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox5, 2);
            this.groupBox5.Size = new System.Drawing.Size(632, 524);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin sản phẩm nhập";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.flowLP_timkiemsp, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(626, 461);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // flowLP_timkiemsp
            // 
            this.flowLP_timkiemsp.AutoScroll = true;
            this.flowLP_timkiemsp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLP_timkiemsp.Location = new System.Drawing.Point(3, 3);
            this.flowLP_timkiemsp.Name = "flowLP_timkiemsp";
            this.flowLP_timkiemsp.Size = new System.Drawing.Size(620, 455);
            this.flowLP_timkiemsp.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txt_timkiem);
            this.panel2.Controls.Add(this.txt_GiaNhap);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txt_sl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 44);
            this.panel2.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Tìm Kiếm :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(560, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "VND";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(75, 14);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(212, 20);
            this.txt_timkiem.TabIndex = 6;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            this.txt_timkiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_timkiem_KeyUp);
            // 
            // txt_GiaNhap
            // 
            this.txt_GiaNhap.Location = new System.Drawing.Point(467, 14);
            this.txt_GiaNhap.Name = "txt_GiaNhap";
            this.txt_GiaNhap.Size = new System.Drawing.Size(92, 20);
            this.txt_GiaNhap.TabIndex = 11;
            this.txt_GiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaNhap_KeyPress);
            this.txt_GiaNhap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_GiaNhap_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(293, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Số Lượng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(401, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Giá Nhập";
            // 
            // txt_sl
            // 
            this.txt_sl.Enabled = false;
            this.txt_sl.Location = new System.Drawing.Point(360, 15);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(35, 20);
            this.txt_sl.TabIndex = 9;
            this.txt_sl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_sl_KeyUp);
            this.txt_sl.Leave += new System.EventHandler(this.txt_sl_Leave);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tableLayoutPanel3);
            this.groupBox6.Controls.Add(this.panel1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(641, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(513, 334);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chi tiết phiếu nhập";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.flowLP_hoadon, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(507, 286);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // flowLP_hoadon
            // 
            this.flowLP_hoadon.AutoScroll = true;
            this.flowLP_hoadon.BackColor = System.Drawing.SystemColors.Window;
            this.flowLP_hoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel3.SetColumnSpan(this.flowLP_hoadon, 2);
            this.flowLP_hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLP_hoadon.Location = new System.Drawing.Point(3, 3);
            this.flowLP_hoadon.Name = "flowLP_hoadon";
            this.tableLayoutPanel3.SetRowSpan(this.flowLP_hoadon, 2);
            this.flowLP_hoadon.Size = new System.Drawing.Size(501, 280);
            this.flowLP_hoadon.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 29);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Mã SP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(322, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Thành Tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tên Sản Phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Đơn Giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "SL";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1169, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống Kê Nhập Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.nHAPHANGDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cT_NHAPHANGDataGridView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1163, 549);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // nHAPHANGDataGridView
            // 
            this.nHAPHANGDataGridView.AllowUserToAddRows = false;
            this.nHAPHANGDataGridView.AutoGenerateColumns = false;
            this.nHAPHANGDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nHAPHANGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nHAPHANGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.nHAPHANGDataGridView.DataSource = this.nHAPHANGBindingSource;
            this.nHAPHANGDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nHAPHANGDataGridView.Location = new System.Drawing.Point(3, 277);
            this.nHAPHANGDataGridView.Name = "nHAPHANGDataGridView";
            this.nHAPHANGDataGridView.ReadOnly = true;
            this.nHAPHANGDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nHAPHANGDataGridView.Size = new System.Drawing.Size(575, 269);
            this.nHAPHANGDataGridView.TabIndex = 10;
            this.nHAPHANGDataGridView.SelectionChanged += new System.EventHandler(this.nHAPHANGDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANHAP";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Nhập";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NGAYNHAP";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngày Nhập";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TONGTIEN";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tổng Tiền";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // nHAPHANGBindingSource
            // 
            this.nHAPHANGBindingSource.DataMember = "NHAPHANG";
            this.nHAPHANGBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(mANHAPLabel1);
            this.groupBox3.Controls.Add(this.mANHAPTextBox1);
            this.groupBox3.Controls.Add(sOLUONGLabel);
            this.groupBox3.Controls.Add(this.sOLUONGTextBox);
            this.groupBox3.Controls.Add(dONGIALabel);
            this.groupBox3.Controls.Add(this.dONGIATextBox);
            this.groupBox3.Controls.Add(tHANHTIENLabel);
            this.groupBox3.Controls.Add(this.tHANHTIENTextBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(584, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 268);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sản phẩm trong phiếu nhập";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(dONGIALabel1);
            this.groupBox4.Controls.Add(this.dONGIATextBox1);
            this.groupBox4.Controls.Add(sOLUONGLabel1);
            this.groupBox4.Controls.Add(this.sOLUONGTextBox1);
            this.groupBox4.Controls.Add(tENSPLabel);
            this.groupBox4.Controls.Add(this.tENSPTextBox);
            this.groupBox4.Controls.Add(this.mASPTextBox);
            this.groupBox4.Controls.Add(mASPLabel);
            this.groupBox4.Location = new System.Drawing.Point(265, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 171);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Sản Phẩm";
            // 
            // dONGIATextBox1
            // 
            this.dONGIATextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "DONGIA", true));
            this.dONGIATextBox1.Location = new System.Drawing.Point(85, 103);
            this.dONGIATextBox1.Name = "dONGIATextBox1";
            this.dONGIATextBox1.Size = new System.Drawing.Size(202, 20);
            this.dONGIATextBox1.TabIndex = 7;
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.dataSet1;
            // 
            // sOLUONGTextBox1
            // 
            this.sOLUONGTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "SOLUONG", true));
            this.sOLUONGTextBox1.Location = new System.Drawing.Point(85, 77);
            this.sOLUONGTextBox1.Name = "sOLUONGTextBox1";
            this.sOLUONGTextBox1.Size = new System.Drawing.Size(202, 20);
            this.sOLUONGTextBox1.TabIndex = 5;
            // 
            // tENSPTextBox
            // 
            this.tENSPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sANPHAMBindingSource, "TENSP", true));
            this.tENSPTextBox.Location = new System.Drawing.Point(85, 51);
            this.tENSPTextBox.Name = "tENSPTextBox";
            this.tENSPTextBox.Size = new System.Drawing.Size(202, 20);
            this.tENSPTextBox.TabIndex = 4;
            // 
            // mASPTextBox
            // 
            this.mASPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_NHAPHANGBindingSource, "MASP", true));
            this.mASPTextBox.Location = new System.Drawing.Point(85, 22);
            this.mASPTextBox.Name = "mASPTextBox";
            this.mASPTextBox.Size = new System.Drawing.Size(202, 20);
            this.mASPTextBox.TabIndex = 3;
            // 
            // cT_NHAPHANGBindingSource
            // 
            this.cT_NHAPHANGBindingSource.DataMember = "CT_NHAPHANG";
            this.cT_NHAPHANGBindingSource.DataSource = this.dataSet1;
            // 
            // mANHAPTextBox1
            // 
            this.mANHAPTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_NHAPHANGBindingSource, "MANHAP", true));
            this.mANHAPTextBox1.Location = new System.Drawing.Point(113, 63);
            this.mANHAPTextBox1.Name = "mANHAPTextBox1";
            this.mANHAPTextBox1.Size = new System.Drawing.Size(146, 20);
            this.mANHAPTextBox1.TabIndex = 1;
            // 
            // sOLUONGTextBox
            // 
            this.sOLUONGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_NHAPHANGBindingSource, "SOLUONG", true));
            this.sOLUONGTextBox.Location = new System.Drawing.Point(113, 92);
            this.sOLUONGTextBox.Name = "sOLUONGTextBox";
            this.sOLUONGTextBox.Size = new System.Drawing.Size(146, 20);
            this.sOLUONGTextBox.TabIndex = 5;
            // 
            // dONGIATextBox
            // 
            this.dONGIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_NHAPHANGBindingSource, "DONGIA", true));
            this.dONGIATextBox.Location = new System.Drawing.Point(113, 118);
            this.dONGIATextBox.Name = "dONGIATextBox";
            this.dONGIATextBox.Size = new System.Drawing.Size(146, 20);
            this.dONGIATextBox.TabIndex = 7;
            // 
            // tHANHTIENTextBox
            // 
            this.tHANHTIENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_NHAPHANGBindingSource, "THANHTIEN", true));
            this.tHANHTIENTextBox.Location = new System.Drawing.Point(113, 144);
            this.tHANHTIENTextBox.Name = "tHANHTIENTextBox";
            this.tHANHTIENTextBox.Size = new System.Drawing.Size(146, 20);
            this.tHANHTIENTextBox.TabIndex = 9;
            // 
            // cT_NHAPHANGDataGridView
            // 
            this.cT_NHAPHANGDataGridView.AllowUserToAddRows = false;
            this.cT_NHAPHANGDataGridView.AutoGenerateColumns = false;
            this.cT_NHAPHANGDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cT_NHAPHANGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cT_NHAPHANGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.cT_NHAPHANGDataGridView.DataSource = this.cT_NHAPHANGBindingSource;
            this.cT_NHAPHANGDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cT_NHAPHANGDataGridView.Location = new System.Drawing.Point(584, 277);
            this.cT_NHAPHANGDataGridView.Name = "cT_NHAPHANGDataGridView";
            this.cT_NHAPHANGDataGridView.ReadOnly = true;
            this.cT_NHAPHANGDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cT_NHAPHANGDataGridView.Size = new System.Drawing.Size(576, 269);
            this.cT_NHAPHANGDataGridView.TabIndex = 11;
            this.cT_NHAPHANGDataGridView.SelectionChanged += new System.EventHandler(this.cT_NHAPHANGDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MANHAP";
            this.dataGridViewTextBoxColumn8.HeaderText = "Mã Nhập";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn9.HeaderText = "Mã Sản Phẩm";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn10.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn11.HeaderText = "Giá Nhập";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "THANHTIEN";
            this.dataGridViewTextBoxColumn12.HeaderText = "Thành Tiền";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_timmanhap);
            this.groupBox2.Controls.Add(mANHAPLabel);
            this.groupBox2.Controls.Add(this.mANHAPTextBox);
            this.groupBox2.Controls.Add(nGAYNHAPLabel);
            this.groupBox2.Controls.Add(this.nGAYNHAPDateTimePicker);
            this.groupBox2.Controls.Add(tONGTIENLabel);
            this.groupBox2.Controls.Add(this.tONGTIENTextBox);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 268);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông thi phiếu nhập";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_CapNhat,
            this.btn_inbangluong});
            this.toolStrip1.Location = new System.Drawing.Point(3, 222);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(569, 43);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
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
            this.btn_CapNhat.Text = "Làm Mới";
            this.btn_CapNhat.ToolTipText = "Cập Nhật thông tin  tài khoản";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_lammoinh_Click);
            // 
            // btn_inbangluong
            // 
            this.btn_inbangluong.AutoSize = false;
            this.btn_inbangluong.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inbangluong.Image = global::ShopQuanAo.Properties.Resources.print_icon;
            this.btn_inbangluong.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_inbangluong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_inbangluong.Name = "btn_inbangluong";
            this.btn_inbangluong.Size = new System.Drawing.Size(100, 40);
            this.btn_inbangluong.Text = "In";
            this.btn_inbangluong.ToolTipText = "In Bảng Lương Nhân Viên";
            this.btn_inbangluong.Click += new System.EventHandler(this.btn_inPN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Xem Theo Ngày";
            // 
            // txt_timmanhap
            // 
            this.txt_timmanhap.Location = new System.Drawing.Point(134, 29);
            this.txt_timmanhap.Name = "txt_timmanhap";
            this.txt_timmanhap.Size = new System.Drawing.Size(200, 20);
            this.txt_timmanhap.TabIndex = 8;
            this.txt_timmanhap.TextChanged += new System.EventHandler(this.txt_timmanhap_TextChanged);
            // 
            // mANHAPTextBox
            // 
            this.mANHAPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHAPHANGBindingSource, "MANHAP", true));
            this.mANHAPTextBox.Location = new System.Drawing.Point(134, 102);
            this.mANHAPTextBox.Name = "mANHAPTextBox";
            this.mANHAPTextBox.Size = new System.Drawing.Size(200, 20);
            this.mANHAPTextBox.TabIndex = 3;
            // 
            // nGAYNHAPDateTimePicker
            // 
            this.nGAYNHAPDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nHAPHANGBindingSource, "NGAYNHAP", true));
            this.nGAYNHAPDateTimePicker.Location = new System.Drawing.Point(134, 128);
            this.nGAYNHAPDateTimePicker.Name = "nGAYNHAPDateTimePicker";
            this.nGAYNHAPDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.nGAYNHAPDateTimePicker.TabIndex = 5;
            // 
            // tONGTIENTextBox
            // 
            this.tONGTIENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHAPHANGBindingSource, "TONGTIEN", true));
            this.tONGTIENTextBox.Location = new System.Drawing.Point(134, 154);
            this.tONGTIENTextBox.Name = "tONGTIENTextBox";
            this.tONGTIENTextBox.Size = new System.Drawing.Size(200, 20);
            this.tONGTIENTextBox.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm";
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
            this.tableAdapterManager.CT_NHAPHANGTableAdapter = this.cT_NHAPHANGTableAdapter;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.LOAITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAPHANGTableAdapter = this.nHAPHANGTableAdapter;
            this.tableAdapterManager.SANPHAMTableAdapter = this.sANPHAMTableAdapter;
            this.tableAdapterManager.UpdateOrder = ShopQuanAo.DAL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VANTAYTableAdapter = null;
            // 
            // cT_NHAPHANGTableAdapter
            // 
            this.cT_NHAPHANGTableAdapter.ClearBeforeFill = true;
            // 
            // nHAPHANGTableAdapter
            // 
            this.nHAPHANGTableAdapter.ClearBeforeFill = true;
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1177, 581);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhapHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gr.ResumeLayout(false);
            this.gr.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sl)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nHAPHANGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAPHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_NHAPHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_NHAPHANGDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bnt_xuatphieunhap;
        private System.Windows.Forms.Label lbl_tienchu;
        private System.Windows.Forms.Label lbl_tongtiennhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.FlowLayoutPanel flowLP_hoadon;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource cT_NHAPHANGBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nHAPHANGBindingSource;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private DAL.DataSet1TableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private DAL.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DAL.DataSet1TableAdapters.CT_NHAPHANGTableAdapter cT_NHAPHANGTableAdapter;
        private DAL.DataSet1TableAdapters.NHAPHANGTableAdapter nHAPHANGTableAdapter;
        private System.Windows.Forms.DataGridView nHAPHANGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView cT_NHAPHANGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox dONGIATextBox1;
        private System.Windows.Forms.TextBox sOLUONGTextBox1;
        private System.Windows.Forms.TextBox tENSPTextBox;
        private System.Windows.Forms.TextBox mASPTextBox;
        private System.Windows.Forms.TextBox mANHAPTextBox1;
        private System.Windows.Forms.TextBox sOLUONGTextBox;
        private System.Windows.Forms.TextBox dONGIATextBox;
        private System.Windows.Forms.TextBox tHANHTIENTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_timmanhap;
        private System.Windows.Forms.TextBox mANHAPTextBox;
        private System.Windows.Forms.DateTimePicker nGAYNHAPDateTimePicker;
        private System.Windows.Forms.TextBox tONGTIENTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flowLP_timkiemsp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_GiaNhap;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown txt_sl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_CapNhat;
        private System.Windows.Forms.ToolStripButton btn_inbangluong;
    }
}