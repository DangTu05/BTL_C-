using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
  partial class RevenueControl
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
      this.lblKetqua = new System.Windows.Forms.Label();
      this.btnTim = new System.Windows.Forms.Button();
      this.btnLamMoi = new System.Windows.Forms.Button();
      this.dgvDoanhthu = new System.Windows.Forms.DataGridView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnXoa = new System.Windows.Forms.Button();
      this.btnTinhTong = new System.Windows.Forms.Button();
      this.lblTongDoanhThu = new System.Windows.Forms.Label();
      this.dateDoanhThu = new System.Windows.Forms.DateTimePicker();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtMaHoaDonBan = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhthu)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblKetqua
      // 
      this.lblKetqua.AutoSize = true;
      this.lblKetqua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.lblKetqua.Location = new System.Drawing.Point(39, 269);
      this.lblKetqua.Name = "lblKetqua";
      this.lblKetqua.Size = new System.Drawing.Size(87, 20);
      this.lblKetqua.TabIndex = 2;
      this.lblKetqua.Text = "Doanh thu:";
      // 
      // btnTim
      // 
      this.btnTim.Location = new System.Drawing.Point(31, 19);
      this.btnTim.Name = "btnTim";
      this.btnTim.Size = new System.Drawing.Size(177, 25);
      this.btnTim.TabIndex = 5;
      this.btnTim.Text = "Tìm";
      this.btnTim.UseVisualStyleBackColor = true;
      // 
      // btnLamMoi
      // 
      this.btnLamMoi.Location = new System.Drawing.Point(245, 19);
      this.btnLamMoi.Name = "btnLamMoi";
      this.btnLamMoi.Size = new System.Drawing.Size(169, 25);
      this.btnLamMoi.TabIndex = 6;
      this.btnLamMoi.Text = "Làm Mới";
      this.btnLamMoi.UseVisualStyleBackColor = true;
      // 
      // dgvDoanhthu
      // 
      this.dgvDoanhthu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
      | System.Windows.Forms.AnchorStyles.Left)
      | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvDoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDoanhthu.Location = new System.Drawing.Point(43, 304);
      this.dgvDoanhthu.Name = "dgvDoanhthu";
      this.dgvDoanhthu.RowHeadersWidth = 51;
      this.dgvDoanhthu.Size = new System.Drawing.Size(880, 156);
      this.dgvDoanhthu.TabIndex = 7;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnXoa);
      this.panel1.Controls.Add(this.btnTinhTong);
      this.panel1.Controls.Add(this.btnTim);
      this.panel1.Controls.Add(this.btnLamMoi);
      this.panel1.Location = new System.Drawing.Point(43, 476);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(880, 57);
      this.panel1.TabIndex = 8;
      // 
      // btnXoa
      // 
      this.btnXoa.Location = new System.Drawing.Point(449, 19);
      this.btnXoa.Name = "btnXoa";
      this.btnXoa.Size = new System.Drawing.Size(177, 25);
      this.btnXoa.TabIndex = 9;
      this.btnXoa.Text = "Xóa";
      this.btnXoa.UseVisualStyleBackColor = true;
      // 
      // btnTinhTong
      // 
      this.btnTinhTong.Location = new System.Drawing.Point(666, 19);
      this.btnTinhTong.Name = "btnTinhTong";
      this.btnTinhTong.Size = new System.Drawing.Size(172, 25);
      this.btnTinhTong.TabIndex = 7;
      this.btnTinhTong.Text = "Tính tổng doanh thu";
      this.btnTinhTong.UseVisualStyleBackColor = true;
      // 
      // lblTongDoanhThu
      // 
      this.lblTongDoanhThu.AutoSize = true;
      this.lblTongDoanhThu.Location = new System.Drawing.Point(132, 272);
      this.lblTongDoanhThu.Name = "lblTongDoanhThu";
      this.lblTongDoanhThu.Size = new System.Drawing.Size(0, 16);
      this.lblTongDoanhThu.TabIndex = 8;
      // 
      // dateDoanhThu
      // 
      this.dateDoanhThu.Location = new System.Drawing.Point(428, 94);
      this.dateDoanhThu.Name = "dateDoanhThu";
      this.dateDoanhThu.Size = new System.Drawing.Size(200, 22);
      this.dateDoanhThu.TabIndex = 9;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Red;
      this.label1.Location = new System.Drawing.Point(394, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(178, 38);
      this.label1.TabIndex = 10;
      this.label1.Text = "Doanh Thu";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(93, 87);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(185, 29);
      this.label2.TabIndex = 11;
      this.label2.Text = "Mã hóa đơn bán";
      // 
      // txtMaHoaDonBan
      // 
      this.txtMaHoaDonBan.Location = new System.Drawing.Point(98, 152);
      this.txtMaHoaDonBan.Name = "txtMaHoaDonBan";
      this.txtMaHoaDonBan.ReadOnly = true;
      this.txtMaHoaDonBan.Size = new System.Drawing.Size(169, 22);
      this.txtMaHoaDonBan.TabIndex = 12;
      // 
      // RevenueControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtMaHoaDonBan);
      this.Controls.Add(this.lblTongDoanhThu);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dateDoanhThu);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.dgvDoanhthu);
      this.Controls.Add(this.lblKetqua);
      this.Name = "RevenueControl";
      this.Size = new System.Drawing.Size(972, 536);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhthu)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private Label lblKetqua;
    private Button btnTim;
    private Button btnLamMoi;
    private DataGridView dgvDoanhthu;
    private Panel panel1;
    private DateTimePicker dateDoanhThu;
    private Label lblTongDoanhThu;
    private Button btnTinhTong;
    private Label label1;
    private Label label2;
    private TextBox txtMaHoaDonBan;
    private Button btnXoa;
  }
}
