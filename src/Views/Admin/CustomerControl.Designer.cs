using System;

namespace BTL_C_.src.Views.Admin
{
  partial class CustomerControl
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mskSDT = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numDiem = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(62, 290);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(845, 160);
            this.dgvKhachHang.TabIndex = 0;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaKH.Location = new System.Drawing.Point(106, 150);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(149, 22);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenKH.Location = new System.Drawing.Point(316, 150);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(210, 22);
            this.txtTenKH.TabIndex = 2;
            // 
            // lblMaKH
            // 
            this.lblMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(156, 118);
            this.lblMaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(47, 16);
            this.lblMaKH.TabIndex = 5;
            this.lblMaKH.Text = "Mã KH";
            // 
            // lblTenKH
            // 
            this.lblTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(391, 118);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(52, 16);
            this.lblTenKH.TabIndex = 7;
            this.lblTenKH.Text = "Tên KH";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(610, 118);
            this.lblDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(72, 16);
            this.lblDienThoai.TabIndex = 8;
            this.lblDienThoai.Text = "Điện Thoại";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Location = new System.Drawing.Point(40, 21);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 28);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Location = new System.Drawing.Point(193, 21);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 28);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(349, 21);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(325, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh Sách Khách Hàng";
            // 
            // mskSDT
            // 
            this.mskSDT.Location = new System.Drawing.Point(585, 160);
            this.mskSDT.Mask = "(999) 000-0000";
            this.mskSDT.Name = "mskSDT";
            this.mskSDT.Size = new System.Drawing.Size(121, 22);
            this.mskSDT.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Location = new System.Drawing.Point(4, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 64);
            this.panel1.TabIndex = 11;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(909, 26);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(52, 23);
            this.btnTim.TabIndex = 15;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(663, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 22);
            this.txtSearch.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tìm khách hàng theo tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Điểm";
            // 
            // numDiem
            // 
            this.numDiem.Location = new System.Drawing.Point(760, 161);
            this.numDiem.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDiem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDiem.Name = "numDiem";
            this.numDiem.Size = new System.Drawing.Size(97, 22);
            this.numDiem.TabIndex = 13;
            this.numDiem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numDiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mskSDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.dgvKhachHang);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerControl";
            this.Size = new System.Drawing.Size(972, 536);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }


    #endregion

    private System.Windows.Forms.DataGridView dgvKhachHang;
    private System.Windows.Forms.TextBox txtMaKH;
    private System.Windows.Forms.TextBox txtTenKH;
    private System.Windows.Forms.Label lblMaKH;
    private System.Windows.Forms.Label lblTenKH;
    private System.Windows.Forms.Label lblDienThoai;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.MaskedTextBox mskSDT;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnTim;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numDiem;
  }
}
