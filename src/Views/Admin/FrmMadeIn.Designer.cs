namespace BTL_C_.src.Views.Admin
{
  partial class FrmMadeIn
  {
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblTenNoiSanXuat;
    private System.Windows.Forms.TextBox txtTenNoiSanXuat;
    private System.Windows.Forms.DataGridView dataGridViewNoiSanXuat;
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
      this.lblTenNoiSanXuat = new System.Windows.Forms.Label();
      this.txtTenNoiSanXuat = new System.Windows.Forms.TextBox();
      this.dataGridViewNoiSanXuat = new System.Windows.Forms.DataGridView();
      this.btnXoa = new System.Windows.Forms.Button();
      this.btnLuu = new System.Windows.Forms.Button();
      this.btnThoat = new System.Windows.Forms.Button();
      this.btnLamMoi = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtMaNoiSanXuat = new System.Windows.Forms.TextBox();
      this.btnTao = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoiSanXuat)).BeginInit();
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
      this.lblTitle.Text = "DANH MỤC NƠI SẢN XUẤT";
      this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblTenNoiSanXuat
      // 
      this.lblTenNoiSanXuat.AutoSize = true;
      this.lblTenNoiSanXuat.Location = new System.Drawing.Point(154, 116);
      this.lblTenNoiSanXuat.Name = "lblTenNoiSanXuat";
      this.lblTenNoiSanXuat.Size = new System.Drawing.Size(111, 16);
      this.lblTenNoiSanXuat.TabIndex = 2;
      this.lblTenNoiSanXuat.Text = "Tên Nơi Sản Xuất";
      // 
      // txtTenNoiSanXuat
      // 
      this.txtTenNoiSanXuat.Location = new System.Drawing.Point(294, 113);
      this.txtTenNoiSanXuat.Name = "txtTenNoiSanXuat";
      this.txtTenNoiSanXuat.Size = new System.Drawing.Size(180, 22);
      this.txtTenNoiSanXuat.TabIndex = 4;
      // 
      // dataGridViewNoiSanXuat
      // 
      this.dataGridViewNoiSanXuat.BackgroundColor = System.Drawing.SystemColors.ControlDark;
      this.dataGridViewNoiSanXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewNoiSanXuat.Location = new System.Drawing.Point(154, 173);
      this.dataGridViewNoiSanXuat.Name = "dataGridViewNoiSanXuat";
      this.dataGridViewNoiSanXuat.RowHeadersWidth = 51;
      this.dataGridViewNoiSanXuat.Size = new System.Drawing.Size(373, 130);
      this.dataGridViewNoiSanXuat.TabIndex = 5;
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
      this.label1.Location = new System.Drawing.Point(154, 87);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(106, 16);
      this.label1.TabIndex = 13;
      this.label1.Text = "Mã Nơi Sản Xuất";
      // 
      // txtMaNoiSanXuat
      // 
      this.txtMaNoiSanXuat.Location = new System.Drawing.Point(293, 84);
      this.txtMaNoiSanXuat.Name = "txtMaNoiSanXuat";
      this.txtMaNoiSanXuat.ReadOnly = true;
      this.txtMaNoiSanXuat.Size = new System.Drawing.Size(181, 22);
      this.txtMaNoiSanXuat.TabIndex = 14;
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
      // FrmMadeIn
      // 
      this.ClientSize = new System.Drawing.Size(638, 380);
      this.Controls.Add(this.btnTao);
      this.Controls.Add(this.txtMaNoiSanXuat);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnLamMoi);
      this.Controls.Add(this.btnThoat);
      this.Controls.Add(this.btnLuu);
      this.Controls.Add(this.btnXoa);
      this.Controls.Add(this.dataGridViewNoiSanXuat);
      this.Controls.Add(this.txtTenNoiSanXuat);
      this.Controls.Add(this.lblTenNoiSanXuat);
      this.Controls.Add(this.lblTitle);
      this.Name = "FrmMadeIn";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Danh mục Nơi Sản Xuất";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoiSanXuat)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtMaNoiSanXuat;
    private System.Windows.Forms.Button btnTao;
  }
}