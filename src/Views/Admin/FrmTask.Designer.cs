namespace BTL_C_.src.Views.Admin
{
  partial class FrmTask
  {
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblTenCongViec;
    private System.Windows.Forms.TextBox txtTenCongViec;
    private System.Windows.Forms.DataGridView dataGridViewCongViec;
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
      this.lblTenCongViec = new System.Windows.Forms.Label();
      this.txtTenCongViec = new System.Windows.Forms.TextBox();
      this.dataGridViewCongViec = new System.Windows.Forms.DataGridView();
      this.btnXoa = new System.Windows.Forms.Button();
      this.btnLuu = new System.Windows.Forms.Button();
      this.btnThoat = new System.Windows.Forms.Button();
      this.btnLamMoi = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtMaCongViec = new System.Windows.Forms.TextBox();
      this.btnTao = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCongViec)).BeginInit();
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
      this.lblTitle.Text = "DANH MỤC CÔNG VIỆC";
      this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblTenCongViec
      // 
      this.lblTenCongViec.AutoSize = true;
      this.lblTenCongViec.Location = new System.Drawing.Point(151, 116);
      this.lblTenCongViec.Name = "lblTenCongViec";
      this.lblTenCongViec.Size = new System.Drawing.Size(96, 16);
      this.lblTenCongViec.TabIndex = 2;
      this.lblTenCongViec.Text = "Tên Công Việc";
      // 
      // txtTenCongViec
      // 
      this.txtTenCongViec.Location = new System.Drawing.Point(268, 113);
      this.txtTenCongViec.Name = "txtTenCongViec";
      this.txtTenCongViec.Size = new System.Drawing.Size(180, 22);
      this.txtTenCongViec.TabIndex = 4;
      // 
      // dataGridViewCongViec
      // 
      this.dataGridViewCongViec.BackgroundColor = System.Drawing.SystemColors.ControlDark;
      this.dataGridViewCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewCongViec.Location = new System.Drawing.Point(154, 173);
      this.dataGridViewCongViec.Name = "dataGridViewCongViec";
      this.dataGridViewCongViec.RowHeadersWidth = 51;
      this.dataGridViewCongViec.Size = new System.Drawing.Size(373, 130);
      this.dataGridViewCongViec.TabIndex = 5;
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
      this.label1.Size = new System.Drawing.Size(91, 16);
      this.label1.TabIndex = 13;
      this.label1.Text = "Mã Công Việc";
      // 
      // txtMaCongViec
      // 
      this.txtMaCongViec.Location = new System.Drawing.Point(267, 84);
      this.txtMaCongViec.Name = "txtMaCongViec";
      this.txtMaCongViec.ReadOnly = true;
      this.txtMaCongViec.Size = new System.Drawing.Size(181, 22);
      this.txtMaCongViec.TabIndex = 14;
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
      // FrmTask
      // 
      this.ClientSize = new System.Drawing.Size(638, 380);
      this.Controls.Add(this.btnTao);
      this.Controls.Add(this.txtMaCongViec);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnLamMoi);
      this.Controls.Add(this.btnThoat);
      this.Controls.Add(this.btnLuu);
      this.Controls.Add(this.btnXoa);
      this.Controls.Add(this.dataGridViewCongViec);
      this.Controls.Add(this.txtTenCongViec);
      this.Controls.Add(this.lblTenCongViec);
      this.Controls.Add(this.lblTitle);
      this.Name = "FrmTask";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Danh mục Công Việc";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCongViec)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtMaCongViec;
    private System.Windows.Forms.Button btnTao;
  }
}