namespace BTL_C_.src.Views.Admin
{
  partial class PurchaseInvoiceControl
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
            this.lblMaHDN = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cmbMaNCC = new System.Windows.Forms.ComboBox();
            this.dgvHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXuatExcelHDN = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cmbLocNCC = new System.Windows.Forms.ComboBox();
            this.lblLoctheoNCC = new System.Windows.Forms.Label();
            this.lblLocTuNgay = new System.Windows.Forms.Label();
            this.lblLocDenNgay = new System.Windows.Forms.Label();
            this.dtpLocTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpLocDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dgvChiTietHDN = new System.Windows.Forms.DataGridView();
            this.nudTongTien = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDonGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.btnXuatExcelCTHDN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaHDN
            // 
            this.lblMaHDN.AutoSize = true;
            this.lblMaHDN.Location = new System.Drawing.Point(19, 19);
            this.lblMaHDN.Name = "lblMaHDN";
            this.lblMaHDN.Size = new System.Drawing.Size(111, 16);
            this.lblMaHDN.TabIndex = 0;
            this.lblMaHDN.Text = "Mã hóa đơn nhập";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(19, 48);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(73, 16);
            this.lblNgayNhap.TabIndex = 2;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(428, 48);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(90, 16);
            this.lblMaNCC.TabIndex = 3;
            this.lblMaNCC.Text = "Nhà cung cấp";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(428, 16);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(63, 16);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(156, 16);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(233, 22);
            this.txtMaHDN.TabIndex = 8;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(156, 48);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(233, 22);
            this.dtpNgayNhap.TabIndex = 13;
            // 
            // cmbMaNCC
            // 
            this.cmbMaNCC.FormattingEnabled = true;
            this.cmbMaNCC.Location = new System.Drawing.Point(532, 40);
            this.cmbMaNCC.Name = "cmbMaNCC";
            this.cmbMaNCC.Size = new System.Drawing.Size(232, 24);
            this.cmbMaNCC.TabIndex = 14;
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonNhap.Location = new System.Drawing.Point(108, 119);
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.ReadOnly = true;
            this.dgvHoaDonNhap.RowHeadersWidth = 51;
            this.dgvHoaDonNhap.RowTemplate.Height = 24;
            this.dgvHoaDonNhap.Size = new System.Drawing.Size(753, 130);
            this.dgvHoaDonNhap.TabIndex = 16;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(601, 486);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(110, 33);
            this.btnTao.TabIndex = 17;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(467, 486);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 33);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(62, 486);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 33);
            this.btnLamMoi.TabIndex = 23;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXuatExcelHDN
            // 
            this.btnXuatExcelHDN.Location = new System.Drawing.Point(190, 486);
            this.btnXuatExcelHDN.Name = "btnXuatExcelHDN";
            this.btnXuatExcelHDN.Size = new System.Drawing.Size(111, 33);
            this.btnXuatExcelHDN.TabIndex = 25;
            this.btnXuatExcelHDN.Text = "Xuất HĐN";
            this.btnXuatExcelHDN.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(346, 486);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(87, 33);
            this.btnLoc.TabIndex = 26;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // cmbLocNCC
            // 
            this.cmbLocNCC.FormattingEnabled = true;
            this.cmbLocNCC.Location = new System.Drawing.Point(156, 421);
            this.cmbLocNCC.Name = "cmbLocNCC";
            this.cmbLocNCC.Size = new System.Drawing.Size(145, 24);
            this.cmbLocNCC.TabIndex = 27;
            // 
            // lblLoctheoNCC
            // 
            this.lblLoctheoNCC.AutoSize = true;
            this.lblLoctheoNCC.Location = new System.Drawing.Point(31, 421);
            this.lblLoctheoNCC.Name = "lblLoctheoNCC";
            this.lblLoctheoNCC.Size = new System.Drawing.Size(89, 16);
            this.lblLoctheoNCC.TabIndex = 28;
            this.lblLoctheoNCC.Text = "Lọc theo NCC";
            // 
            // lblLocTuNgay
            // 
            this.lblLocTuNgay.AutoSize = true;
            this.lblLocTuNgay.Location = new System.Drawing.Point(527, 392);
            this.lblLocTuNgay.Name = "lblLocTuNgay";
            this.lblLocTuNgay.Size = new System.Drawing.Size(75, 16);
            this.lblLocTuNgay.TabIndex = 33;
            this.lblLocTuNgay.Text = "Lọc từ ngày";
            // 
            // lblLocDenNgay
            // 
            this.lblLocDenNgay.AutoSize = true;
            this.lblLocDenNgay.Location = new System.Drawing.Point(529, 442);
            this.lblLocDenNgay.Name = "lblLocDenNgay";
            this.lblLocDenNgay.Size = new System.Drawing.Size(88, 16);
            this.lblLocDenNgay.TabIndex = 34;
            this.lblLocDenNgay.Text = "Lọc đến ngày";
            // 
            // dtpLocTuNgay
            // 
            this.dtpLocTuNgay.Location = new System.Drawing.Point(654, 392);
            this.dtpLocTuNgay.Name = "dtpLocTuNgay";
            this.dtpLocTuNgay.Size = new System.Drawing.Size(243, 22);
            this.dtpLocTuNgay.TabIndex = 35;
            // 
            // dtpLocDenNgay
            // 
            this.dtpLocDenNgay.Location = new System.Drawing.Point(654, 437);
            this.dtpLocDenNgay.Name = "dtpLocDenNgay";
            this.dtpLocDenNgay.Size = new System.Drawing.Size(243, 22);
            this.dtpLocDenNgay.TabIndex = 36;
            // 
            // dgvChiTietHDN
            // 
            this.dgvChiTietHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHDN.Location = new System.Drawing.Point(108, 255);
            this.dgvChiTietHDN.Name = "dgvChiTietHDN";
            this.dgvChiTietHDN.ReadOnly = true;
            this.dgvChiTietHDN.RowHeadersWidth = 51;
            this.dgvChiTietHDN.RowTemplate.Height = 24;
            this.dgvChiTietHDN.Size = new System.Drawing.Size(753, 102);
            this.dgvChiTietHDN.TabIndex = 37;
            // 
            // nudTongTien
            // 
            this.nudTongTien.Location = new System.Drawing.Point(532, 11);
            this.nudTongTien.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudTongTien.Name = "nudTongTien";
            this.nudTongTien.Size = new System.Drawing.Size(232, 22);
            this.nudTongTien.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Đơn giá";
            // 
            // nudDonGiaNhap
            // 
            this.nudDonGiaNhap.Location = new System.Drawing.Point(156, 81);
            this.nudDonGiaNhap.Maximum = new decimal(new int[] {
            500000000,
            0,
            0,
            0});
            this.nudDonGiaNhap.Name = "nudDonGiaNhap";
            this.nudDonGiaNhap.Size = new System.Drawing.Size(174, 22);
            this.nudDonGiaNhap.TabIndex = 46;
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Location = new System.Drawing.Point(34, 388);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(64, 16);
            this.lblThongKe.TabIndex = 47;
            this.lblThongKe.Text = "Thống kê";
            // 
            // btnXuatExcelCTHDN
            // 
            this.btnXuatExcelCTHDN.Location = new System.Drawing.Point(759, 486);
            this.btnXuatExcelCTHDN.Name = "btnXuatExcelCTHDN";
            this.btnXuatExcelCTHDN.Size = new System.Drawing.Size(138, 33);
            this.btnXuatExcelCTHDN.TabIndex = 21;
            this.btnXuatExcelCTHDN.Text = "Xuất CTHĐN";
            this.btnXuatExcelCTHDN.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(532, 81);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(232, 22);
            this.txtGhiChu.TabIndex = 49;
            // 
            // PurchaseInvoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblThongKe);
            this.Controls.Add(this.nudDonGiaNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudTongTien);
            this.Controls.Add(this.dgvChiTietHDN);
            this.Controls.Add(this.dtpLocDenNgay);
            this.Controls.Add(this.dtpLocTuNgay);
            this.Controls.Add(this.lblLocDenNgay);
            this.Controls.Add(this.lblLocTuNgay);
            this.Controls.Add(this.lblLoctheoNCC);
            this.Controls.Add(this.cmbLocNCC);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.btnXuatExcelHDN);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXuatExcelCTHDN);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.dgvHoaDonNhap);
            this.Controls.Add(this.cmbMaNCC);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.txtMaHDN);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblMaNCC);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.lblMaHDN);
            this.Name = "PurchaseInvoiceControl";
            this.Size = new System.Drawing.Size(972, 536);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblMaHDN;
    private System.Windows.Forms.Label lblNgayNhap;
    private System.Windows.Forms.Label lblMaNCC;
    private System.Windows.Forms.Label lblTongTien;
    private System.Windows.Forms.TextBox txtMaHDN;
    private System.Windows.Forms.DateTimePicker dtpNgayNhap;
    private System.Windows.Forms.ComboBox cmbMaNCC;
    private System.Windows.Forms.DataGridView dgvHoaDonNhap;
    private System.Windows.Forms.Button btnTao;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Button btnXuatExcelHDN;
    private System.Windows.Forms.Button btnLoc;
    private System.Windows.Forms.ComboBox cmbLocNCC;
    private System.Windows.Forms.Label lblLoctheoNCC;
    private System.Windows.Forms.Label lblLocTuNgay;
    private System.Windows.Forms.Label lblLocDenNgay;
    private System.Windows.Forms.DateTimePicker dtpLocTuNgay;
    private System.Windows.Forms.DateTimePicker dtpLocDenNgay;
    private System.Windows.Forms.DataGridView dgvChiTietHDN;
    private System.Windows.Forms.NumericUpDown nudTongTien;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown nudDonGiaNhap;
    private System.Windows.Forms.Label lblThongKe;
    private System.Windows.Forms.Button btnXuatExcelCTHDN;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtGhiChu;
  }
}
