namespace ShoesShop
{
    partial class FDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDatHang));
            this.maKhachHangLabel = new System.Windows.Forms.Label();
            this.soLuongLabel = new System.Windows.Forms.Label();
            this.donGiaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaGiay = new System.Windows.Forms.TextBox();
            this.txtTenGiay = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayDonHang = new System.Windows.Forms.DateTimePicker();
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
            this.dGVCTDH = new System.Windows.Forms.DataGridView();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btDatHang = new System.Windows.Forms.Button();
            this.dGVGiay = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCTDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiay)).BeginInit();
            this.SuspendLayout();
            // 
            // maKhachHangLabel
            // 
            this.maKhachHangLabel.AutoSize = true;
            this.maKhachHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maKhachHangLabel.Location = new System.Drawing.Point(9, 35);
            this.maKhachHangLabel.Name = "maKhachHangLabel";
            this.maKhachHangLabel.Size = new System.Drawing.Size(116, 16);
            this.maKhachHangLabel.TabIndex = 2;
            this.maKhachHangLabel.Text = "Mã khách hàng:";
            // 
            // soLuongLabel
            // 
            this.soLuongLabel.AutoSize = true;
            this.soLuongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuongLabel.Location = new System.Drawing.Point(9, 115);
            this.soLuongLabel.Name = "soLuongLabel";
            this.soLuongLabel.Size = new System.Drawing.Size(74, 16);
            this.soLuongLabel.TabIndex = 6;
            this.soLuongLabel.Text = "Số lượng:";
            // 
            // donGiaLabel
            // 
            this.donGiaLabel.AutoSize = true;
            this.donGiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donGiaLabel.Location = new System.Drawing.Point(356, 117);
            this.donGiaLabel.Name = "donGiaLabel";
            this.donGiaLabel.Size = new System.Drawing.Size(67, 16);
            this.donGiaLabel.TabIndex = 8;
            this.donGiaLabel.Text = "Đơn Giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(29, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numSoLuong);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaGiay);
            this.groupBox1.Controls.Add(this.txtTenGiay);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.maKhachHangLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.soLuongLabel);
            this.groupBox1.Controls.Add(this.donGiaLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(131, 113);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(180, 24);
            this.numSoLuong.TabIndex = 9;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(478, 32);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(180, 24);
            this.txtTenKH.TabIndex = 11;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(131, 31);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(180, 24);
            this.txtMaKH.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên khách hàng:";
            // 
            // txtMaGiay
            // 
            this.txtMaGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGiay.Location = new System.Drawing.Point(132, 72);
            this.txtMaGiay.Name = "txtMaGiay";
            this.txtMaGiay.ReadOnly = true;
            this.txtMaGiay.Size = new System.Drawing.Size(179, 24);
            this.txtMaGiay.TabIndex = 11;
            // 
            // txtTenGiay
            // 
            this.txtTenGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGiay.Location = new System.Drawing.Point(478, 73);
            this.txtTenGiay.Name = "txtTenGiay";
            this.txtTenGiay.ReadOnly = true;
            this.txtTenGiay.Size = new System.Drawing.Size(179, 24);
            this.txtTenGiay.TabIndex = 11;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(478, 114);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(179, 24);
            this.txtDonGia.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mã Giày:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giày:";
            // 
            // dtpNgayDonHang
            // 
            this.dtpNgayDonHang.Location = new System.Drawing.Point(186, 109);
            this.dtpNgayDonHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayDonHang.Name = "dtpNgayDonHang";
            this.dtpNgayDonHang.Size = new System.Drawing.Size(298, 20);
            this.dtpNgayDonHang.TabIndex = 5;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // dGVCTDH
            // 
            this.dGVCTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCTDH.Location = new System.Drawing.Point(21, 366);
            this.dGVCTDH.Margin = new System.Windows.Forms.Padding(2);
            this.dGVCTDH.Name = "dGVCTDH";
            this.dGVCTDH.RowHeadersWidth = 62;
            this.dGVCTDH.RowTemplate.Height = 28;
            this.dGVCTDH.Size = new System.Drawing.Size(693, 259);
            this.dGVCTDH.TabIndex = 0;
            this.dGVCTDH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCTDH_CellClick);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btXoa.Location = new System.Drawing.Point(620, 308);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(93, 36);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSua.Location = new System.Drawing.Point(499, 308);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(93, 36);
            this.btSua.TabIndex = 4;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThem.Location = new System.Drawing.Point(378, 308);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(93, 36);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label2
            // 
            this.label2.Image = global::ShoesShop.Properties.Resources.logo3;
            this.label2.Location = new System.Drawing.Point(376, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 152);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thông tin đặt hàng:";
            // 
            // btDatHang
            // 
            this.btDatHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btDatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDatHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btDatHang.Location = new System.Drawing.Point(876, 42);
            this.btDatHang.Name = "btDatHang";
            this.btDatHang.Size = new System.Drawing.Size(135, 61);
            this.btDatHang.TabIndex = 3;
            this.btDatHang.Text = "Đặt hàng";
            this.btDatHang.UseVisualStyleBackColor = false;
            this.btDatHang.Click += new System.EventHandler(this.btDatHang_Click);
            // 
            // dGVGiay
            // 
            this.dGVGiay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVGiay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGiay.Location = new System.Drawing.Point(750, 162);
            this.dGVGiay.Name = "dGVGiay";
            this.dGVGiay.Size = new System.Drawing.Size(363, 463);
            this.dGVGiay.TabIndex = 8;
            this.dGVGiay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVGiay_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(747, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Danh sách sản phẩm:";
            // 
            // FDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1133, 655);
            this.Controls.Add(this.dGVGiay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btDatHang);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dGVCTDH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Hàng";
            this.Load += new System.EventHandler(this.FChiTietHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCTDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;

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
        private System.Windows.Forms.DateTimePicker dtpNgayDonHang;
        private System.Windows.Forms.Label maKhachHangLabel;
        private System.Windows.Forms.Label soLuongLabel;
        private System.Windows.Forms.Label donGiaLabel;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.DataGridView dGVCTDH;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDatHang;
        private System.Windows.Forms.DataGridView dGVGiay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenGiay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaGiay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numSoLuong;
    }
}