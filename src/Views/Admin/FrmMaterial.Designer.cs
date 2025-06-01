namespace BTL_C_.src.Views.Admin
{
  partial class FrmMaterial
  {
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblTenChatLieu;
    private System.Windows.Forms.TextBox txtTenChatLieu;
    private System.Windows.Forms.DataGridView dataGridViewChatLieu;
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
      this.lblTenChatLieu = new System.Windows.Forms.Label();
      this.txtTenChatLieu = new System.Windows.Forms.TextBox();
      this.dataGridViewChatLieu = new System.Windows.Forms.DataGridView();
      this.btnXoa = new System.Windows.Forms.Button();
      this.btnLuu = new System.Windows.Forms.Button();
      this.btnThoat = new System.Windows.Forms.Button();
      this.btnLamMoi = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtMaChatLieu = new System.Windows.Forms.TextBox();
      this.btnTao = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatLieu)).BeginInit();
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
      this.lblTitle.Text = "DANH MỤC CHẤT LIỆU";
      this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblTenChatLieu
      // 
      this.lblTenChatLieu.AutoSize = true;
      this.lblTenChatLieu.Location = new System.Drawing.Point(151, 116);
      this.lblTenChatLieu.Name = "lblTenChatLieu";
      this.lblTenChatLieu.Size = new System.Drawing.Size(63, 16);
      this.lblTenChatLieu.TabIndex = 2;
      this.lblTenChatLieu.Text = "Tên Chất liệu:";
      // 
      // txtTenChatLieu
      // 
      this.txtTenChatLieu.Location = new System.Drawing.Point(262, 113);
      this.txtTenChatLieu.Name = "txtTenChatLieu";
      this.txtTenChatLieu.Size = new System.Drawing.Size(180, 22);
      this.txtTenChatLieu.TabIndex = 4;
      // 
      // dataGridViewChatLieu
      // 
      this.dataGridViewChatLieu.BackgroundColor = System.Drawing.SystemColors.ControlDark;
      this.dataGridViewChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewChatLieu.Location = new System.Drawing.Point(154, 173);
      this.dataGridViewChatLieu.Name = "dataGridViewChatLieu";
      this.dataGridViewChatLieu.RowHeadersWidth = 51;
      this.dataGridViewChatLieu.Size = new System.Drawing.Size(373, 130);
      this.dataGridViewChatLieu.TabIndex = 5;
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
      this.label1.Text = "Mã Chất liệu";
      // 
      // txtMaChatLieu
      // 
      this.txtMaChatLieu.Location = new System.Drawing.Point(261, 84);
      this.txtMaChatLieu.Name = "txtMaChatLieu";
      this.txtMaChatLieu.ReadOnly = true;
      this.txtMaChatLieu.Size = new System.Drawing.Size(181, 22);
      this.txtMaChatLieu.TabIndex = 14;
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
      // FrmMaterial
      // 
      this.ClientSize = new System.Drawing.Size(638, 380);
      this.Controls.Add(this.btnTao);
      this.Controls.Add(this.txtMaChatLieu);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnLamMoi);
      this.Controls.Add(this.btnThoat);
      this.Controls.Add(this.btnLuu);
      this.Controls.Add(this.btnXoa);
      this.Controls.Add(this.dataGridViewChatLieu);
      this.Controls.Add(this.txtTenChatLieu);
      this.Controls.Add(this.lblTenChatLieu);
      this.Controls.Add(this.lblTitle);
      this.Name = "FrmMaterial";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Danh mục Chất liệu";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatLieu)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtMaChatLieu;
    private System.Windows.Forms.Button btnTao;
  }
}