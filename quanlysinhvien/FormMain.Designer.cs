namespace quanlysinhvien
{
    partial class FormMain
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
            System.Windows.Forms.Label maLopLabel1;
            System.Windows.Forms.Label tenLopLabel;
            System.Windows.Forms.Label maSVLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label maLopLabel;
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbQLSVDataSet = new quanlysinhvien.DbQLSVDataSet();
            this.lopQLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new quanlysinhvien.DbQLSVDataSetTableAdapters.SinhVienTableAdapter();
            this.tableAdapterManager = new quanlysinhvien.DbQLSVDataSetTableAdapters.TableAdapterManager();
            this.lopQLTableAdapter = new quanlysinhvien.DbQLSVDataSetTableAdapters.LopQLTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lopQLDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxMalop = new System.Windows.Forms.TextBox();
            this.tbxTenlop = new System.Windows.Forms.TextBox();
            this.btn_addCl = new System.Windows.Forms.Button();
            this.btn_editCl = new System.Windows.Forms.Button();
            this.btn_saveCl = new System.Windows.Forms.Button();
            this.btn_delCl = new System.Windows.Forms.Button();
            this.sinhVienDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxMaSV = new System.Windows.Forms.TextBox();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_TimMaLop = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            maLopLabel1 = new System.Windows.Forms.Label();
            tenLopLabel = new System.Windows.Forms.Label();
            maSVLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            maLopLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbQLSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopQLBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopQLDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.dbQLSVDataSet;
            // 
            // dbQLSVDataSet
            // 
            this.dbQLSVDataSet.DataSetName = "DbQLSVDataSet";
            this.dbQLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopQLBindingSource
            // 
            this.lopQLBindingSource.DataMember = "LopQL";
            this.lopQLBindingSource.DataSource = this.dbQLSVDataSet;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LopQLTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = quanlysinhvien.DbQLSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // lopQLTableAdapter
            // 
            this.lopQLTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quan ly lop hoc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quan ly sinh vien";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 452);
            this.tabControl1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(maSVLabel);
            this.splitContainer1.Panel1.Controls.Add(this.tbxMaSV);
            this.splitContainer1.Panel1.Controls.Add(hoTenLabel);
            this.splitContainer1.Panel1.Controls.Add(this.hoTenTextBox);
            this.splitContainer1.Panel1.Controls.Add(maLopLabel);
            this.splitContainer1.Panel1.Controls.Add(this.cmbMaLop);
            this.splitContainer1.Panel1.Controls.Add(this.btn_save);
            this.splitContainer1.Panel1.Controls.Add(this.btn_del);
            this.splitContainer1.Panel1.Controls.Add(this.btn_edit);
            this.splitContainer1.Panel1.Controls.Add(this.btn_create);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.btn_search);
            this.splitContainer1.Panel2.Controls.Add(this.tbx_TimMaLop);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.sinhVienDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(786, 420);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(201, 286);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 42);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Luu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(77, 286);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(89, 42);
            this.btn_del.TabIndex = 1;
            this.btn_del.Text = "Xoa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click_1);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(201, 238);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(89, 42);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Sua";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click_1);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(77, 238);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(89, 42);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Them";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click_1);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btn_delCl);
            this.splitContainer2.Panel1.Controls.Add(this.btn_saveCl);
            this.splitContainer2.Panel1.Controls.Add(this.btn_editCl);
            this.splitContainer2.Panel1.Controls.Add(this.btn_addCl);
            this.splitContainer2.Panel1.Controls.Add(maLopLabel1);
            this.splitContainer2.Panel1.Controls.Add(this.tbxMalop);
            this.splitContainer2.Panel1.Controls.Add(tenLopLabel);
            this.splitContainer2.Panel1.Controls.Add(this.tbxTenlop);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.lopQLDataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(786, 420);
            this.splitContainer2.SplitterDistance = 381;
            this.splitContainer2.TabIndex = 0;
            // 
            // lopQLDataGridView
            // 
            this.lopQLDataGridView.AutoGenerateColumns = false;
            this.lopQLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lopQLDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.lopQLDataGridView.DataSource = this.lopQLBindingSource;
            this.lopQLDataGridView.Location = new System.Drawing.Point(3, 3);
            this.lopQLDataGridView.Name = "lopQLDataGridView";
            this.lopQLDataGridView.Size = new System.Drawing.Size(398, 414);
            this.lopQLDataGridView.TabIndex = 0;
            this.lopQLDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lopQLDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaLop";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaLop";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenLop";
            this.dataGridViewTextBoxColumn5.HeaderText = "TenLop";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // maLopLabel1
            // 
            maLopLabel1.AutoSize = true;
            maLopLabel1.Location = new System.Drawing.Point(86, 59);
            maLopLabel1.Name = "maLopLabel1";
            maLopLabel1.Size = new System.Drawing.Size(46, 13);
            maLopLabel1.TabIndex = 0;
            maLopLabel1.Text = "Ma Lop:";
            // 
            // tbxMalop
            // 
            this.tbxMalop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopQLBindingSource, "MaLop", true));
            this.tbxMalop.Location = new System.Drawing.Point(142, 56);
            this.tbxMalop.Name = "tbxMalop";
            this.tbxMalop.Size = new System.Drawing.Size(100, 20);
            this.tbxMalop.TabIndex = 1;
            // 
            // tenLopLabel
            // 
            tenLopLabel.AutoSize = true;
            tenLopLabel.Location = new System.Drawing.Point(86, 85);
            tenLopLabel.Name = "tenLopLabel";
            tenLopLabel.Size = new System.Drawing.Size(50, 13);
            tenLopLabel.TabIndex = 2;
            tenLopLabel.Text = "Ten Lop:";
            // 
            // tbxTenlop
            // 
            this.tbxTenlop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopQLBindingSource, "TenLop", true));
            this.tbxTenlop.Location = new System.Drawing.Point(142, 82);
            this.tbxTenlop.Name = "tbxTenlop";
            this.tbxTenlop.Size = new System.Drawing.Size(100, 20);
            this.tbxTenlop.TabIndex = 3;
            // 
            // btn_addCl
            // 
            this.btn_addCl.Location = new System.Drawing.Point(96, 289);
            this.btn_addCl.Name = "btn_addCl";
            this.btn_addCl.Size = new System.Drawing.Size(75, 23);
            this.btn_addCl.TabIndex = 4;
            this.btn_addCl.Text = "Them";
            this.btn_addCl.UseVisualStyleBackColor = true;
            this.btn_addCl.Click += new System.EventHandler(this.btn_addCl_Click);
            // 
            // btn_editCl
            // 
            this.btn_editCl.Location = new System.Drawing.Point(202, 289);
            this.btn_editCl.Name = "btn_editCl";
            this.btn_editCl.Size = new System.Drawing.Size(75, 23);
            this.btn_editCl.TabIndex = 4;
            this.btn_editCl.Text = "Sua";
            this.btn_editCl.UseVisualStyleBackColor = true;
            this.btn_editCl.Click += new System.EventHandler(this.btn_editCl_Click);
            // 
            // btn_saveCl
            // 
            this.btn_saveCl.Location = new System.Drawing.Point(202, 334);
            this.btn_saveCl.Name = "btn_saveCl";
            this.btn_saveCl.Size = new System.Drawing.Size(75, 23);
            this.btn_saveCl.TabIndex = 4;
            this.btn_saveCl.Text = "Luu";
            this.btn_saveCl.UseVisualStyleBackColor = true;
            this.btn_saveCl.Click += new System.EventHandler(this.btn_saveCl_Click);
            // 
            // btn_delCl
            // 
            this.btn_delCl.Location = new System.Drawing.Point(96, 334);
            this.btn_delCl.Name = "btn_delCl";
            this.btn_delCl.Size = new System.Drawing.Size(75, 23);
            this.btn_delCl.TabIndex = 4;
            this.btn_delCl.Text = "Xoa";
            this.btn_delCl.UseVisualStyleBackColor = true;
            this.btn_delCl.Click += new System.EventHandler(this.btn_delCl_Click);
            // 
            // sinhVienDataGridView
            // 
            this.sinhVienDataGridView.AutoGenerateColumns = false;
            this.sinhVienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sinhVienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.sinhVienDataGridView.DataSource = this.sinhVienBindingSource;
            this.sinhVienDataGridView.Location = new System.Drawing.Point(3, 41);
            this.sinhVienDataGridView.Name = "sinhVienDataGridView";
            this.sinhVienDataGridView.Size = new System.Drawing.Size(394, 374);
            this.sinhVienDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaSV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn2.HeaderText = "HoTen";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaLop";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaLop";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // maSVLabel
            // 
            maSVLabel.AutoSize = true;
            maSVLabel.Location = new System.Drawing.Point(88, 62);
            maSVLabel.Name = "maSVLabel";
            maSVLabel.Size = new System.Drawing.Size(42, 13);
            maSVLabel.TabIndex = 4;
            maSVLabel.Text = "Ma SV:";
            // 
            // tbxMaSV
            // 
            this.tbxMaSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaSV", true));
            this.tbxMaSV.Location = new System.Drawing.Point(140, 59);
            this.tbxMaSV.Name = "tbxMaSV";
            this.tbxMaSV.Size = new System.Drawing.Size(121, 20);
            this.tbxMaSV.TabIndex = 5;
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(88, 88);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(46, 13);
            hoTenLabel.TabIndex = 6;
            hoTenLabel.Text = "Ho Ten:";
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "HoTen", true));
            this.hoTenTextBox.Location = new System.Drawing.Point(140, 85);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(121, 20);
            this.hoTenTextBox.TabIndex = 7;
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Location = new System.Drawing.Point(88, 114);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(46, 13);
            maLopLabel.TabIndex = 8;
            maLopLabel.Text = "Ma Lop:";
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaLop", true));
            this.cmbMaLop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sinhVienBindingSource, "MaLop", true));
            this.cmbMaLop.DataSource = this.lopQLBindingSource;
            this.cmbMaLop.DisplayMember = "TenLop";
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(140, 111);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(121, 21);
            this.cmbMaLop.TabIndex = 9;
            this.cmbMaLop.ValueMember = "MaLop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loc theo lop";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbx_TimMaLop
            // 
            this.tbx_TimMaLop.Location = new System.Drawing.Point(84, 8);
            this.tbx_TimMaLop.Name = "tbx_TimMaLop";
            this.tbx_TimMaLop.Size = new System.Drawing.Size(100, 20);
            this.tbx_TimMaLop.TabIndex = 3;
            this.tbx_TimMaLop.TextChanged += new System.EventHandler(this.tbx_TimMaLop_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(207, 8);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 20);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "OK";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbQLSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopQLBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lopQLDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DbQLSVDataSet dbQLSVDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private DbQLSVDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private DbQLSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource lopQLBindingSource;
        private DbQLSVDataSetTableAdapters.LopQLTableAdapter lopQLTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView lopQLDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox tbxMalop;
        private System.Windows.Forms.TextBox tbxTenlop;
        private System.Windows.Forms.Button btn_delCl;
        private System.Windows.Forms.Button btn_saveCl;
        private System.Windows.Forms.Button btn_editCl;
        private System.Windows.Forms.Button btn_addCl;
        private System.Windows.Forms.TextBox tbxMaSV;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.DataGridView sinhVienDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tbx_TimMaLop;
    }
}