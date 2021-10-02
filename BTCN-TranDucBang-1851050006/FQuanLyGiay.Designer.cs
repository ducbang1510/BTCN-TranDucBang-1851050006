namespace ShoesShop
{
    partial class FQuanLyGiay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQuanLyGiay));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenGiay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaGiay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dGVGiay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiay)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(52, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quản Lý Giày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numSize);
            this.groupBox1.Controls.Add(this.cbNCC);
            this.groupBox1.Controls.Add(this.txtSoLuongTon);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtTenGiay);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaGiay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giày:";
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(411, 120);
            this.numSize.Maximum = new decimal(new int[] {
            43,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(206, 24);
            this.numSize.TabIndex = 7;
            this.numSize.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // cbNCC
            // 
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Romance",
            "Horror",
            "Animation"});
            this.cbNCC.Location = new System.Drawing.Point(125, 73);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(206, 26);
            this.cbNCC.TabIndex = 6;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTon.Location = new System.Drawing.Point(125, 120);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(206, 24);
            this.txtSoLuongTon.TabIndex = 2;
            this.txtSoLuongTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongTon_KeyPress);
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(411, 76);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(206, 24);
            this.txtGia.TabIndex = 2;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongTon_KeyPress);
            // 
            // txtTenGiay
            // 
            this.txtTenGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGiay.Location = new System.Drawing.Point(411, 29);
            this.txtTenGiay.Name = "txtTenGiay";
            this.txtTenGiay.Size = new System.Drawing.Size(206, 24);
            this.txtTenGiay.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số lượng tồn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nhà cung cấp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(337, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(337, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên giày:";
            // 
            // txtMaGiay
            // 
            this.txtMaGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGiay.Location = new System.Drawing.Point(125, 32);
            this.txtMaGiay.Name = "txtMaGiay";
            this.txtMaGiay.Size = new System.Drawing.Size(206, 24);
            this.txtMaGiay.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã giày:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(225, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng:";
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btXoa.Location = new System.Drawing.Point(280, 28);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(94, 35);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSua.Location = new System.Drawing.Point(161, 28);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(94, 35);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThem.Location = new System.Drawing.Point(45, 28);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(94, 35);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Danh sách phim:";
            // 
            // dGVGiay
            // 
            this.dGVGiay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGiay.Location = new System.Drawing.Point(17, 478);
            this.dGVGiay.Name = "dGVGiay";
            this.dGVGiay.Size = new System.Drawing.Size(644, 209);
            this.dGVGiay.TabIndex = 4;
            this.dGVGiay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVGiay_CellClick);
            // 
            // label1
            // 
            this.label1.Image = global::ShoesShop.Properties.Resources.logo3;
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 196);
            this.label1.TabIndex = 2;
            // 
            // FQuanLyGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(678, 693);
            this.Controls.Add(this.dGVGiay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FQuanLyGiay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Giày";
            this.Load += new System.EventHandler(this.FQuanLyGiay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenGiay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaGiay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dGVGiay;
    }
}