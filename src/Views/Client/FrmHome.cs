using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTL_C_.src.Models;

namespace WebQLCHQuanAo
{
  public partial class FrmHome : Form
  {
    //private NhanVienController nhanVienController;
    //private SanPhamController sanPhamController;
    //private HoaDonBanController hoaDonBanController;
    //private KhachHangController khachHangController;

    // Dùng cho tab Tạo Hóa Đơn
    //private List<ChiTietHoaDonBan> currentChiTietHoaDonList; // Lưu trữ chi tiết hóa đơn hiện tại

    public FrmHome()
    {
      InitializeComponent();
      //nhanVienController = new NhanVienController();
      //sanPhamController = new SanPhamController();
      //hoaDonBanController = new HoaDonBanController();
      //khachHangController = new KhachHangController();
      //SetupDanhSachSPTab();
      //SetupTaoHDTab();
      //SetupQuanLyHDTab();
      //SetupQuanLyKHTab();

      //// Load dữ liệu ban đầu
      //LoadAllInitialData();
    }

    //private void LoadAllInitialData()
    //{
    //  LoadDanhSachSanPham(); // Cho tab Danh sách SP
    //  LoadDanhSachHoaDonBan(); // Cho tab Quản lý HD
    //  LoadDanhSachKhachHang(); // Cho tab Quản lý KH
    //                           // Các dữ liệu khác nếu cần
    //}
    public void SetLamMoiTabTaoHoaDonListener(EventHandler handler) => btnLamMoiTaoHD.Click += handler;
    //// --- Helper Methods to Clear Inputs ---
    public void ClearThongTinNVFields()
    {
      txbDiachi.Clear();
      txbTenNV.Clear();
      dtpNgaysinh.Value = DateTime.Now;
      rdoNam.Checked = true; // Default
      rdoNu.Checked = false;
      txbDiachi.Clear();
      txbSodienthoai.Clear();
      txbEmail.Clear();
    }

    //private void ClearTaoHDFields()
    //{
    //  txbSoHDB.Text = hoaDonBanController.GenerateNewSoHDB(); // Sinh mã mới cho hóa đơn
    //  txbMaNV_TaoHD.Clear(); // Giữ nguyên nếu NV hiện tại luôn lập hóa đơn
    //  txbMaKH_TaoHD.Clear();
    //  dtpNgayban.Value = DateTime.Now;
    //  currentChiTietHoaDonList.Clear();
    //  dgvChiTietHoaDonban.DataSource = null; // Clear DataGridView
    //  dgvChiTietHoaDonban.Rows.Clear(); // Đảm bảo DataGridView trống rỗng
    //  txbTongtien.Text = "0.00";
    //}

    public void ClearQuanLyKHFields()
    {
      txbMaKH.Clear();
      txbTenKH.Clear();
      txbDiachiKH.Clear();
      txbSdtKH.Clear();
      txbTimkiemKH.Clear();
    }


    //private void SetupDanhSachSPTab()
    //{
    //  LoadDanhSachSanPham();
    //  // this.btnTimkiemSP.Click += new System.EventHandler(this.btnTimkiemSP_Click);
    //}

    //private void SetupTaoHDTab()
    //{
    //  currentChiTietHoaDonList = new List<ChiTietHoaDonBan>();
    //  ClearTaoHDFields(); // Sinh mã hóa đơn mới và xóa các trường

    //  dgvChiTietHoaDonban.AutoGenerateColumns = false;
    //  // Đảm bảo các cột được thêm thủ công trong designer và có DataPropertyName đúng
    //  // Ví dụ:
    //  // colMaSP.DataPropertyName = "MaSP";
    //  // colTenSP.DataPropertyName = "TenSP"; // Col TenSP không có trong Model ChiTietHoaDonBan, sẽ xử lý trong code
    //  // colSoLuong.DataPropertyName = "SoLuong";
    //  // colDonGia.DataPropertyName = "DonGia";
    //  // colGiamGia.DataPropertyName = "GiamGia";
    //  // colThanhTien.DataPropertyName = "ThanhTien";

    //  // Gán sự kiện CellEndEdit để xử lý khi người dùng kết thúc chỉnh sửa một ô
    //  dgvChiTietHoaDonban.CellEndEdit += dgvChiTietHoaDonban_CellEndEdit;
    //  dgvChiTietHoaDonban.UserAddedRow += dgvChiTietHoaDonban_UserAddedRow; // Khi người dùng thêm dòng mới
    //  dgvChiTietHoaDonban.SelectionChanged += dgvChiTietHoaDonban_SelectionChanged; // Để cập nhật selected row cho nút Sửa/Xóa

    //  // this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
    //  // this.btnHuyHD.Click += new System.EventHandler(this.btnHuyHD_Click);
    //  // this.btnThemSP_CTHD.Click += new System.EventHandler(this.btnThemSP_CTHD_Click); // Nút này giờ sẽ thêm dòng trống
    //  // this.btnSuaSP_CTHD.Click += new System.EventHandler(this.btnSuaSP_CTHD_Click);
    //  // this.btnXoaSP_CTHD.Click += new System.EventHandler(this.btnXoaSP_CTHD_Click);
    //}

    //private void SetupQuanLyHDTab()
    //{
    //  LoadDanhSachHoaDonBan();
    //  // this.btnTimkiemHD.Click += new System.EventHandler(this.btnTimkiemHD_Click);
    //  // this.dgvHoaDonBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonBan_CellClick);
    //}

    //private void SetupQuanLyKHTab()
    //{
    //  LoadDanhSachKhachHang();
    //  // this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
    //  // this.btnTimkiemKH.Click += new System.EventHandler(this.btnTimkiemKH_Click);
    //  // this.dgvDanhsachKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsachKH_CellClick);
    //}

    // --- ThongTinNV Tab Functions ---
    public void LoadThongTinNhanVienHienTai(EmployeeModel nv)
    {
      txbMaNV.Text = nv.MaNhanVien;
      txbTenNV.Text = nv.TenNhanVien;
      dtpNgaysinh.Value = (DateTime)nv.NgaySinh;
      if (nv.GioiTinh == "Nam") rdoNam.Checked = true; else rdoNu.Checked = true;
      txbDiachi.Text = nv.DiaChi;
      txbSodienthoai.Text = nv.SoDienThoai;
      txbMaNV.ReadOnly = true;
    }

    /// <summary>
    ///  load thông tin khách hàng
    /// </summary>
    /// <param name="dv"></param>
    public void LoadDataCustomerToGridView(DataView dv)
    {
      dgvDanhsachKH.DataSource = dv;
      dgvDanhsachKH.Columns[0].HeaderText = "Mã khách hàng";
      dgvDanhsachKH.Columns[0].Width = 150;
      dgvDanhsachKH.Columns[1].HeaderText = "Tên khách hàng";
      dgvDanhsachKH.Columns[1].Width = 180;
      dgvDanhsachKH.Columns[2].HeaderText = "Số điện thoại";
      dgvDanhsachKH.Columns[2].Width = 130;
      dgvDanhsachKH.Columns[3].HeaderText = "Điểm tích lũy";
      dgvDanhsachKH.Columns[3].Width = 124;
      dgvDanhsachKH.ReadOnly = true;
      dgvDanhsachKH.AllowUserToAddRows = false;

    }
    public void LoadDataInvoiceDetailToGridView(DataSet ds)
    {
      //Lấy ra 2 cột trong DataSet làm khóa liên kết
      DataColumn parentColumn = ds.Tables["tblHoaDonBan"].Columns["SoHDB"];
      DataColumn childColumn = ds.Tables["tblChiTietHoaDonBan"].Columns["SoHDB"];
      //Tạo một mối quan hệ (DataRelation) giữa bảng cha và bảng con
      DataRelation relation = new DataRelation("HoaDon_ChiTiet", parentColumn, childColumn);
      //Thêm quan hệ vừa tạo vào DataSet → để DataSet biết rằng 2 bảng này có liên kết cha-con
      ds.Relations.Add(relation);
      BindingSource parentBindingSource = new BindingSource();
      BindingSource childBindingSource = new BindingSource();

      // Bind hóa đơn vào DataGridView
      parentBindingSource.DataSource = ds;
      parentBindingSource.DataMember = "tblHoaDonBan";

      // Gán BindingSource của bảng con dựa trên bảng cha và quan hệ
      childBindingSource.DataSource = parentBindingSource;
      childBindingSource.DataMember = "HoaDon_ChiTiet";
      // Gán vào DataGridView
      dgvHoaDonBan.DataSource = parentBindingSource;
      dgvHoaDonBan.Columns[4].Width = 200;
      dgvChiTietHD.DataSource = childBindingSource;
    }
    //private void btnCapNhapNV_Click(object sender, EventArgs e)
    //{
    //  try
    //  {
    //    // Validation cơ bản
    //    if (string.IsNullOrWhiteSpace(txbTenNV.Text) || string.IsNullOrWhiteSpace(txbSodienthoai.Text))
    //    {
    //      MessageBox.Show("Tên nhân viên và Số điện thoại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //      return;
    //    }

    //    NhanVien nv = new NhanVien
    //    {
    //      MaNV = txbMaNV.Text,
    //      TenNV = txbTenNV.Text,
    //      NgaySinh = dtpNgaysinh.Value,
    //      GioiTinh = rdoNam.Checked ? "Nam" : "Nữ",
    //      DiaChi = txbDiachi.Text,
    //      SoDienThoai = txbSodienthoai.Text,
    //      Email = txbEmail.Text,
    //      Deleted = 0 // Mặc định là không xóa
    //    };

    //    NhanVien existingNv = nhanVienController.GetNhanVienDetails(nv.MaNV);
    //    // Kiểm tra xem là thêm mới hay cập nhật
    //    bool result;
    //    if (nhanVienController.GetNhanVienDetails(nv.MaNV) == null)
    //    {
    //      // Thêm mới
    //      if (nhanVienController.AddNhanVien(nv))
    //      {
    //        MessageBox.Show("Thêm thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //        // Không cần load lại vì chỉ là thông tin cá nhân của NV hiện tại
    //      }
    //      else
    //      {
    //        MessageBox.Show("Thêm thông tin nhân viên thất bại. Có thể mã đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      }
    //    }
    //    else
    //    {
    //      // Cập nhật
    //      if (nhanVienController.UpdateNhanVien(nv))
    //      {
    //        MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //      }
    //      else
    //      {
    //        MessageBox.Show("Cập nhật thông tin nhân viên thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      }
    //    }
    //  }
    //  catch (Exception ex)
    //  {
    //    MessageBox.Show("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //  }
    //}


    //private void btnXoaNV_Click(object sender, EventArgs e)
    //{
    //  try
    //  {
    //    if (string.IsNullOrWhiteSpace(txbDiachi.Text))
    //    {
    //      MessageBox.Show("Không có nhân viên nào được chọn để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //      return;
    //    }

    //    if (MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    //    {
    //      if (nhanVienController.DeleteNhanVien(txbDiachi.Text))
    //      {
    //        MessageBox.Show("Xóa thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //        ClearThongTinNVFields();
    //        txbMaNV.Text = nhanVienController.GenerateNewMaNV(); // Sinh mã mới sau khi xóa
    //      }
    //      else
    //      {
    //        MessageBox.Show("Xóa thông tin nhân viên thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      }
    //    }
    //  }
    //  catch (Exception ex)
    //  {
    //    MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //  }
    //}

    public void LoadDataProductToGridView(DataView dv)
    {
      dgvSanPham.DataSource = dv;
      dgvSanPham.Columns[0].HeaderText = "Mã sản phẩm";

      dgvSanPham.Columns[1].HeaderText = "Tên sản phẩm";
      dgvSanPham.Columns[1].Width = 147; // Email rộng 147px

      dgvSanPham.Columns[2].HeaderText = "Thể loại";
      dgvSanPham.Columns[3].HeaderText = "Màu";
      dgvSanPham.Columns[4].HeaderText = "Nơi sản xuất";
      dgvSanPham.Columns[5].HeaderText = "Đối tượng";
      dgvSanPham.Columns[6].HeaderText = "Mùa";
      dgvSanPham.Columns[7].HeaderText = "Chất liệu";
      dgvSanPham.Columns[8].HeaderText = "Cỡ";
      dgvSanPham.Columns[9].HeaderText = "Số lượng tồn kho";
      dgvSanPham.Columns[10].HeaderText = "Ảnh";
      dgvSanPham.Columns[11].HeaderText = "Đơn giá nhập";
      dgvSanPham.Columns[12].HeaderText = "Đơn giá bán";
      dgvSanPham.Columns[13].HeaderText = "Trạng thái";

      dgvSanPham.ReadOnly = true;
      dgvSanPham.AllowUserToAddRows = false;
    }
    public void LoadDataHDBToGridView(DataView dv)
    {
      dgvHoaDonTao.DataSource = dv;
      dgvHoaDonTao.Columns[0].HeaderText = "Số hóa đơn bán";
      dgvHoaDonTao.Columns[1].HeaderText = "Mã nhân viên";
      dgvHoaDonTao.Columns[2].HeaderText = "Tên khách hàng";
      dgvHoaDonTao.Columns[3].HeaderText = "Ngày bán";
      dgvHoaDonTao.Columns[4].HeaderText = "Tổng tiền";
      dgvHoaDonTao.Columns[4].Width = 140;
      dgvHoaDonTao.ReadOnly = true;
      dgvHoaDonTao.AllowUserToAddRows = false;
    }



    //private void btnTimkiemSP_Click(object sender, EventArgs e)
    //{
    //  try
    //  {
    //    string keyword = txbTimkiemSP.Text.Trim();
    //    List<SanPham> searchResults = sanPhamController.SearchSanPham(keyword);
    //    dgvSanPham.DataSource = searchResults;

    //    if (searchResults.Count == 0 && !string.IsNullOrWhiteSpace(keyword))
    //    {
    //      MessageBox.Show("Không tìm thấy sản phẩm nào phù hợp với từ khóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //    }
    //  }
    //  catch (Exception ex)
    //  {
    //    MessageBox.Show("Lỗi khi tìm kiếm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //  }
    //}

    //// --- TaoHD Tab Functions ---
    //// Xử lý khi người dùng thêm một dòng mới vào DataGridView
    //private void dgvChiTietHoaDonban_UserAddedRow(object sender, DataGridViewRowEventArgs e)
    //{
    //  // Set giá trị mặc định cho các cột nếu cần (ví dụ: GiamGia = 0)
    //  e.Row.Cells["colGiamGia"].Value = 0m;
    //  e.Row.Cells["colSoLuong"].Value = 0;
    //  e.Row.Cells["colDonGia"].Value = 0m;
    //  e.Row.Cells["colThanhTien"].Value = 0m;
    //}

    //// Xử lý khi người dùng kết thúc chỉnh sửa một ô trong DataGridView
    //private void dgvChiTietHoaDonban_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    //{
    //  if (e.RowIndex < 0 || e.RowIndex >= dgvChiTietHoaDonban.Rows.Count - 1) return; // Tránh hàng thêm mới cuối cùng

    //  DataGridViewRow row = dgvChiTietHoaDonban.Rows[e.RowIndex];
    //  string colName = dgvChiTietHoaDonban.Columns[e.ColumnIndex].Name;

    //  // Xử lý khi MaSP được nhập
    //  if (colName == "colMaSP")
    //  {
    //    string maSP = row.Cells["colMaSP"].Value?.ToString();
    //    if (!string.IsNullOrWhiteSpace(maSP))
    //    {
    //      SanPham sp = sanPhamController.GetSanPhamDetails(maSP);
    //      if (sp != null)
    //      {
    //        row.Cells["colTenSP"].Value = "Tên: " + sp.MaSP; // Placeholder or actual product name if available
    //        row.Cells["colDonGia"].Value = sp.DonGiaBan;
    //        // Mặc định giảm giá 0% nếu chưa có
    //        if (row.Cells["colGiamGia"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colGiamGia"].Value.ToString()))
    //        {
    //          row.Cells["colGiamGia"].Value = 0m;
    //        }
    //      }
    //      else
    //      {
    //        MessageBox.Show("Không tìm thấy sản phẩm với mã này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //        row.Cells["colMaSP"].Value = null; // Clear invalid input
    //        row.Cells["colTenSP"].Value = null;
    //        row.Cells["colDonGia"].Value = 0m;
    //        row.Cells["colSoLuong"].Value = 0;
    //        row.Cells["colGiamGia"].Value = 0m;
    //      }
    //    }
    //  }

    //  // Tính toán Thành tiền khi Số lượng, Đơn giá, Giảm giá thay đổi
    //  if (colName == "colSoLuong" || colName == "colDonGia" || colName == "colGiamGia" || colName == "colMaSP")
    //  {
    //    CalculateThanhTienForRow(row);
    //    UpdateOverallTongTien();
    //  }
    //}

    //// Tính toán thành tiền cho một dòng cụ thể trong DataGridView
    //private void CalculateThanhTienForRow(DataGridViewRow row)
    //{
    //  decimal donGia = 0m;
    //  int soLuong = 0;
    //  decimal giamGiaPhanTram = 0m;

    //  if (row.Cells["colDonGia"].Value != null && decimal.TryParse(row.Cells["colDonGia"].Value.ToString(), out donGia) &&
    //      row.Cells["colSoLuong"].Value != null && int.TryParse(row.Cells["colSoLuong"].Value.ToString(), out soLuong) &&
    //      row.Cells["colGiamGia"].Value != null && decimal.TryParse(row.Cells["colGiamGia"].Value.ToString(), out giamGiaPhanTram))
    //  {
    //    if (soLuong < 0) soLuong = 0; // Đảm bảo số lượng không âm
    //    if (giamGiaPhanTram < 0 || giamGiaPhanTram > 100) giamGiaPhanTram = 0; // Đảm bảo giảm giá hợp lệ

    //    decimal giamGiaDecimal = giamGiaPhanTram / 100;
    //    decimal thanhTien = soLuong * donGia * (1 - giamGiaDecimal);
    //    row.Cells["colThanhTien"].Value = thanhTien;
    //  }
    //  else
    //  {
    //    row.Cells["colThanhTien"].Value = 0m;
    //  }
    //}

    //// Cập nhật tổng tiền của hóa đơn
    //private void UpdateOverallTongTien()
    //{
    //  decimal total = 0;
    //  foreach (DataGridViewRow row in dgvChiTietHoaDonban.Rows)
    //  {
    //    if (!row.IsNewRow && row.Cells["colThanhTien"].Value != null)
    //    {
    //      total += Convert.ToDecimal(row.Cells["colThanhTien"].Value);
    //    }
    //  }
    //  txbTongtien.Text = total.ToString("N0");
    //}

    //// Nút Thêm SP trong chi tiết hóa đơn (nay chỉ thêm dòng trống)
    //private void btnThemSP_CTHD_Click(object sender, EventArgs e)
    //{
    //  dgvChiTietHoaDonban.Rows.Add(); // Thêm một dòng trống mới
    //  dgvChiTietHoaDonban.CurrentCell = dgvChiTietHoaDonban.Rows[dgvChiTietHoaDonban.Rows.Count - 2].Cells["colMaSP"];
    //  dgvChiTietHoaDonban.BeginEdit(true); // Bắt đầu chỉnh sửa ô Mã SP
    //}

    //// Nút Sửa SP trong chi tiết hóa đơn (thực chất là lưu chỉnh sửa trên dòng đã chọn)
    //private void btnSuaSP_CTHD_Click(object sender, EventArgs e)
    //{
    //  // Với việc chỉnh sửa trực tiếp trên DataGridView, nút "Sửa" có thể không cần thiết
    //  // hoặc dùng để "xác nhận" một dòng đã sửa.
    //  // Để đơn giản, nếu người dùng đã chỉnh sửa trên lưới, thì nó đã được cập nhật.
    //  // Nút này có thể dùng để nhắc nhở người dùng hoàn thành chỉnh sửa hoặc lưu lại danh sách
    //  // vào `currentChiTietHoaDonList` nếu bạn không muốn cập nhật list ngay lập tức.
    //  // Hiện tại, logic đã được xử lý trong CellEndEdit. Nút này có thể không cần code gì thêm
    //  // hoặc hiển thị thông báo "Các thay đổi đã được lưu tự động."
    //  MessageBox.Show("Các thay đổi trong chi tiết sản phẩm đã được cập nhật trên bảng. Nhấn 'Thêm Hóa Đơn' để lưu toàn bộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //}

    //// Nút Xóa SP trong chi tiết hóa đơn
    //private void btnXoaSP_CTHD_Click(object sender, EventArgs e)
    //{
    //  if (dgvChiTietHoaDonban.SelectedRows.Count == 0)
    //  {
    //    MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //    return;
    //  }

    //  DataGridViewRow selectedRow = dgvChiTietHoaDonban.SelectedRows[0];
    //  if (selectedRow.IsNewRow) return; // Không xóa dòng thêm mới trống

    //  if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng sản phẩm này khỏi hóa đơn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    //  {
    //    dgvChiTietHoaDonban.Rows.Remove(selectedRow);
    //    UpdateOverallTongTien(); // Cập nhật lại tổng tiền
    //    MessageBox.Show("Đã xóa sản phẩm khỏi chi tiết hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //  }
    //}

    //// Cập nhật currentChiTietHoaDonList khi DataGridView thay đổi
    //private void dgvChiTietHoaDonban_SelectionChanged(object sender, EventArgs e)
    //{
    //  // Đây là một cách để đồng bộ list với DataGridView nếu bạn không gán DataSource
    //  // liên tục hoặc muốn kiểm soát dữ liệu trước khi thêm vào list.
    //  // Tuy nhiên, với cách xử lý CellEndEdit, có thể bỏ qua bước này.
    //  // Quan trọng là đảm bảo `currentChiTietHoaDonList` luôn phản ánh đúng DataGridView.
    //  // Cách đơn giản nhất là build lại list này ngay trước khi thêm hóa đơn.
    //}


    //private void btnThemHD_Click(object sender, EventArgs e)
    //{
    //  try
    //  {
    //    if (string.IsNullOrWhiteSpace(txbMaNV_TaoHD.Text) || string.IsNullOrWhiteSpace(txbMaKH_TaoHD.Text))
    //    {
    //      MessageBox.Show("Vui lòng nhập Mã nhân viên và Mã khách hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //      return;
    //    }

    //    // Cập nhật currentChiTietHoaDonList từ DataGridView trước khi lưu
    //    currentChiTietHoaDonList.Clear();
    //    foreach (DataGridViewRow row in dgvChiTietHoaDonban.Rows)
    //    {
    //      if (!row.IsNewRow) // Bỏ qua dòng trống cuối cùng
    //      {
    //        string maSP = row.Cells["colMaSP"].Value?.ToString();
    //        int soLuong = 0;
    //        decimal donGia = 0m;
    //        decimal giamGia = 0m;
    //        decimal thanhTien = 0m;

    //        if (string.IsNullOrWhiteSpace(maSP) ||
    //            !int.TryParse(row.Cells["colSoLuong"].Value?.ToString(), out soLuong) ||
    //            !decimal.TryParse(row.Cells["colDonGia"].Value?.ToString(), out donGia) ||
    //            !decimal.TryParse(row.Cells["colGiamGia"].Value?.ToString(), out giamGia) ||
    //            !decimal.TryParse(row.Cells["colThanhTien"].Value?.ToString(), out thanhTien))
    //        {
    //          MessageBox.Show("Dữ liệu chi tiết hóa đơn không hợp lệ. Vui lòng kiểm tra lại các dòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //          return;
    //        }

    //        currentChiTietHoaDonList.Add(new ChiTietHoaDonBan
    //        {
    //          SoHDB = txbSoHDB.Text,
    //          MaSP = maSP,
    //          SoLuong = soLuong,
    //          DonGia = donGia,
    //          GiamGia = giamGia / 100, // Lưu dưới dạng thập phân
    //          ThanhTien = thanhTien
    //        });
    //      }
    //    }

    //    if (currentChiTietHoaDonList.Count == 0)
    //    {
    //      MessageBox.Show("Hóa đơn phải có ít nhất một sản phẩm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //      return;
    //    }

    //    HoaDonBan newHoaDon = new HoaDonBan
    //    {
    //      SoHDB = txbSoHDB.Text,
    //      MaNV = txbMaNV_TaoHD.Text,
    //      MaKH = txbMaKH_TaoHD.Text,
    //      NgayBan = dtpNgayban.Value,
    //      TongTien = decimal.Parse(txbTongtien.Text), // Lấy từ UI
    //      Deleted = 0
    //    };

    //    if (hoaDonBanController.AddHoaDonBan(newHoaDon, currentChiTietHoaDonList))
    //    {
    //      MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //      ClearTaoHDFields();
    //      LoadDanhSachHoaDonBan(); // Cập nhật danh sách hóa đơn ở tab Quản lý HD
    //    }
    //    else
    //    {
    //      MessageBox.Show("Thêm hóa đơn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //  }
    //  catch (Exception ex)
    //  {
    //    MessageBox.Show("Lỗi khi thêm hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //  }
    //}

    //private void btnHuyHD_Click(object sender, EventArgs e)
    //{
    //  if (MessageBox.Show("Bạn có muốn hủy hóa đơn này? Mọi thông tin sẽ bị xóa.", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    //  {
    //    ClearTaoHDFields();
    //    MessageBox.Show("Đã hủy hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //  }
    //}


    //// --- QuanlyHD Tab Functions ---
    //private void LoadDanhSachHoaDonBan()
    //{
    //  try
    //  {
    //    List<HoaDonBan> hoaDonList = hoaDonBanController.GetAllHoaDonBan();
    //    dgvHoaDonBan.DataSource = hoaDonList;
    //  }
    //  catch (Exception ex)
    //  {
    //    MessageBox.Show("Lỗi khi tải danh sách hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //  }
    //}

    //private void btnTimkiemHD_Click(object sender, EventArgs e)
    //{
    //  try
    //  {
    //    string keyword = txbTimkiemHD.Text.Trim();
    //    // txbTimkiemHD sẽ tìm kiếm theo SoHDB, MaNV, MaKH
    //    DateTime? ngayBan = dtpNgayTimkiemHD.Checked ? dtpNgayTimkiemHD.Value : (DateTime?)null; // Sử dụng dtpNgay theo designer

    //    List<HoaDonBan> searchResults = hoaDonBanController.SearchHoaDonBan(keyword, ngayBan);
    //    dgvHoaDonBan.DataSource = searchResults;

    //    if (searchResults.Count == 0 && (string.IsNullOrWhiteSpace(keyword) && !ngayBan.HasValue))
    //    {
    //      MessageBox.Show("Không tìm thấy hóa đơn nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //    }
    //  }
    //  catch (Exception ex)
    //  {
    //    MessageBox.Show("Lỗi khi tìm kiếm hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //  }
    //}

    //private void dgvHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
    //{
    //  if (e.RowIndex >= 0 && e.RowIndex < dgvHoaDonBan.Rows.Count)
    //  {
    //    DataGridViewRow row = dgvHoaDonBan.Rows[e.RowIndex];
    //    string soHDB = row.Cells["SoHDB"].Value?.ToString(); // Đảm bảo cột SoHDB có trong dgvHoaDonBan
    //    if (!string.IsNullOrWhiteSpace(soHDB))
    //    {
    //      try
    //      {
    //        List<ChiTietHoaDonBan> chiTietList = hoaDonBanController.GetChiTietHoaDonBan(soHDB);
    //        dgvChiTietHoaDon.DataSource = chiTietList;
    //        // Cần gán colTenSP nếu bạn muốn hiển thị Tên SP trong dgvChiTietHoaDon
    //        // foreach (var item in chiTietList)
    //        // {
    //        //     SanPham sp = sanPhamController.GetSanPhamDetails(item.MaSP);
    //        //     if (sp != null)
    //        //     {
    //        //         item.TenSP = sp.TenSP; // Nếu ChiTietHoaDonBan có thuộc tính TenSP
    //        //     }
    //        // }
    //      }
    //      catch (Exception ex)
    //      {
    //        MessageBox.Show("Lỗi khi tải chi tiết hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //      }
    //    }
    //  }
    //}

    //// --- QuanlyKH Tab Functions ---
    //private void LoadDanhSachKhachHang()
    //{
    //  try
    //  {
    //    List<KhachHang> khachHangList = khachHangController.GetAllKhachHang();
    //    dgvDanhsachKH.DataSource = khachHangList;
    //  }
    //  catch (Exception ex)
    //  {
    //    MessageBox.Show("Lỗi khi tải danh sách khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //  }
    //}

    //private void btnThemKH_Click(object sender, EventArgs e)
    //{
    //  try
    //  {
    //    if (string.IsNullOrWhiteSpace(txbTenKH.Text) || string.IsNullOrWhiteSpace(txbSdtKH.Text))
    //    {
    //      MessageBox.Show("Tên khách hàng và Số điện thoại không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //      return;
    //    }

    //    // Kiểm tra xem khách hàng có tồn tại không (bằng SĐT hoặc tên), nếu không cho trùng SĐT chẳng hạn
    //    // Hiện tại đang sinh mã KH tự động và thêm mới, nên sẽ luôn thêm nếu SĐT hợp lệ.
    //    // Thêm kiểm tra trùng SĐT nếu cần:
    //    // if (khachHangController.IsPhoneNumberExists(txbSdtKH.Text)) { MessageBox.Show("Số điện thoại đã tồn tại.", "Lỗi"); return; }

    //    KhachHang newKhachHang = new KhachHang
    //    {
    //      MaKH = khachHangController.GenerateNewMaKH(), // Tự động sinh mã
    //      TenKH = txbTenKH.Text,
    //      DiaChi = txbDiachiKH.Text,
    //      SoDienThoai = txbSdtKH.Text,
    //      Deleted = 0
    //    };

    //    if (khachHangController.AddKhachHang(newKhachHang))
    //    {
    //      MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //      LoadDanhSachKhachHang(); // Cập nhật DataGridView
    //      ClearQuanLyKHFields();
    //    }
    //    else
    //    {
    //      MessageBox.Show("Thêm khách hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //  }
    //  catch (Exception ex)
    //  {
    //    MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //  }
    //}

    //private void btnTimkiemKH_Click(object sender, EventArgs e)
    //{
    //  try
    //  {
    //    string keyword = txbTimkiemKH.Text.Trim();
    //    List<KhachHang> searchResults = khachHangController.SearchKhachHang(keyword);
    //    dgvDanhsachKH.DataSource = searchResults;

    //    if (searchResults.Count == 0 && !string.IsNullOrWhiteSpace(keyword))
    //    {
    //      MessageBox.Show("Không tìm thấy khách hàng nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //    }
    //  }
    //  catch (Exception ex)
    //  {
    //    MessageBox.Show("Lỗi khi tìm kiếm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //  }
    //}

    //private void dgvDanhsachKH_CellClick(object sender, DataGridViewCellEventArgs e)
    //{
    //  if (e.RowIndex >= 0 && e.RowIndex < dgvDanhsachKH.Rows.Count)
    //  {
    //    DataGridViewRow row = dgvDanhsachKH.Rows[e.RowIndex];
    //    txbMaKH.Text = row.Cells["MaKH"].Value?.ToString();
    //    txbTenKH.Text = row.Cells["TenKH"].Value?.ToString();
    //    txbDiachiKH.Text = row.Cells["DiaChi"].Value?.ToString();
    //    txbSdtKH.Text = row.Cells["SoDienThoai"].Value?.ToString();
    //  }
    //}

    //// --- Form Load Event ---
    //private void frmNhanVien_Load(object sender, EventArgs e)
    //{
    //  // Các setup ban đầu đã được gọi trong constructor
    //}
  }
}