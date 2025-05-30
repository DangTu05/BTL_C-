namespace BTL_C_.src.Views.Client
{
  partial class FrmInventoryAuditReport
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
      this.dgvInventory = new System.Windows.Forms.DataGridView();
      this.lblNgayBatDauKiemDuyet = new System.Windows.Forms.Label();
      this.dtpNgayBatDauKiemDuyet = new System.Windows.Forms.DateTimePicker();
      this.lblNgayKetThucKiemDuyet = new System.Windows.Forms.Label();
      this.dtpNgayKetThucKiemDuyet = new System.Windows.Forms.DateTimePicker();
      this.btnTimKiem = new System.Windows.Forms.Button();
      this.btnXuatExcel = new System.Windows.Forms.Button();
      this.btnThoat = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvInventory
      // 
      this.dgvInventory.AllowUserToAddRows = false;
      this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
      | System.Windows.Forms.AnchorStyles.Left)
      | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvInventory.Location = new System.Drawing.Point(12, 211);
      this.dgvInventory.Name = "dgvInventory";
      this.dgvInventory.RowHeadersWidth = 51;
      this.dgvInventory.RowTemplate.Height = 24;
      this.dgvInventory.Size = new System.Drawing.Size(930, 266);
      this.dgvInventory.TabIndex = 0;
      // 
      // lblNgayBatDauKiemDuyet
      // 
      this.lblNgayBatDauKiemDuyet.AutoSize = true;
      this.lblNgayBatDauKiemDuyet.Location = new System.Drawing.Point(97, 86);
      this.lblNgayBatDauKiemDuyet.Name = "lblNgayBatDauKiemDuyet";
      this.lblNgayBatDauKiemDuyet.Size = new System.Drawing.Size(164, 16);
      this.lblNgayBatDauKiemDuyet.TabIndex = 1;
      this.lblNgayBatDauKiemDuyet.Text = "Ngày Bắt Đầu Kiểm Duyệt:";
      // 
      // dtpNgayBatDauKiemDuyet
      // 
      this.dtpNgayBatDauKiemDuyet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNgayBatDauKiemDuyet.Location = new System.Drawing.Point(299, 81);
      this.dtpNgayBatDauKiemDuyet.Name = "dtpNgayBatDauKiemDuyet";
      this.dtpNgayBatDauKiemDuyet.Size = new System.Drawing.Size(150, 22);
      this.dtpNgayBatDauKiemDuyet.TabIndex = 2;
      // 
      // lblNgayKetThucKiemDuyet
      // 
      this.lblNgayKetThucKiemDuyet.AutoSize = true;
      this.lblNgayKetThucKiemDuyet.Location = new System.Drawing.Point(526, 86);
      this.lblNgayKetThucKiemDuyet.Name = "lblNgayKetThucKiemDuyet";
      this.lblNgayKetThucKiemDuyet.Size = new System.Drawing.Size(169, 16);
      this.lblNgayKetThucKiemDuyet.TabIndex = 3;
      this.lblNgayKetThucKiemDuyet.Text = "Ngày Kết Thúc Kiểm Duyệt:";
      // 
      // dtpNgayKetThucKiemDuyet
      // 
      this.dtpNgayKetThucKiemDuyet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNgayKetThucKiemDuyet.Location = new System.Drawing.Point(725, 81);
      this.dtpNgayKetThucKiemDuyet.Name = "dtpNgayKetThucKiemDuyet";
      this.dtpNgayKetThucKiemDuyet.Size = new System.Drawing.Size(150, 22);
      this.dtpNgayKetThucKiemDuyet.TabIndex = 4;
      // 
      // btnTimKiem
      // 
      this.btnTimKiem.Location = new System.Drawing.Point(83, 142);
      this.btnTimKiem.Name = "btnTimKiem";
      this.btnTimKiem.Size = new System.Drawing.Size(157, 30);
      this.btnTimKiem.TabIndex = 5;
      this.btnTimKiem.Text = "Tìm Kiếm";
      this.btnTimKiem.UseVisualStyleBackColor = true;
      // 
      // btnXuatExcel
      // 
      this.btnXuatExcel.Location = new System.Drawing.Point(372, 142);
      this.btnXuatExcel.Name = "btnXuatExcel";
      this.btnXuatExcel.Size = new System.Drawing.Size(166, 30);
      this.btnXuatExcel.TabIndex = 6;
      this.btnXuatExcel.Text = "Xuất Excel";
      this.btnXuatExcel.UseVisualStyleBackColor = true;
      // 
      // btnThoat
      // 
      this.btnThoat.Location = new System.Drawing.Point(725, 142);
      this.btnThoat.Name = "btnThoat";
      this.btnThoat.Size = new System.Drawing.Size(150, 30);
      this.btnThoat.TabIndex = 7;
      this.btnThoat.Text = "Thoát";
      this.btnThoat.UseVisualStyleBackColor = true;
      // 
      // FrmInventoryAuditReport
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(954, 489);
      this.Controls.Add(this.btnThoat);
      this.Controls.Add(this.btnXuatExcel);
      this.Controls.Add(this.btnTimKiem);
      this.Controls.Add(this.dtpNgayKetThucKiemDuyet);
      this.Controls.Add(this.lblNgayKetThucKiemDuyet);
      this.Controls.Add(this.dtpNgayBatDauKiemDuyet);
      this.Controls.Add(this.lblNgayBatDauKiemDuyet);
      this.Controls.Add(this.dgvInventory);
      this.Name = "FrmInventoryAuditReport";
      this.Text = "Báo Cáo Hàng Tồn Kho Theo Kiểm Duyệt";
      ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvInventory;
    private System.Windows.Forms.Label lblNgayBatDauKiemDuyet;
    private System.Windows.Forms.DateTimePicker dtpNgayBatDauKiemDuyet;
    private System.Windows.Forms.Label lblNgayKetThucKiemDuyet;
    private System.Windows.Forms.DateTimePicker dtpNgayKetThucKiemDuyet;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.Button btnXuatExcel;
    private System.Windows.Forms.Button btnThoat;

  }
}