using ShopQuanAo.DAL;

namespace ShopQuanAo
{
    partial class CTHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTHoaDon));
            System.Windows.Forms.Label mAHDLabel;
            System.Windows.Forms.Label mASPLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label gIAMGIALabel;
            System.Windows.Forms.Label tHANHTIENLabel;
            this.dataSet1 = new ShopQuanAo.DAL.DataSet1();
            this.cT_HOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cT_HOADONTableAdapter = new ShopQuanAo.DAL.DataSet1TableAdapters.CT_HOADONTableAdapter();
            this.tableAdapterManager = new ShopQuanAo.DAL.DataSet1TableAdapters.TableAdapterManager();
            this.cT_HOADONBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cT_HOADONBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cT_HOADONDataGridView = new System.Windows.Forms.DataGridView();
            this.mAHDTextBox = new System.Windows.Forms.TextBox();
            this.mASPTextBox = new System.Windows.Forms.TextBox();
            this.sOLUONGTextBox = new System.Windows.Forms.TextBox();
            this.dONGIATextBox = new System.Windows.Forms.TextBox();
            this.gIAMGIATextBox = new System.Windows.Forms.TextBox();
            this.tHANHTIENTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mAHDLabel = new System.Windows.Forms.Label();
            mASPLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            gIAMGIALabel = new System.Windows.Forms.Label();
            tHANHTIENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_HOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_HOADONBindingNavigator)).BeginInit();
            this.cT_HOADONBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cT_HOADONDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cT_HOADONBindingSource
            // 
            this.cT_HOADONBindingSource.DataMember = "CT_HOADON";
            this.cT_HOADONBindingSource.DataSource = this.dataSet1;
            // 
            // cT_HOADONTableAdapter
            // 
            this.cT_HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_HOADONTableAdapter = this.cT_HOADONTableAdapter;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.LOAITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAPHANGTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShopQuanAo.DAL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cT_HOADONBindingNavigator
            // 
            this.cT_HOADONBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cT_HOADONBindingNavigator.BindingSource = this.cT_HOADONBindingSource;
            this.cT_HOADONBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cT_HOADONBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cT_HOADONBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cT_HOADONBindingNavigatorSaveItem});
            this.cT_HOADONBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cT_HOADONBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cT_HOADONBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cT_HOADONBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cT_HOADONBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cT_HOADONBindingNavigator.Name = "cT_HOADONBindingNavigator";
            this.cT_HOADONBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cT_HOADONBindingNavigator.Size = new System.Drawing.Size(804, 25);
            this.cT_HOADONBindingNavigator.TabIndex = 0;
            this.cT_HOADONBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cT_HOADONBindingNavigatorSaveItem
            // 
            this.cT_HOADONBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cT_HOADONBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cT_HOADONBindingNavigatorSaveItem.Image")));
            this.cT_HOADONBindingNavigatorSaveItem.Name = "cT_HOADONBindingNavigatorSaveItem";
            this.cT_HOADONBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cT_HOADONBindingNavigatorSaveItem.Text = "Save Data";
            this.cT_HOADONBindingNavigatorSaveItem.Click += new System.EventHandler(this.cT_HOADONBindingNavigatorSaveItem_Click);
            // 
            // cT_HOADONDataGridView
            // 
            this.cT_HOADONDataGridView.AutoGenerateColumns = false;
            this.cT_HOADONDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cT_HOADONDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.cT_HOADONDataGridView.DataSource = this.cT_HOADONBindingSource;
            this.cT_HOADONDataGridView.Location = new System.Drawing.Point(87, 222);
            this.cT_HOADONDataGridView.Name = "cT_HOADONDataGridView";
            this.cT_HOADONDataGridView.Size = new System.Drawing.Size(645, 220);
            this.cT_HOADONDataGridView.TabIndex = 1;
            // 
            // mAHDLabel
            // 
            mAHDLabel.AutoSize = true;
            mAHDLabel.Location = new System.Drawing.Point(21, 38);
            mAHDLabel.Name = "mAHDLabel";
            mAHDLabel.Size = new System.Drawing.Size(93, 17);
            mAHDLabel.TabIndex = 2;
            mAHDLabel.Text = "Mã hoá đơn";
            // 
            // mAHDTextBox
            // 
            this.mAHDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_HOADONBindingSource, "MAHD", true));
            this.mAHDTextBox.Location = new System.Drawing.Point(131, 35);
            this.mAHDTextBox.Name = "mAHDTextBox";
            this.mAHDTextBox.Size = new System.Drawing.Size(226, 23);
            this.mAHDTextBox.TabIndex = 3;
            // 
            // mASPLabel
            // 
            mASPLabel.AutoSize = true;
            mASPLabel.Location = new System.Drawing.Point(21, 73);
            mASPLabel.Name = "mASPLabel";
            mASPLabel.Size = new System.Drawing.Size(104, 17);
            mASPLabel.TabIndex = 4;
            mASPLabel.Text = "Mã sản phẩm";
            // 
            // mASPTextBox
            // 
            this.mASPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_HOADONBindingSource, "MASP", true));
            this.mASPTextBox.Location = new System.Drawing.Point(131, 70);
            this.mASPTextBox.Name = "mASPTextBox";
            this.mASPTextBox.Size = new System.Drawing.Size(226, 23);
            this.mASPTextBox.TabIndex = 5;
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(21, 112);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(77, 17);
            sOLUONGLabel.TabIndex = 6;
            sOLUONGLabel.Text = "Số Lượng";
            // 
            // sOLUONGTextBox
            // 
            this.sOLUONGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_HOADONBindingSource, "SOLUONG", true));
            this.sOLUONGTextBox.Location = new System.Drawing.Point(131, 109);
            this.sOLUONGTextBox.Name = "sOLUONGTextBox";
            this.sOLUONGTextBox.Size = new System.Drawing.Size(226, 23);
            this.sOLUONGTextBox.TabIndex = 7;
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(382, 41);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(64, 17);
            dONGIALabel.TabIndex = 8;
            dONGIALabel.Text = "Đơn giá";
            // 
            // dONGIATextBox
            // 
            this.dONGIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_HOADONBindingSource, "DONGIA", true));
            this.dONGIATextBox.Location = new System.Drawing.Point(474, 38);
            this.dONGIATextBox.Name = "dONGIATextBox";
            this.dONGIATextBox.Size = new System.Drawing.Size(147, 23);
            this.dONGIATextBox.TabIndex = 9;
            // 
            // gIAMGIALabel
            // 
            gIAMGIALabel.AutoSize = true;
            gIAMGIALabel.Location = new System.Drawing.Point(382, 76);
            gIAMGIALabel.Name = "gIAMGIALabel";
            gIAMGIALabel.Size = new System.Drawing.Size(72, 17);
            gIAMGIALabel.TabIndex = 10;
            gIAMGIALabel.Text = "Giảm giá";
            // 
            // gIAMGIATextBox
            // 
            this.gIAMGIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_HOADONBindingSource, "GIAMGIA", true));
            this.gIAMGIATextBox.Location = new System.Drawing.Point(474, 73);
            this.gIAMGIATextBox.Name = "gIAMGIATextBox";
            this.gIAMGIATextBox.Size = new System.Drawing.Size(147, 23);
            this.gIAMGIATextBox.TabIndex = 11;
            // 
            // tHANHTIENLabel
            // 
            tHANHTIENLabel.AutoSize = true;
            tHANHTIENLabel.Location = new System.Drawing.Point(382, 112);
            tHANHTIENLabel.Name = "tHANHTIENLabel";
            tHANHTIENLabel.Size = new System.Drawing.Size(86, 17);
            tHANHTIENLabel.TabIndex = 12;
            tHANHTIENLabel.Text = "Thành tiền";
            // 
            // tHANHTIENTextBox
            // 
            this.tHANHTIENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cT_HOADONBindingSource, "THANHTIEN", true));
            this.tHANHTIENTextBox.Location = new System.Drawing.Point(474, 109);
            this.tHANHTIENTextBox.Name = "tHANHTIENTextBox";
            this.tHANHTIENTextBox.Size = new System.Drawing.Size(147, 23);
            this.tHANHTIENTextBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(mAHDLabel);
            this.groupBox1.Controls.Add(dONGIALabel);
            this.groupBox1.Controls.Add(this.dONGIATextBox);
            this.groupBox1.Controls.Add(this.sOLUONGTextBox);
            this.groupBox1.Controls.Add(gIAMGIALabel);
            this.groupBox1.Controls.Add(this.mAHDTextBox);
            this.groupBox1.Controls.Add(this.gIAMGIATextBox);
            this.groupBox1.Controls.Add(sOLUONGLabel);
            this.groupBox1.Controls.Add(tHANHTIENLabel);
            this.groupBox1.Controls.Add(mASPLabel);
            this.groupBox1.Controls.Add(this.tHANHTIENTextBox);
            this.groupBox1.Controls.Add(this.mASPTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(87, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 151);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin của hoá đơn đã bán";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAHD";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã hoá đơn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GIAMGIA";
            this.dataGridViewTextBoxColumn5.HeaderText = "Giảm giá";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "THANHTIEN";
            this.dataGridViewTextBoxColumn6.HeaderText = "Thành tiền";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // CTHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cT_HOADONDataGridView);
            this.Controls.Add(this.cT_HOADONBindingNavigator);
            this.Name = "CTHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hoá đơn";
            this.Load += new System.EventHandler(this.CTHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_HOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_HOADONBindingNavigator)).EndInit();
            this.cT_HOADONBindingNavigator.ResumeLayout(false);
            this.cT_HOADONBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cT_HOADONDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cT_HOADONBindingSource;
        private DAL.DataSet1TableAdapters.CT_HOADONTableAdapter cT_HOADONTableAdapter;
        private DAL.DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cT_HOADONBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cT_HOADONBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cT_HOADONDataGridView;
        private System.Windows.Forms.TextBox mAHDTextBox;
        private System.Windows.Forms.TextBox mASPTextBox;
        private System.Windows.Forms.TextBox sOLUONGTextBox;
        private System.Windows.Forms.TextBox dONGIATextBox;
        private System.Windows.Forms.TextBox gIAMGIATextBox;
        private System.Windows.Forms.TextBox tHANHTIENTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}