namespace BTL_C_.src.Views.Admin
{
  partial class BestSellingProductControl
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
      this.dateThoigianbatdau = new System.Windows.Forms.DateTimePicker();
      this.dateThoigianketthuc = new System.Windows.Forms.DateTimePicker();
      this.lblThoigianbatdau = new System.Windows.Forms.Label();
      this.lblThoigianketthuc = new System.Windows.Forms.Label();
      this.btnTim = new System.Windows.Forms.Button();
      this.dgvSanpham = new System.Windows.Forms.DataGridView();
      this.lblTongSoLuong = new System.Windows.Forms.Label();
      this.lblTongTien = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
      this.SuspendLayout();
      // 
      // dateThoigianbatdau
      // 
      this.dateThoigianbatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateThoigianbatdau.Location = new System.Drawing.Point(188, 91);
      this.dateThoigianbatdau.Margin = new System.Windows.Forms.Padding(4);
      this.dateThoigianbatdau.Name = "dateThoigianbatdau";
      this.dateThoigianbatdau.Size = new System.Drawing.Size(199, 22);
      this.dateThoigianbatdau.TabIndex = 0;
      // 
      // dateThoigianketthuc
      // 
      this.dateThoigianketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateThoigianketthuc.Location = new System.Drawing.Point(663, 93);
      this.dateThoigianketthuc.Margin = new System.Windows.Forms.Padding(4);
      this.dateThoigianketthuc.Name = "dateThoigianketthuc";
      this.dateThoigianketthuc.Size = new System.Drawing.Size(199, 22);
      this.dateThoigianketthuc.TabIndex = 1;
      // 
      // lblThoigianbatdau
      // 
      this.lblThoigianbatdau.AutoSize = true;
      this.lblThoigianbatdau.Location = new System.Drawing.Point(56, 97);
      this.lblThoigianbatdau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblThoigianbatdau.Name = "lblThoigianbatdau";
      this.lblThoigianbatdau.Size = new System.Drawing.Size(114, 16);
      this.lblThoigianbatdau.TabIndex = 2;
      this.lblThoigianbatdau.Text = "Thời gian bắt đầu:";
      // 
      // lblThoigianketthuc
      // 
      this.lblThoigianketthuc.AutoSize = true;
      this.lblThoigianketthuc.Location = new System.Drawing.Point(527, 98);
      this.lblThoigianketthuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblThoigianketthuc.Name = "lblThoigianketthuc";
      this.lblThoigianketthuc.Size = new System.Drawing.Size(114, 16);
      this.lblThoigianketthuc.TabIndex = 3;
      this.lblThoigianketthuc.Text = "Thời gian kết thúc:";
      // 
      // btnTim
      // 
      this.btnTim.Location = new System.Drawing.Point(69, 484);
      this.btnTim.Margin = new System.Windows.Forms.Padding(4);
      this.btnTim.Name = "btnTim";
      this.btnTim.Size = new System.Drawing.Size(133, 37);
      this.btnTim.TabIndex = 4;
      this.btnTim.Text = "Tìm kiếm";
      this.btnTim.UseVisualStyleBackColor = true;
      // 
      // dgvSanpham
      // 
      this.dgvSanpham.AllowUserToAddRows = false;
      this.dgvSanpham.AllowUserToDeleteRows = false;
      this.dgvSanpham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
      | System.Windows.Forms.AnchorStyles.Left)
      | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvSanpham.Location = new System.Drawing.Point(59, 314);
      this.dgvSanpham.Margin = new System.Windows.Forms.Padding(4);
      this.dgvSanpham.Name = "dgvSanpham";
      this.dgvSanpham.ReadOnly = true;
      this.dgvSanpham.RowHeadersWidth = 51;
      this.dgvSanpham.Size = new System.Drawing.Size(854, 151);
      this.dgvSanpham.TabIndex = 6;
      // 
      // lblTongSoLuong
      // 
      this.lblTongSoLuong.AutoSize = true;
      this.lblTongSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTongSoLuong.Location = new System.Drawing.Point(66, 283);
      this.lblTongSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblTongSoLuong.Name = "lblTongSoLuong";
      this.lblTongSoLuong.Size = new System.Drawing.Size(153, 18);
      this.lblTongSoLuong.TabIndex = 7;
      this.lblTongSoLuong.Text = "Tổng số lượng bán:";
      // 
      // lblTongTien
      // 
      this.lblTongTien.AutoSize = true;
      this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTongTien.Location = new System.Drawing.Point(487, 283);
      this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblTongTien.Name = "lblTongTien";
      this.lblTongTien.Size = new System.Drawing.Size(130, 18);
      this.lblTongTien.TabIndex = 8;
      this.lblTongTien.Text = "Tổng doanh thu:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Red;
      this.label1.Location = new System.Drawing.Point(365, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(290, 36);
      this.label1.TabIndex = 10;
      this.label1.Text = "Sản Phẩm Bán Chạy";
      // 
      // BestSellingProductControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnTim);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lblTongTien);
      this.Controls.Add(this.lblTongSoLuong);
      this.Controls.Add(this.dgvSanpham);
      this.Controls.Add(this.lblThoigianketthuc);
      this.Controls.Add(this.lblThoigianbatdau);
      this.Controls.Add(this.dateThoigianketthuc);
      this.Controls.Add(this.dateThoigianbatdau);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "BestSellingProductControl";
      this.Size = new System.Drawing.Size(972, 536);
      ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DateTimePicker dateThoigianbatdau;
    private System.Windows.Forms.DateTimePicker dateThoigianketthuc;
    private System.Windows.Forms.Label lblThoigianbatdau;
    private System.Windows.Forms.Label lblThoigianketthuc;
    private System.Windows.Forms.Button btnTim;
    private System.Windows.Forms.DataGridView dgvSanpham;
    private System.Windows.Forms.Label lblTongSoLuong;
    private System.Windows.Forms.Label lblTongTien;
    private System.Windows.Forms.Label label1;
  }
}
