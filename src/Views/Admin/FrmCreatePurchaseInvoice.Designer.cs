namespace BTL_C_.src.Views.Admin
{
  partial class FrmCreatePurchaseInvoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCTHDN = new System.Windows.Forms.DataGridView();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.nudTongTien = new System.Windows.Forms.NumericUpDown();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhà cung cấp";
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(234, 92);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(150, 24);
            this.cmbNhaCungCap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày nhập";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(577, 92);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayNhap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(196, 163);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(188, 22);
            this.txtGhiChu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng tiền";
            // 
            // dgvCTHDN
            // 
            this.dgvCTHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDN.Location = new System.Drawing.Point(32, 235);
            this.dgvCTHDN.Name = "dgvCTHDN";
            this.dgvCTHDN.RowHeadersWidth = 51;
            this.dgvCTHDN.RowTemplate.Height = 24;
            this.dgvCTHDN.Size = new System.Drawing.Size(758, 150);
            this.dgvCTHDN.TabIndex = 8;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(510, 402);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(96, 36);
            this.btnTao.TabIndex = 9;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(183, 402);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 36);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // nudTongTien
            // 
            this.nudTongTien.Location = new System.Drawing.Point(577, 159);
            this.nudTongTien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTongTien.Name = "nudTongTien";
            this.nudTongTien.ReadOnly = true;
            this.nudTongTien.Size = new System.Drawing.Size(200, 22);
            this.nudTongTien.TabIndex = 11;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(355, 402);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 36);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // FrmCreatePurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.nudTongTien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.dgvCTHDN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNhaCungCap);
            this.Controls.Add(this.label1);
            this.Name = "FrmCreatePurchaseInvoice";
            this.Text = "FrmCreatePurchaseInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cmbNhaCungCap;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker dtpNgayNhap;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtGhiChu;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DataGridView dgvCTHDN;
    private System.Windows.Forms.Button btnTao;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.NumericUpDown nudTongTien;
    private System.Windows.Forms.Button btnXoa;
  }
}