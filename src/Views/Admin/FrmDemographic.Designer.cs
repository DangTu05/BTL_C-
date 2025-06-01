namespace BTL_C_.src.Views.Admin
{
  partial class FrmDemographic
  {
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblTenDoiTuong;
    private System.Windows.Forms.TextBox txtTenDoiTuong;
    private System.Windows.Forms.DataGridView dataGridViewDoiTuong;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.Button btnThoat;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lblTitle = new System.Windows.Forms.Label();
      this.lblTenDoiTuong = new System.Windows.Forms.Label();
      this.txtTenDoiTuong = new System.Windows.Forms.TextBox();
      this.dataGridViewDoiTuong = new System.Windows.Forms.DataGridView();
      this.btnXoa = new System.Windows.Forms.Button();
      this.btnLuu = new System.Windows.Forms.Button();
      this.btnThoat = new System.Windows.Forms.Button();
      this.btnLamMoi = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtMaDoiTuong = new System.Windows.Forms.TextBox();
      this.btnTao = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoiTuong)).BeginInit();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.Green;
      this.lblTitle.Location = new System.Drawing.Point(113, 23);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(400, 40);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "DANH MỤC ĐỐI TƯỢNG";
      this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblTenDoiTuong
      // 
      this.lblTenDoiTuong.AutoSize = true;
      this.lblTenDoiTuong.Location = new System.Drawing.Point(151, 116);
      this.lblTenDoiTuong.Name = "lblTenDoiTuong";
      this.lblTenDoiTuong.Size = new System.Drawing.Size(63, 16);
      this.lblTenDoiTuong.TabIndex = 2;
      this.lblTenDoiTuong.Text = "Tên Đối Tượng:";
      // 
      // txtTenDoiTuong
      // 
      this.txtTenDoiTuong.Location = new System.Drawing.Point(262, 113);
      this.txtTenDoiTuong.Name = "txtTenDoiTuong";
      this.txtTenDoiTuong.Size = new System.Drawing.Size(180, 22);
      this.txtTenDoiTuong.TabIndex = 4;
      // 
      // dataGridViewDoiTuong
      // 
      this.dataGridViewDoiTuong.BackgroundColor = System.Drawing.SystemColors.ControlDark;
      this.dataGridViewDoiTuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDoiTuong.Location = new System.Drawing.Point(154, 173);
      this.dataGridViewDoiTuong.Name = "dataGridViewDoiTuong";
      this.dataGridViewDoiTuong.RowHeadersWidth = 51;
      this.dataGridViewDoiTuong.Size = new System.Drawing.Size(373, 130);
      this.dataGridViewDoiTuong.TabIndex = 5;
      // 
      // btnXoa
      // 
      this.btnXoa.Location = new System.Drawing.Point(152, 323);
      this.btnXoa.Name = "btnXoa";
      this.btnXoa.Size = new System.Drawing.Size(70, 30);
      this.btnXoa.TabIndex = 7;
      this.btnXoa.Text = "Xoá";
      this.btnXoa.UseVisualStyleBackColor = true;
      // 
      // btnLuu
      // 
      this.btnLuu.Location = new System.Drawing.Point(307, 323);
      this.btnLuu.Name = "btnLuu";
      this.btnLuu.Size = new System.Drawing.Size(70, 30);
      this.btnLuu.TabIndex = 9;
      this.btnLuu.Text = "Lưu";
      this.btnLuu.UseVisualStyleBackColor = true;
      // 
      // btnThoat
      // 
      this.btnThoat.Location = new System.Drawing.Point(457, 323);
      this.btnThoat.Name = "btnThoat";
      this.btnThoat.Size = new System.Drawing.Size(70, 30);
      this.btnThoat.TabIndex = 11;
      this.btnThoat.Text = "Thoát";
      this.btnThoat.UseVisualStyleBackColor = true;
      // 
      // btnLamMoi
      // 
      this.btnLamMoi.Location = new System.Drawing.Point(228, 323);
      this.btnLamMoi.Name = "btnLamMoi";
      this.btnLamMoi.Size = new System.Drawing.Size(73, 30);
      this.btnLamMoi.TabIndex = 12;
      this.btnLamMoi.Text = "Làm mới";
      this.btnLamMoi.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(151, 87);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 16);
      this.label1.TabIndex = 13;
      this.label1.Text = "Mã Đối Tượng";
      // 
      // txtMaDoiTuong
      // 
      this.txtMaDoiTuong.Location = new System.Drawing.Point(261, 84);
      this.txtMaDoiTuong.Name = "txtMaDoiTuong";
      this.txtMaDoiTuong.ReadOnly = true;
      this.txtMaDoiTuong.Size = new System.Drawing.Size(181, 22);
      this.txtMaDoiTuong.TabIndex = 14;
      // 
      // btnTao
      // 
      this.btnTao.Location = new System.Drawing.Point(383, 323);
      this.btnTao.Name = "btnTao";
      this.btnTao.Size = new System.Drawing.Size(68, 30);
      this.btnTao.TabIndex = 15;
      this.btnTao.Text = "Tạo";
      this.btnTao.UseVisualStyleBackColor = true;
      // 
      // FrmObject
      // 
      this.ClientSize = new System.Drawing.Size(638, 380);
      this.Controls.Add(this.btnTao);
      this.Controls.Add(this.txtMaDoiTuong);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnLamMoi);
      this.Controls.Add(this.btnThoat);
      this.Controls.Add(this.btnLuu);
      this.Controls.Add(this.btnXoa);
      this.Controls.Add(this.dataGridViewDoiTuong);
      this.Controls.Add(this.txtTenDoiTuong);
      this.Controls.Add(this.lblTenDoiTuong);
      this.Controls.Add(this.lblTitle);
      this.Name = "FrmObject";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Danh mục Đối Tượng";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoiTuong)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtMaDoiTuong;
    private System.Windows.Forms.Button btnTao;
  }
}