namespace BTL_C_.src.Views.Admin
{
  partial class InvoiceDetailControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.lblmaHoaDonBan = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblmaSP = new System.Windows.Forms.Label();
            this.lblsoLuong = new System.Windows.Forms.Label();
            this.lbldongia = new System.Windows.Forms.Label();
            this.lblgiamgia = new System.Windows.Forms.Label();
            this.lblthanhtien = new System.Windows.Forms.Label();
            this.btnXoaCTHDB = new System.Windows.Forms.Button();
            this.dgvChiTietHDBan = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHoaDonBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHDBan = new System.Windows.Forms.DataGridView();
            this.nudDonGia = new System.Windows.Forms.NumericUpDown();
            this.nudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.nudThanhTien = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTongTien = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDBan)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThanhTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmaHoaDonBan
            // 
            this.lblmaHoaDonBan.AutoSize = true;
            this.lblmaHoaDonBan.Location = new System.Drawing.Point(84, 78);
            this.lblmaHoaDonBan.Name = "lblmaHoaDonBan";
            this.lblmaHoaDonBan.Size = new System.Drawing.Size(104, 16);
            this.lblmaHoaDonBan.TabIndex = 0;
            this.lblmaHoaDonBan.Text = "Mã hóa đơn bán";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(199, 120);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.ReadOnly = true;
            this.txtMaSanPham.Size = new System.Drawing.Size(153, 22);
            this.txtMaSanPham.TabIndex = 2;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(832, 126);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.ReadOnly = true;
            this.nudSoLuong.Size = new System.Drawing.Size(103, 22);
            this.nudSoLuong.TabIndex = 6;
            // 
            // lblmaSP
            // 
            this.lblmaSP.AutoSize = true;
            this.lblmaSP.Location = new System.Drawing.Point(84, 126);
            this.lblmaSP.Name = "lblmaSP";
            this.lblmaSP.Size = new System.Drawing.Size(88, 16);
            this.lblmaSP.TabIndex = 9;
            this.lblmaSP.Text = "Mã sản phẩm";
            // 
            // lblsoLuong
            // 
            this.lblsoLuong.AutoSize = true;
            this.lblsoLuong.Location = new System.Drawing.Point(746, 132);
            this.lblsoLuong.Name = "lblsoLuong";
            this.lblsoLuong.Size = new System.Drawing.Size(60, 16);
            this.lblsoLuong.TabIndex = 10;
            this.lblsoLuong.Text = "Số lượng";
            // 
            // lbldongia
            // 
            this.lbldongia.AutoSize = true;
            this.lbldongia.Location = new System.Drawing.Point(441, 80);
            this.lbldongia.Name = "lbldongia";
            this.lbldongia.Size = new System.Drawing.Size(53, 16);
            this.lbldongia.TabIndex = 11;
            this.lbldongia.Text = "Đơn giá";
            // 
            // lblgiamgia
            // 
            this.lblgiamgia.AutoSize = true;
            this.lblgiamgia.Location = new System.Drawing.Point(746, 83);
            this.lblgiamgia.Name = "lblgiamgia";
            this.lblgiamgia.Size = new System.Drawing.Size(61, 16);
            this.lblgiamgia.TabIndex = 13;
            this.lblgiamgia.Text = "Giảm giá";
            // 
            // lblthanhtien
            // 
            this.lblthanhtien.AutoSize = true;
            this.lblthanhtien.Location = new System.Drawing.Point(441, 128);
            this.lblthanhtien.Name = "lblthanhtien";
            this.lblthanhtien.Size = new System.Drawing.Size(69, 16);
            this.lblthanhtien.TabIndex = 15;
            this.lblthanhtien.Text = "Thành tiền";
            // 
            // btnXoaCTHDB
            // 
            this.btnXoaCTHDB.BackColor = System.Drawing.Color.White;
            this.btnXoaCTHDB.Location = new System.Drawing.Point(116, 24);
            this.btnXoaCTHDB.Name = "btnXoaCTHDB";
            this.btnXoaCTHDB.Size = new System.Drawing.Size(190, 23);
            this.btnXoaCTHDB.TabIndex = 18;
            this.btnXoaCTHDB.Text = "Xóa chi tiết hđb";
            this.btnXoaCTHDB.UseVisualStyleBackColor = false;
            // 
            // dgvChiTietHDBan
            // 
            this.dgvChiTietHDBan.AllowUserToAddRows = false;
            this.dgvChiTietHDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHDBan.Location = new System.Drawing.Point(57, 361);
            this.dgvChiTietHDBan.Name = "dgvChiTietHDBan";
            this.dgvChiTietHDBan.ReadOnly = true;
            this.dgvChiTietHDBan.RowHeadersWidth = 51;
            this.dgvChiTietHDBan.RowTemplate.Height = 24;
            this.dgvChiTietHDBan.Size = new System.Drawing.Size(868, 92);
            this.dgvChiTietHDBan.TabIndex = 21;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(841, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 31);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(339, 24);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(96, 23);
            this.btnXuatExcel.TabIndex = 25;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.BackColor = System.Drawing.Color.White;
            this.btnTaiLai.Location = new System.Drawing.Point(13, 23);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(80, 23);
            this.btnTaiLai.TabIndex = 26;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(693, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(142, 22);
            this.txtTimKiem.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnTaiLai);
            this.panel1.Controls.Add(this.btnXuatExcel);
            this.panel1.Controls.Add(this.btnXoaCTHDB);
            this.panel1.Location = new System.Drawing.Point(19, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 63);
            this.panel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tìm theo mã hđb hoặc mã sản phẩm:";
            // 
            // txtMaHoaDonBan
            // 
            this.txtMaHoaDonBan.Location = new System.Drawing.Point(199, 78);
            this.txtMaHoaDonBan.Name = "txtMaHoaDonBan";
            this.txtMaHoaDonBan.ReadOnly = true;
            this.txtMaHoaDonBan.Size = new System.Drawing.Size(153, 22);
            this.txtMaHoaDonBan.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "Danh Sách Hóa Đơn Bán";
            // 
            // dgvHDBan
            // 
            this.dgvHDBan.AllowUserToAddRows = false;
            this.dgvHDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBan.Location = new System.Drawing.Point(57, 236);
            this.dgvHDBan.Name = "dgvHDBan";
            this.dgvHDBan.ReadOnly = true;
            this.dgvHDBan.RowHeadersWidth = 51;
            this.dgvHDBan.RowTemplate.Height = 24;
            this.dgvHDBan.Size = new System.Drawing.Size(868, 119);
            this.dgvHDBan.TabIndex = 32;
            // 
            // nudDonGia
            // 
            this.nudDonGia.Location = new System.Drawing.Point(516, 77);
            this.nudDonGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudDonGia.Name = "nudDonGia";
            this.nudDonGia.ReadOnly = true;
            this.nudDonGia.Size = new System.Drawing.Size(171, 22);
            this.nudDonGia.TabIndex = 33;
            // 
            // nudGiamGia
            // 
            this.nudGiamGia.Location = new System.Drawing.Point(832, 79);
            this.nudGiamGia.Name = "nudGiamGia";
            this.nudGiamGia.ReadOnly = true;
            this.nudGiamGia.Size = new System.Drawing.Size(103, 22);
            this.nudGiamGia.TabIndex = 34;
            // 
            // nudThanhTien
            // 
            this.nudThanhTien.Location = new System.Drawing.Point(516, 128);
            this.nudThanhTien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudThanhTien.Name = "nudThanhTien";
            this.nudThanhTien.ReadOnly = true;
            this.nudThanhTien.Size = new System.Drawing.Size(171, 22);
            this.nudThanhTien.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Mã khách hàng";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(199, 162);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.ReadOnly = true;
            this.txtMaKhachHang.Size = new System.Drawing.Size(153, 22);
            this.txtMaKhachHang.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Ngày bán";
            // 
            // dateNgayBan
            // 
            this.dateNgayBan.Location = new System.Drawing.Point(516, 163);
            this.dateNgayBan.Name = "dateNgayBan";
            this.dateNgayBan.Size = new System.Drawing.Size(196, 22);
            this.dateNgayBan.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(746, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tổng tiền";
            // 
            // nudTongTien
            // 
            this.nudTongTien.Location = new System.Drawing.Point(832, 167);
            this.nudTongTien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTongTien.Name = "nudTongTien";
            this.nudTongTien.ReadOnly = true;
            this.nudTongTien.Size = new System.Drawing.Size(137, 22);
            this.nudTongTien.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Mã nhân viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(199, 199);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(153, 22);
            this.txtMaNhanVien.TabIndex = 43;
            // 
            // InvoiceDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateNgayBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudThanhTien);
            this.Controls.Add(this.nudGiamGia);
            this.Controls.Add(this.nudDonGia);
            this.Controls.Add(this.dgvHDBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHoaDonBan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvChiTietHDBan);
            this.Controls.Add(this.lblthanhtien);
            this.Controls.Add(this.lblgiamgia);
            this.Controls.Add(this.lbldongia);
            this.Controls.Add(this.lblsoLuong);
            this.Controls.Add(this.lblmaSP);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.lblmaHoaDonBan);
            this.Name = "InvoiceDetailControl";
            this.Size = new System.Drawing.Size(972, 536);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDBan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThanhTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblmaHoaDonBan;
    private System.Windows.Forms.TextBox txtMaSanPham;
    private System.Windows.Forms.NumericUpDown nudSoLuong;
    private System.Windows.Forms.Label lblmaSP;
    private System.Windows.Forms.Label lblsoLuong;
    private System.Windows.Forms.Label lbldongia;
    private System.Windows.Forms.Label lblgiamgia;
    private System.Windows.Forms.Label lblthanhtien;
    private System.Windows.Forms.Button btnXoaCTHDB;
    private System.Windows.Forms.DataGridView dgvChiTietHDBan;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.Button btnXuatExcel;
    private System.Windows.Forms.Button btnTaiLai;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtMaHoaDonBan;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView dgvHDBan;
    private System.Windows.Forms.NumericUpDown nudDonGia;
    private System.Windows.Forms.NumericUpDown nudGiamGia;
    private System.Windows.Forms.NumericUpDown nudThanhTien;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtMaKhachHang;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DateTimePicker dateNgayBan;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown nudTongTien;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtMaNhanVien;
  }
}
