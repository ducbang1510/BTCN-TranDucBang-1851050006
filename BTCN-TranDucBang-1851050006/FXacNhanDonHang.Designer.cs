namespace ShoesShop
{
    partial class FXacNhanDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FXacNhanDonHang));
            this.hoTenNhanVienLabel = new System.Windows.Forms.Label();
            this.ngaySinhLabel = new System.Windows.Forms.Label();
            this.diaChiLabel = new System.Windows.Forms.Label();
            this.dienThoaiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.dtpNgayDatHang = new System.Windows.Forms.DateTimePicker();
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
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gVDH = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVDH)).BeginInit();
            this.SuspendLayout();
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(13, 41);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(101, 16);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Mã đơn hàng:";
            // 
            // ngaySinhLabel
            // 
            this.ngaySinhLabel.AutoSize = true;
            this.ngaySinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinhLabel.Location = new System.Drawing.Point(13, 83);
            this.ngaySinhLabel.Name = "ngaySinhLabel";
            this.ngaySinhLabel.Size = new System.Drawing.Size(113, 16);
            this.ngaySinhLabel.TabIndex = 4;
            this.ngaySinhLabel.Text = "Ngày đặt hàng:";
            // 
            // diaChiLabel
            // 
            this.diaChiLabel.AutoSize = true;
            this.diaChiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiLabel.Location = new System.Drawing.Point(366, 83);
            this.diaChiLabel.Name = "diaChiLabel";
            this.diaChiLabel.Size = new System.Drawing.Size(81, 16);
            this.diaChiLabel.TabIndex = 6;
            this.diaChiLabel.Text = "Nhân viên:";
            // 
            // dienThoaiLabel
            // 
            this.dienThoaiLabel.AutoSize = true;
            this.dienThoaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dienThoaiLabel.Location = new System.Drawing.Point(366, 41);
            this.dienThoaiLabel.Name = "dienThoaiLabel";
            this.dienThoaiLabel.Size = new System.Drawing.Size(92, 16);
            this.dienThoaiLabel.TabIndex = 8;
            this.dienThoaiLabel.Text = "Khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xác nhận đơn hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNhanVien);
            this.groupBox1.Controls.Add(this.cbKhachHang);
            this.groupBox1.Controls.Add(this.txtMaDH);
            this.groupBox1.Controls.Add(this.dtpNgayDatHang);
            this.groupBox1.Controls.Add(this.hoTenNhanVienLabel);
            this.groupBox1.Controls.Add(this.ngaySinhLabel);
            this.groupBox1.Controls.Add(this.diaChiLabel);
            this.groupBox1.Controls.Add(this.dienThoaiLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn:";
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(461, 78);
            this.cbNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(230, 26);
            this.cbNhanVien.TabIndex = 11;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(461, 31);
            this.cbKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(230, 26);
            this.cbKhachHang.TabIndex = 11;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDH.Location = new System.Drawing.Point(131, 38);
            this.txtMaDH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.ReadOnly = true;
            this.txtMaDH.Size = new System.Drawing.Size(230, 24);
            this.txtMaDH.TabIndex = 10;
            // 
            // dtpNgayDatHang
            // 
            this.dtpNgayDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDatHang.Location = new System.Drawing.Point(131, 78);
            this.dtpNgayDatHang.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayDatHang.Name = "dtpNgayDatHang";
            this.dtpNgayDatHang.Size = new System.Drawing.Size(230, 21);
            this.dtpNgayDatHang.TabIndex = 9;
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
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btXoa.Location = new System.Drawing.Point(625, 322);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(93, 36);
            this.btXoa.TabIndex = 14;
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
            this.btSua.Location = new System.Drawing.Point(514, 322);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(93, 36);
            this.btSua.TabIndex = 13;
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
            this.btThem.Location = new System.Drawing.Point(403, 322);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(93, 36);
            this.btThem.TabIndex = 12;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label2
            // 
            this.label2.Image = global::ShoesShop.Properties.Resources.logo3;
            this.label2.Location = new System.Drawing.Point(381, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 189);
            this.label2.TabIndex = 15;
            // 
            // gVDH
            // 
            this.gVDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVDH.Location = new System.Drawing.Point(27, 400);
            this.gVDH.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gVDH.Name = "gVDH";
            this.gVDH.RowHeadersWidth = 62;
            this.gVDH.RowTemplate.Height = 28;
            this.gVDH.Size = new System.Drawing.Size(705, 212);
            this.gVDH.TabIndex = 0;
            this.gVDH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVDH_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Danh sách hóa đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 626);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(499, 621);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(230, 24);
            this.txtTongTien.TabIndex = 10;
            // 
            // btXacNhan
            // 
            this.btXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btXacNhan.Location = new System.Drawing.Point(27, 322);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(145, 36);
            this.btXacNhan.TabIndex = 12;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = false;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // FXacNhanDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(744, 656);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gVDH);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXacNhan);
            this.Controls.Add(this.btThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FXacNhanDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đơn hàng";
            this.Load += new System.EventHandler(this.FHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVDH)).EndInit();
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
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.Label ngaySinhLabel;
        private System.Windows.Forms.Label diaChiLabel;
        private System.Windows.Forms.Label dienThoaiLabel;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.DateTimePicker dtpNgayDatHang;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gVDH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btXacNhan;
    }
}