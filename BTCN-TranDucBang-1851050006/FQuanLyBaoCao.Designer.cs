
namespace ShoesShop
{
    partial class FQuanLyBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQuanLyBaoCao));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mSISanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.baToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSISanPham,
            this.baToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Báo cáo sản phẩm";
            // 
            // mSISanPham
            // 
            this.mSISanPham.Name = "mSISanPham";
            this.mSISanPham.Size = new System.Drawing.Size(116, 20);
            this.mSISanPham.Text = "Báo cáo sản phẩm";
            this.mSISanPham.Click += new System.EventHandler(this.mSISanPham_Click);
            // 
            // baToolStripMenuItem
            // 
            this.baToolStripMenuItem.Name = "baToolStripMenuItem";
            this.baToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.baToolStripMenuItem.Text = "Báo cáo đơn hàng";
            this.baToolStripMenuItem.Click += new System.EventHandler(this.baToolStripMenuItem_Click);
            // 
            // FQuanLyBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 281);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FQuanLyBaoCao";
            this.Text = "Quản lý báo cáo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mSISanPham;
        private System.Windows.Forms.ToolStripMenuItem baToolStripMenuItem;
    }
}