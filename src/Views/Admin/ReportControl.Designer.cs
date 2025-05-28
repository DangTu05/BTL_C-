using System.Drawing;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
  partial class ReportControl
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
      this.dvgSaleReport = new System.Windows.Forms.DataGridView();
      this.lblNgayBatDau = new System.Windows.Forms.Label();
      this.lblNgayKetThuc = new System.Windows.Forms.Label();
      this.btnTimKiem = new System.Windows.Forms.Button();
      this.btnXuatExcel = new System.Windows.Forms.Button();
      this.btnKhenThuong = new System.Windows.Forms.Button();
      this.lblKetQuaNVXuatSac = new System.Windows.Forms.Label();
      this.dateNgayBatDau = new System.Windows.Forms.DateTimePicker();
      this.dateNgayKetThuc = new System.Windows.Forms.DateTimePicker();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dvgSaleReport)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dvgSaleReport
      // 
      this.dvgSaleReport.AllowUserToAddRows = false;
      this.dvgSaleReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
      | System.Windows.Forms.AnchorStyles.Left)
      | System.Windows.Forms.AnchorStyles.Right)));
      this.dvgSaleReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dvgSaleReport.Location = new System.Drawing.Point(45, 237);
      this.dvgSaleReport.Name = "dvgSaleReport";
      this.dvgSaleReport.RowHeadersWidth = 51;
      this.dvgSaleReport.RowTemplate.Height = 24;
      this.dvgSaleReport.Size = new System.Drawing.Size(897, 213);
      this.dvgSaleReport.TabIndex = 0;
      // 
      // lblNgayBatDau
      // 
      this.lblNgayBatDau.AutoSize = true;
      this.lblNgayBatDau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lblNgayBatDau.Location = new System.Drawing.Point(42, 85);
      this.lblNgayBatDau.Name = "lblNgayBatDau";
      this.lblNgayBatDau.Size = new System.Drawing.Size(93, 16);
      this.lblNgayBatDau.TabIndex = 1;
      this.lblNgayBatDau.Text = "Ngày Bắt Đầu:";
      // 
      // lblNgayKetThuc
      // 
      this.lblNgayKetThuc.AutoSize = true;
      this.lblNgayKetThuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lblNgayKetThuc.Location = new System.Drawing.Point(522, 84);
      this.lblNgayKetThuc.Name = "lblNgayKetThuc";
      this.lblNgayKetThuc.Size = new System.Drawing.Size(98, 16);
      this.lblNgayKetThuc.TabIndex = 3;
      this.lblNgayKetThuc.Text = "Ngày Kết Thúc:";
      // 
      // btnTimKiem
      // 
      this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnTimKiem.Location = new System.Drawing.Point(56, 20);
      this.btnTimKiem.Name = "btnTimKiem";
      this.btnTimKiem.Size = new System.Drawing.Size(180, 30);
      this.btnTimKiem.TabIndex = 5;
      this.btnTimKiem.Text = "Tìm Kiếm";
      this.btnTimKiem.UseVisualStyleBackColor = true;
      // 
      // btnXuatExcel
      // 
      this.btnXuatExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnXuatExcel.Location = new System.Drawing.Point(699, 20);
      this.btnXuatExcel.Name = "btnXuatExcel";
      this.btnXuatExcel.Size = new System.Drawing.Size(181, 30);
      this.btnXuatExcel.TabIndex = 6;
      this.btnXuatExcel.Text = "Xuất Excel";
      this.btnXuatExcel.UseVisualStyleBackColor = true;
      // 
      // btnKhenThuong
      // 
      this.btnKhenThuong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnKhenThuong.Location = new System.Drawing.Point(367, 20);
      this.btnKhenThuong.Name = "btnKhenThuong";
      this.btnKhenThuong.Size = new System.Drawing.Size(194, 30);
      this.btnKhenThuong.TabIndex = 8;
      this.btnKhenThuong.Text = "Khen Thưởng";
      this.btnKhenThuong.UseVisualStyleBackColor = true;
      // 
      // lblKetQuaNVXuatSac
      // 
      this.lblKetQuaNVXuatSac.AutoSize = true;
      this.lblKetQuaNVXuatSac.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lblKetQuaNVXuatSac.Location = new System.Drawing.Point(42, 167);
      this.lblKetQuaNVXuatSac.MaximumSize = new System.Drawing.Size(238, 0);
      this.lblKetQuaNVXuatSac.Name = "lblKetQuaNVXuatSac";
      this.lblKetQuaNVXuatSac.Size = new System.Drawing.Size(55, 16);
      this.lblKetQuaNVXuatSac.TabIndex = 9;
      this.lblKetQuaNVXuatSac.Text = "Kết quả:";
      // 
      // dateNgayBatDau
      // 
      this.dateNgayBatDau.Location = new System.Drawing.Point(155, 80);
      this.dateNgayBatDau.Name = "dateNgayBatDau";
      this.dateNgayBatDau.Size = new System.Drawing.Size(238, 22);
      this.dateNgayBatDau.TabIndex = 10;
      // 
      // dateNgayKetThuc
      // 
      this.dateNgayKetThuc.Location = new System.Drawing.Point(648, 79);
      this.dateNgayKetThuc.Name = "dateNgayKetThuc";
      this.dateNgayKetThuc.Size = new System.Drawing.Size(234, 22);
      this.dateNgayKetThuc.TabIndex = 11;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnTimKiem);
      this.panel1.Controls.Add(this.btnKhenThuong);
      this.panel1.Controls.Add(this.btnXuatExcel);
      this.panel1.Location = new System.Drawing.Point(23, 470);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(935, 63);
      this.panel1.TabIndex = 12;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Red;
      this.label1.Location = new System.Drawing.Point(404, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(130, 36);
      this.label1.TabIndex = 13;
      this.label1.Text = "Báo Cáo";
      // 
      // ReportControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.dateNgayKetThuc);
      this.Controls.Add(this.dateNgayBatDau);
      this.Controls.Add(this.lblKetQuaNVXuatSac);
      this.Controls.Add(this.lblNgayKetThuc);
      this.Controls.Add(this.lblNgayBatDau);
      this.Controls.Add(this.dvgSaleReport);
      this.ForeColor = System.Drawing.Color.Red;
      this.Name = "ReportControl";
      this.Size = new System.Drawing.Size(972, 536);
      ((System.ComponentModel.ISupportInitialize)(this.dvgSaleReport)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dvgSaleReport;
    private System.Windows.Forms.Label lblNgayBatDau;
    private System.Windows.Forms.Label lblNgayKetThuc;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.Button btnXuatExcel;
    private System.Windows.Forms.Button btnKhenThuong;
    private System.Windows.Forms.Label lblKetQuaNVXuatSac;
    private DateTimePicker dateNgayBatDau;
    private DateTimePicker dateNgayKetThuc;
    private Panel panel1;
    private Label label1;
  }
}
