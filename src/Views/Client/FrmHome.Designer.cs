using System.Windows.Forms;

namespace WebQLCHQuanAo
{
  partial class FrmHome
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
            this.tcNhanvien = new System.Windows.Forms.TabControl();
            this.tpThongtinNV = new System.Windows.Forms.TabPage();
            this.mskSDT = new System.Windows.Forms.MaskedTextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lbNhanvien = new System.Windows.Forms.Label();
            this.lbChucvu = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnCapNhapNV = new System.Windows.Forms.Button();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.lbDiachiNV = new System.Windows.Forms.Label();
            this.lbSodienthoai = new System.Windows.Forms.Label();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.lbGioitinh = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpDanhsachSP = new System.Windows.Forms.TabPage();
            this.btnTonKho = new System.Windows.Forms.Button();
            this.btnTimkiemSP = new System.Windows.Forms.Button();
            this.txtTimkiemSP = new System.Windows.Forms.TextBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.lbTimkiemSP = new System.Windows.Forms.Label();
            this.lbDanhsachSP = new System.Windows.Forms.Label();
            this.tpTaoHD = new System.Windows.Forms.TabPage();
            this.btnXoaHDT = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.btnLamMoiTaoHD = new System.Windows.Forms.Button();
            this.txbMaKH_TaoHD = new System.Windows.Forms.TextBox();
            this.txbSoHDB = new System.Windows.Forms.TextBox();
            this.lbSoHD = new System.Windows.Forms.Label();
            this.lbMaKH_TaoHD = new System.Windows.Forms.Label();
            this.lbTaoHD = new System.Windows.Forms.Label();
            this.tpQuanlyHD = new System.Windows.Forms.TabPage();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimkiemHD = new System.Windows.Forms.Button();
            this.dtpNgayTimkiemHD = new System.Windows.Forms.DateTimePicker();
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbChitietHD = new System.Windows.Forms.Label();
            this.dgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.lbHDbanhang = new System.Windows.Forms.Label();
            this.dgvHoaDonBan = new System.Windows.Forms.DataGridView();
            this.lbQuanlyHD = new System.Windows.Forms.Label();
            this.tpQuanlyKH = new System.Windows.Forms.TabPage();
            this.btnLamMoiKH = new System.Windows.Forms.Button();
            this.mskSDTKH = new System.Windows.Forms.MaskedTextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnTimkiemKH = new System.Windows.Forms.Button();
            this.dgvDanhsachKH = new System.Windows.Forms.DataGridView();
            this.txtTimkiemKH = new System.Windows.Forms.TextBox();
            this.lbDienthoaiKH = new System.Windows.Forms.Label();
            this.lbTimkiemKH = new System.Windows.Forms.Label();
            this.lbQuanlyKH = new System.Windows.Forms.Label();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcNhanvien.SuspendLayout();
            this.tpThongtinNV.SuspendLayout();
            this.tpDanhsachSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.tpTaoHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.tpQuanlyHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).BeginInit();
            this.tpQuanlyKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachKH)).BeginInit();
            this.SuspendLayout();
            // 
            // tcNhanvien
            // 
            this.tcNhanvien.Controls.Add(this.tpThongtinNV);
            this.tcNhanvien.Controls.Add(this.tpDanhsachSP);
            this.tcNhanvien.Controls.Add(this.tpTaoHD);
            this.tcNhanvien.Controls.Add(this.tpQuanlyHD);
            this.tcNhanvien.Controls.Add(this.tpQuanlyKH);
            this.tcNhanvien.Location = new System.Drawing.Point(4, 7);
            this.tcNhanvien.Name = "tcNhanvien";
            this.tcNhanvien.SelectedIndex = 0;
            this.tcNhanvien.Size = new System.Drawing.Size(804, 537);
            this.tcNhanvien.TabIndex = 0;
            // 
            // tpThongtinNV
            // 
            this.tpThongtinNV.Controls.Add(this.mskSDT);
            this.tpThongtinNV.Controls.Add(this.txtMaNV);
            this.tpThongtinNV.Controls.Add(this.label1);
            this.tpThongtinNV.Controls.Add(this.dtpNgaysinh);
            this.tpThongtinNV.Controls.Add(this.txtTenNV);
            this.tpThongtinNV.Controls.Add(this.lbNhanvien);
            this.tpThongtinNV.Controls.Add(this.lbChucvu);
            this.tpThongtinNV.Controls.Add(this.btnDangXuat);
            this.tpThongtinNV.Controls.Add(this.btnCapNhapNV);
            this.tpThongtinNV.Controls.Add(this.rdoNu);
            this.tpThongtinNV.Controls.Add(this.rdoNam);
            this.tpThongtinNV.Controls.Add(this.txtDiachi);
            this.tpThongtinNV.Controls.Add(this.lbDiachiNV);
            this.tpThongtinNV.Controls.Add(this.lbSodienthoai);
            this.tpThongtinNV.Controls.Add(this.lbNgaysinh);
            this.tpThongtinNV.Controls.Add(this.lbGioitinh);
            this.tpThongtinNV.Controls.Add(this.lbTenNV);
            this.tpThongtinNV.Controls.Add(this.label4);
            this.tpThongtinNV.Location = new System.Drawing.Point(4, 25);
            this.tpThongtinNV.Name = "tpThongtinNV";
            this.tpThongtinNV.Padding = new System.Windows.Forms.Padding(3);
            this.tpThongtinNV.Size = new System.Drawing.Size(796, 508);
            this.tpThongtinNV.TabIndex = 0;
            this.tpThongtinNV.Text = "Thông tin nhân viên";
            this.tpThongtinNV.UseVisualStyleBackColor = true;
            // 
            // mskSDT
            // 
            this.mskSDT.Location = new System.Drawing.Point(298, 252);
            this.mskSDT.Mask = "(999) 000-0000";
            this.mskSDT.Name = "mskSDT";
            this.mskSDT.Size = new System.Drawing.Size(130, 22);
            this.mskSDT.TabIndex = 102;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(298, 80);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(295, 27);
            this.txtMaNV.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 100;
            this.label1.Text = "Mã nhân viên:";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaysinh.Location = new System.Drawing.Point(298, 182);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(295, 27);
            this.dtpNgaysinh.TabIndex = 97;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(298, 113);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(295, 27);
            this.txtTenNV.TabIndex = 94;
            // 
            // lbNhanvien
            // 
            this.lbNhanvien.AutoSize = true;
            this.lbNhanvien.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanvien.Location = new System.Drawing.Point(294, 305);
            this.lbNhanvien.Name = "lbNhanvien";
            this.lbNhanvien.Size = new System.Drawing.Size(74, 22);
            this.lbNhanvien.TabIndex = 93;
            this.lbNhanvien.Text = "Nhân viên";
            // 
            // lbChucvu
            // 
            this.lbChucvu.AutoSize = true;
            this.lbChucvu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucvu.Location = new System.Drawing.Point(182, 305);
            this.lbChucvu.Name = "lbChucvu";
            this.lbChucvu.Size = new System.Drawing.Size(82, 19);
            this.lbChucvu.TabIndex = 92;
            this.lbChucvu.Text = "Chức vụ:";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(452, 378);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(120, 32);
            this.btnDangXuat.TabIndex = 91;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnCapNhapNV
            // 
            this.btnCapNhapNV.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhapNV.Location = new System.Drawing.Point(298, 378);
            this.btnCapNhapNV.Name = "btnCapNhapNV";
            this.btnCapNhapNV.Size = new System.Drawing.Size(102, 32);
            this.btnCapNhapNV.TabIndex = 90;
            this.btnCapNhapNV.Text = "Cập nhật";
            this.btnCapNhapNV.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(470, 150);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(45, 20);
            this.rdoNu.TabIndex = 89;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(329, 151);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(57, 20);
            this.rdoNam.TabIndex = 88;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(298, 215);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(295, 27);
            this.txtDiachi.TabIndex = 99;
            // 
            // lbDiachiNV
            // 
            this.lbDiachiNV.AutoSize = true;
            this.lbDiachiNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiachiNV.Location = new System.Drawing.Point(196, 220);
            this.lbDiachiNV.Name = "lbDiachiNV";
            this.lbDiachiNV.Size = new System.Drawing.Size(68, 19);
            this.lbDiachiNV.TabIndex = 98;
            this.lbDiachiNV.Text = "Địa chỉ:";
            // 
            // lbSodienthoai
            // 
            this.lbSodienthoai.AutoSize = true;
            this.lbSodienthoai.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSodienthoai.Location = new System.Drawing.Point(146, 253);
            this.lbSodienthoai.Name = "lbSodienthoai";
            this.lbSodienthoai.Size = new System.Drawing.Size(118, 19);
            this.lbSodienthoai.TabIndex = 86;
            this.lbSodienthoai.Text = "Số điện thoại:";
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaysinh.Location = new System.Drawing.Point(171, 188);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(93, 19);
            this.lbNgaysinh.TabIndex = 85;
            this.lbNgaysinh.Text = "Ngày sinh:";
            // 
            // lbGioitinh
            // 
            this.lbGioitinh.AutoSize = true;
            this.lbGioitinh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioitinh.Location = new System.Drawing.Point(181, 151);
            this.lbGioitinh.Name = "lbGioitinh";
            this.lbGioitinh.Size = new System.Drawing.Size(83, 19);
            this.lbGioitinh.TabIndex = 84;
            this.lbGioitinh.Text = "Giới tính:";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.Location = new System.Drawing.Point(139, 118);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(125, 19);
            this.lbTenNV.TabIndex = 83;
            this.lbTenNV.Text = "Tên nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 38);
            this.label4.TabIndex = 82;
            this.label4.Text = "Thông tin cá nhân";
            // 
            // tpDanhsachSP
            // 
            this.tpDanhsachSP.Controls.Add(this.btnTonKho);
            this.tpDanhsachSP.Controls.Add(this.btnTimkiemSP);
            this.tpDanhsachSP.Controls.Add(this.txtTimkiemSP);
            this.tpDanhsachSP.Controls.Add(this.dgvSanPham);
            this.tpDanhsachSP.Controls.Add(this.lbTimkiemSP);
            this.tpDanhsachSP.Controls.Add(this.lbDanhsachSP);
            this.tpDanhsachSP.Location = new System.Drawing.Point(4, 25);
            this.tpDanhsachSP.Name = "tpDanhsachSP";
            this.tpDanhsachSP.Padding = new System.Windows.Forms.Padding(3);
            this.tpDanhsachSP.Size = new System.Drawing.Size(796, 508);
            this.tpDanhsachSP.TabIndex = 1;
            this.tpDanhsachSP.Text = "Danh sách sản phẩm";
            this.tpDanhsachSP.UseVisualStyleBackColor = true;
            // 
            // btnTonKho
            // 
            this.btnTonKho.Location = new System.Drawing.Point(674, 66);
            this.btnTonKho.Name = "btnTonKho";
            this.btnTonKho.Size = new System.Drawing.Size(96, 32);
            this.btnTonKho.TabIndex = 86;
            this.btnTonKho.Text = "Tồn kho";
            this.btnTonKho.UseVisualStyleBackColor = true;
            // 
            // btnTimkiemSP
            // 
            this.btnTimkiemSP.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemSP.Location = new System.Drawing.Point(574, 66);
            this.btnTimkiemSP.Name = "btnTimkiemSP";
            this.btnTimkiemSP.Size = new System.Drawing.Size(87, 32);
            this.btnTimkiemSP.TabIndex = 85;
            this.btnTimkiemSP.Text = "Tìm kiếm";
            this.btnTimkiemSP.UseVisualStyleBackColor = true;
            // 
            // txtTimkiemSP
            // 
            this.txtTimkiemSP.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiemSP.Location = new System.Drawing.Point(236, 68);
            this.txtTimkiemSP.Name = "txtTimkiemSP";
            this.txtTimkiemSP.Size = new System.Drawing.Size(295, 27);
            this.txtTimkiemSP.TabIndex = 84;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(27, 123);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(743, 361);
            this.dgvSanPham.TabIndex = 83;
            // 
            // lbTimkiemSP
            // 
            this.lbTimkiemSP.AutoSize = true;
            this.lbTimkiemSP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimkiemSP.Location = new System.Drawing.Point(125, 73);
            this.lbTimkiemSP.Name = "lbTimkiemSP";
            this.lbTimkiemSP.Size = new System.Drawing.Size(84, 19);
            this.lbTimkiemSP.TabIndex = 82;
            this.lbTimkiemSP.Text = "Tìm kiếm:";
            // 
            // lbDanhsachSP
            // 
            this.lbDanhsachSP.AutoSize = true;
            this.lbDanhsachSP.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhsachSP.Location = new System.Drawing.Point(210, 25);
            this.lbDanhsachSP.Name = "lbDanhsachSP";
            this.lbDanhsachSP.Size = new System.Drawing.Size(342, 38);
            this.lbDanhsachSP.TabIndex = 81;
            this.lbDanhsachSP.Text = "Danh sách sản phẩm";
            // 
            // tpTaoHD
            // 
            this.tpTaoHD.Controls.Add(this.btnXoaHDT);
            this.tpTaoHD.Controls.Add(this.btnThemSanPham);
            this.tpTaoHD.Controls.Add(this.txtTongTien);
            this.tpTaoHD.Controls.Add(this.label16);
            this.tpTaoHD.Controls.Add(this.dgvSP);
            this.tpTaoHD.Controls.Add(this.lbTongtien);
            this.tpTaoHD.Controls.Add(this.btnTaoHD);
            this.tpTaoHD.Controls.Add(this.btnLamMoiTaoHD);
            this.tpTaoHD.Controls.Add(this.txbMaKH_TaoHD);
            this.tpTaoHD.Controls.Add(this.txbSoHDB);
            this.tpTaoHD.Controls.Add(this.lbSoHD);
            this.tpTaoHD.Controls.Add(this.lbMaKH_TaoHD);
            this.tpTaoHD.Controls.Add(this.lbTaoHD);
            this.tpTaoHD.Location = new System.Drawing.Point(4, 25);
            this.tpTaoHD.Name = "tpTaoHD";
            this.tpTaoHD.Padding = new System.Windows.Forms.Padding(3);
            this.tpTaoHD.Size = new System.Drawing.Size(796, 508);
            this.tpTaoHD.TabIndex = 2;
            this.tpTaoHD.Text = "Tạo hóa đơn";
            this.tpTaoHD.UseVisualStyleBackColor = true;
            // 
            // btnXoaHDT
            // 
            this.btnXoaHDT.Location = new System.Drawing.Point(117, 238);
            this.btnXoaHDT.Name = "btnXoaHDT";
            this.btnXoaHDT.Size = new System.Drawing.Size(75, 31);
            this.btnXoaHDT.TabIndex = 134;
            this.btnXoaHDT.Text = "Xóa";
            this.btnXoaHDT.UseVisualStyleBackColor = true;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Location = new System.Drawing.Point(20, 238);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(75, 31);
            this.btnThemSanPham.TabIndex = 133;
            this.btnThemSanPham.Text = "Thêm";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(518, 79);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(229, 27);
            this.txtTongTien.TabIndex = 131;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 19);
            this.label16.TabIndex = 124;
            this.label16.Text = "Chi tiết sản phẩm:";
            // 
            // dgvSP
            // 
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(20, 275);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.Size = new System.Drawing.Size(758, 162);
            this.dgvSP.TabIndex = 21;
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.Location = new System.Drawing.Point(413, 80);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(89, 19);
            this.lbTongtien.TabIndex = 117;
            this.lbTongtien.Text = "Tổng tiền:";
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHD.Location = new System.Drawing.Point(184, 461);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(112, 32);
            this.btnTaoHD.TabIndex = 116;
            this.btnTaoHD.Text = "Tạo";
            this.btnTaoHD.UseVisualStyleBackColor = true;
            // 
            // btnLamMoiTaoHD
            // 
            this.btnLamMoiTaoHD.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiTaoHD.Location = new System.Drawing.Point(487, 461);
            this.btnLamMoiTaoHD.Name = "btnLamMoiTaoHD";
            this.btnLamMoiTaoHD.Size = new System.Drawing.Size(102, 32);
            this.btnLamMoiTaoHD.TabIndex = 115;
            this.btnLamMoiTaoHD.Text = "Làm mới";
            this.btnLamMoiTaoHD.UseVisualStyleBackColor = true;
            // 
            // txbMaKH_TaoHD
            // 
            this.txbMaKH_TaoHD.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaKH_TaoHD.Location = new System.Drawing.Point(131, 123);
            this.txbMaKH_TaoHD.Name = "txbMaKH_TaoHD";
            this.txbMaKH_TaoHD.Size = new System.Drawing.Size(237, 27);
            this.txbMaKH_TaoHD.TabIndex = 114;
            // 
            // txbSoHDB
            // 
            this.txbSoHDB.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoHDB.HideSelection = false;
            this.txbSoHDB.Location = new System.Drawing.Point(131, 72);
            this.txbSoHDB.Name = "txbSoHDB";
            this.txbSoHDB.ReadOnly = true;
            this.txbSoHDB.Size = new System.Drawing.Size(237, 27);
            this.txbSoHDB.TabIndex = 113;
            // 
            // lbSoHD
            // 
            this.lbSoHD.AutoSize = true;
            this.lbSoHD.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoHD.Location = new System.Drawing.Point(49, 77);
            this.lbSoHD.Name = "lbSoHD";
            this.lbSoHD.Size = new System.Drawing.Size(65, 19);
            this.lbSoHD.TabIndex = 112;
            this.lbSoHD.Text = "Số HĐ:";
            // 
            // lbMaKH_TaoHD
            // 
            this.lbMaKH_TaoHD.AutoSize = true;
            this.lbMaKH_TaoHD.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH_TaoHD.Location = new System.Drawing.Point(49, 128);
            this.lbMaKH_TaoHD.Name = "lbMaKH_TaoHD";
            this.lbMaKH_TaoHD.Size = new System.Drawing.Size(66, 19);
            this.lbMaKH_TaoHD.TabIndex = 111;
            this.lbMaKH_TaoHD.Text = "Mã KH:";
            // 
            // lbTaoHD
            // 
            this.lbTaoHD.AutoSize = true;
            this.lbTaoHD.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaoHD.Location = new System.Drawing.Point(286, 16);
            this.lbTaoHD.Name = "lbTaoHD";
            this.lbTaoHD.Size = new System.Drawing.Size(216, 38);
            this.lbTaoHD.TabIndex = 110;
            this.lbTaoHD.Text = "Tạo hóa đơn";
            // 
            // tpQuanlyHD
            // 
            this.tpQuanlyHD.Controls.Add(this.btnLamMoi);
            this.tpQuanlyHD.Controls.Add(this.btnTimkiemHD);
            this.tpQuanlyHD.Controls.Add(this.dtpNgayTimkiemHD);
            this.tpQuanlyHD.Controls.Add(this.lbNgay);
            this.tpQuanlyHD.Controls.Add(this.lbChitietHD);
            this.tpQuanlyHD.Controls.Add(this.dgvChiTietHD);
            this.tpQuanlyHD.Controls.Add(this.lbHDbanhang);
            this.tpQuanlyHD.Controls.Add(this.dgvHoaDonBan);
            this.tpQuanlyHD.Controls.Add(this.lbQuanlyHD);
            this.tpQuanlyHD.Location = new System.Drawing.Point(4, 25);
            this.tpQuanlyHD.Name = "tpQuanlyHD";
            this.tpQuanlyHD.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanlyHD.Size = new System.Drawing.Size(796, 508);
            this.tpQuanlyHD.TabIndex = 3;
            this.tpQuanlyHD.Text = "Quản lý hóa đơn";
            this.tpQuanlyHD.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(679, 93);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(91, 32);
            this.btnLamMoi.TabIndex = 91;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnTimkiemHD
            // 
            this.btnTimkiemHD.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemHD.Location = new System.Drawing.Point(567, 93);
            this.btnTimkiemHD.Name = "btnTimkiemHD";
            this.btnTimkiemHD.Size = new System.Drawing.Size(87, 32);
            this.btnTimkiemHD.TabIndex = 90;
            this.btnTimkiemHD.Text = "Tìm kiếm";
            this.btnTimkiemHD.UseVisualStyleBackColor = true;
            // 
            // dtpNgayTimkiemHD
            // 
            this.dtpNgayTimkiemHD.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTimkiemHD.Location = new System.Drawing.Point(243, 94);
            this.dtpNgayTimkiemHD.Name = "dtpNgayTimkiemHD";
            this.dtpNgayTimkiemHD.Size = new System.Drawing.Size(280, 27);
            this.dtpNgayTimkiemHD.TabIndex = 89;
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Location = new System.Drawing.Point(158, 100);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(55, 19);
            this.lbNgay.TabIndex = 87;
            this.lbNgay.Text = "Ngày:";
            // 
            // lbChitietHD
            // 
            this.lbChitietHD.AutoSize = true;
            this.lbChitietHD.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChitietHD.Location = new System.Drawing.Point(27, 324);
            this.lbChitietHD.Name = "lbChitietHD";
            this.lbChitietHD.Size = new System.Drawing.Size(142, 19);
            this.lbChitietHD.TabIndex = 86;
            this.lbChitietHD.Text = "Chi tiết hóa đơn:";
            // 
            // dgvChiTietHD
            // 
            this.dgvChiTietHD.AllowUserToAddRows = false;
            this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHD.Location = new System.Drawing.Point(31, 346);
            this.dgvChiTietHD.Name = "dgvChiTietHD";
            this.dgvChiTietHD.ReadOnly = true;
            this.dgvChiTietHD.RowHeadersWidth = 51;
            this.dgvChiTietHD.RowTemplate.Height = 24;
            this.dgvChiTietHD.Size = new System.Drawing.Size(739, 150);
            this.dgvChiTietHD.TabIndex = 85;
            // 
            // lbHDbanhang
            // 
            this.lbHDbanhang.AutoSize = true;
            this.lbHDbanhang.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHDbanhang.Location = new System.Drawing.Point(27, 143);
            this.lbHDbanhang.Name = "lbHDbanhang";
            this.lbHDbanhang.Size = new System.Drawing.Size(161, 19);
            this.lbHDbanhang.TabIndex = 84;
            this.lbHDbanhang.Text = "Hóa đơn bán hàng:";
            // 
            // dgvHoaDonBan
            // 
            this.dgvHoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonBan.Location = new System.Drawing.Point(31, 165);
            this.dgvHoaDonBan.Name = "dgvHoaDonBan";
            this.dgvHoaDonBan.ReadOnly = true;
            this.dgvHoaDonBan.RowHeadersWidth = 51;
            this.dgvHoaDonBan.RowTemplate.Height = 24;
            this.dgvHoaDonBan.Size = new System.Drawing.Size(739, 146);
            this.dgvHoaDonBan.TabIndex = 83;
            // 
            // lbQuanlyHD
            // 
            this.lbQuanlyHD.AutoSize = true;
            this.lbQuanlyHD.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanlyHD.Location = new System.Drawing.Point(236, 13);
            this.lbQuanlyHD.Name = "lbQuanlyHD";
            this.lbQuanlyHD.Size = new System.Drawing.Size(277, 38);
            this.lbQuanlyHD.TabIndex = 81;
            this.lbQuanlyHD.Text = "Quản lý hóa đơn";
            // 
            // tpQuanlyKH
            // 
            this.tpQuanlyKH.Controls.Add(this.btnLamMoiKH);
            this.tpQuanlyKH.Controls.Add(this.mskSDTKH);
            this.tpQuanlyKH.Controls.Add(this.txtTenKH);
            this.tpQuanlyKH.Controls.Add(this.lbTenKH);
            this.tpQuanlyKH.Controls.Add(this.btnThemKH);
            this.tpQuanlyKH.Controls.Add(this.btnTimkiemKH);
            this.tpQuanlyKH.Controls.Add(this.dgvDanhsachKH);
            this.tpQuanlyKH.Controls.Add(this.txtTimkiemKH);
            this.tpQuanlyKH.Controls.Add(this.lbDienthoaiKH);
            this.tpQuanlyKH.Controls.Add(this.lbTimkiemKH);
            this.tpQuanlyKH.Controls.Add(this.lbQuanlyKH);
            this.tpQuanlyKH.Location = new System.Drawing.Point(4, 25);
            this.tpQuanlyKH.Name = "tpQuanlyKH";
            this.tpQuanlyKH.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanlyKH.Size = new System.Drawing.Size(796, 508);
            this.tpQuanlyKH.TabIndex = 4;
            this.tpQuanlyKH.Text = "Quản lý khách hàng";
            this.tpQuanlyKH.UseVisualStyleBackColor = true;
            // 
            // btnLamMoiKH
            // 
            this.btnLamMoiKH.Location = new System.Drawing.Point(424, 142);
            this.btnLamMoiKH.Name = "btnLamMoiKH";
            this.btnLamMoiKH.Size = new System.Drawing.Size(90, 32);
            this.btnLamMoiKH.TabIndex = 96;
            this.btnLamMoiKH.Text = "Làm Mới";
            this.btnLamMoiKH.UseVisualStyleBackColor = true;
            // 
            // mskSDTKH
            // 
            this.mskSDTKH.Location = new System.Drawing.Point(533, 63);
            this.mskSDTKH.Mask = "(999) 000-0000";
            this.mskSDTKH.Name = "mskSDTKH";
            this.mskSDTKH.Size = new System.Drawing.Size(232, 22);
            this.mskSDTKH.TabIndex = 95;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(173, 63);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(216, 27);
            this.txtTenKH.TabIndex = 94;
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.Location = new System.Drawing.Point(10, 68);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(140, 19);
            this.lbTenKH.TabIndex = 93;
            this.lbTenKH.Text = "Tên khách hàng:";
            // 
            // btnThemKH
            // 
            this.btnThemKH.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.Location = new System.Drawing.Point(291, 142);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(87, 32);
            this.btnThemKH.TabIndex = 92;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            // 
            // btnTimkiemKH
            // 
            this.btnTimkiemKH.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemKH.Location = new System.Drawing.Point(592, 195);
            this.btnTimkiemKH.Name = "btnTimkiemKH";
            this.btnTimkiemKH.Size = new System.Drawing.Size(87, 32);
            this.btnTimkiemKH.TabIndex = 91;
            this.btnTimkiemKH.Text = "Tìm kiếm";
            this.btnTimkiemKH.UseVisualStyleBackColor = true;
            // 
            // dgvDanhsachKH
            // 
            this.dgvDanhsachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachKH.Location = new System.Drawing.Point(14, 243);
            this.dgvDanhsachKH.Name = "dgvDanhsachKH";
            this.dgvDanhsachKH.RowHeadersWidth = 51;
            this.dgvDanhsachKH.RowTemplate.Height = 24;
            this.dgvDanhsachKH.Size = new System.Drawing.Size(772, 249);
            this.dgvDanhsachKH.TabIndex = 90;
            // 
            // txtTimkiemKH
            // 
            this.txtTimkiemKH.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiemKH.Location = new System.Drawing.Point(251, 197);
            this.txtTimkiemKH.Name = "txtTimkiemKH";
            this.txtTimkiemKH.Size = new System.Drawing.Size(295, 27);
            this.txtTimkiemKH.TabIndex = 89;
            // 
            // lbDienthoaiKH
            // 
            this.lbDienthoaiKH.AutoSize = true;
            this.lbDienthoaiKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDienthoaiKH.Location = new System.Drawing.Point(420, 67);
            this.lbDienthoaiKH.Name = "lbDienthoaiKH";
            this.lbDienthoaiKH.Size = new System.Drawing.Size(94, 19);
            this.lbDienthoaiKH.TabIndex = 85;
            this.lbDienthoaiKH.Text = "Điện thoại:";
            // 
            // lbTimkiemKH
            // 
            this.lbTimkiemKH.AutoSize = true;
            this.lbTimkiemKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimkiemKH.Location = new System.Drawing.Point(70, 202);
            this.lbTimkiemKH.Name = "lbTimkiemKH";
            this.lbTimkiemKH.Size = new System.Drawing.Size(154, 19);
            this.lbTimkiemKH.TabIndex = 82;
            this.lbTimkiemKH.Text = "Tìm kiếm theo sđt:";
            // 
            // lbQuanlyKH
            // 
            this.lbQuanlyKH.AutoSize = true;
            this.lbQuanlyKH.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanlyKH.Location = new System.Drawing.Point(219, 16);
            this.lbQuanlyKH.Name = "lbQuanlyKH";
            this.lbQuanlyKH.Size = new System.Drawing.Size(327, 38);
            this.lbQuanlyKH.TabIndex = 81;
            this.lbQuanlyKH.Text = "Quản lý khách hàng";
            // 
            // colMaSP
            // 
            this.colMaSP.HeaderText = "Mã SP";
            this.colMaSP.MinimumWidth = 6;
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Width = 125;
            // 
            // colTenSP
            // 
            this.colTenSP.HeaderText = "Tên SP";
            this.colTenSP.MinimumWidth = 6;
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Width = 125;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 125;
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Width = 125;
            // 
            // colGiamGia
            // 
            this.colGiamGia.HeaderText = "Giảm Giá (%)";
            this.colGiamGia.MinimumWidth = 6;
            this.colGiamGia.Name = "colGiamGia";
            this.colGiamGia.Width = 125;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Width = 125;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 547);
            this.Controls.Add(this.tcNhanvien);
            this.Name = "FrmHome";
            this.Text = "Nhân viên";
            this.tcNhanvien.ResumeLayout(false);
            this.tpThongtinNV.ResumeLayout(false);
            this.tpThongtinNV.PerformLayout();
            this.tpDanhsachSP.ResumeLayout(false);
            this.tpDanhsachSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.tpTaoHD.ResumeLayout(false);
            this.tpTaoHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.tpQuanlyHD.ResumeLayout(false);
            this.tpQuanlyHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).EndInit();
            this.tpQuanlyKH.ResumeLayout(false);
            this.tpQuanlyKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachKH)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tcNhanvien;
    private System.Windows.Forms.TabPage tpThongtinNV;
    private System.Windows.Forms.DateTimePicker dtpNgaysinh;
    private System.Windows.Forms.TextBox txtTenNV;
    private System.Windows.Forms.Label lbNhanvien;
    private System.Windows.Forms.Label lbChucvu;
    private System.Windows.Forms.Button btnDangXuat;
    private System.Windows.Forms.Button btnCapNhapNV;
    private System.Windows.Forms.RadioButton rdoNu;
    private System.Windows.Forms.RadioButton rdoNam;
    private System.Windows.Forms.Label lbSodienthoai;
    private System.Windows.Forms.Label lbNgaysinh;
    private System.Windows.Forms.Label lbGioitinh;
    private System.Windows.Forms.Label lbTenNV;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TabPage tpDanhsachSP;
    private System.Windows.Forms.Button btnTimkiemSP;
    private System.Windows.Forms.TextBox txtTimkiemSP;
    private System.Windows.Forms.DataGridView dgvSanPham;
    private System.Windows.Forms.Label lbTimkiemSP;
    private System.Windows.Forms.Label lbDanhsachSP;
    private System.Windows.Forms.TabPage tpTaoHD;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.DataGridView dgvSP;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
    private System.Windows.Forms.DataGridViewTextBoxColumn colGiamGia;
    private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    private System.Windows.Forms.Label lbTongtien;
    private System.Windows.Forms.Button btnTaoHD;
    private System.Windows.Forms.Button btnLamMoiTaoHD;
    private System.Windows.Forms.TextBox txbMaKH_TaoHD;
    private System.Windows.Forms.TextBox txbSoHDB;
    private System.Windows.Forms.Label lbSoHD;
    private System.Windows.Forms.Label lbMaKH_TaoHD;
    private System.Windows.Forms.Label lbTaoHD;
    private System.Windows.Forms.TabPage tpQuanlyHD;
    private System.Windows.Forms.Button btnTimkiemHD;
    private System.Windows.Forms.DateTimePicker dtpNgayTimkiemHD;
    private System.Windows.Forms.Label lbNgay;
    private System.Windows.Forms.Label lbChitietHD;
    private System.Windows.Forms.Label lbHDbanhang;
    private System.Windows.Forms.DataGridView dgvHoaDonBan;
    private System.Windows.Forms.Label lbQuanlyHD;
    private System.Windows.Forms.TabPage tpQuanlyKH;
    private System.Windows.Forms.Button btnThemKH;
    private System.Windows.Forms.Button btnTimkiemKH;
    private System.Windows.Forms.DataGridView dgvDanhsachKH;
    private System.Windows.Forms.TextBox txtTimkiemKH;
    private System.Windows.Forms.Label lbTimkiemKH;
    private System.Windows.Forms.Label lbQuanlyKH;
    private System.Windows.Forms.Label lbDienthoaiKH;
    private System.Windows.Forms.TextBox txtTenKH;
    private System.Windows.Forms.Label lbTenKH;
    private System.Windows.Forms.TextBox txtDiachi;
    private System.Windows.Forms.Label lbDiachiNV;
    private System.Windows.Forms.TextBox txtMaNV;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dgvChiTietHD;
    private System.Windows.Forms.TextBox txtTongTien;
    private Button btnThemSanPham;
    private Button btnXoaHDT;
    private MaskedTextBox mskSDT;
    private Button btnLamMoi;
    private MaskedTextBox mskSDTKH;
    private Button btnLamMoiKH;
    private Button btnTonKho;
  }
}