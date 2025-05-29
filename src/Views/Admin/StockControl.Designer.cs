namespace BTL_C_.src.Views.Admin
{
  partial class StockControl
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
      this.dvgTonKho = new System.Windows.Forms.DataGridView();
      this.lblChatLieu = new System.Windows.Forms.Label();
      this.cbChatLieu = new System.Windows.Forms.ComboBox();
      this.lblCo = new System.Windows.Forms.Label();
      this.cbCo = new System.Windows.Forms.ComboBox();
      this.lblLoai = new System.Windows.Forms.Label();
      this.cbLoai = new System.Windows.Forms.ComboBox();
      this.lblMua = new System.Windows.Forms.Label();
      this.cbMua = new System.Windows.Forms.ComboBox();
      this.lblMaQuanAo = new System.Windows.Forms.Label();
      this.txtMaQuanAoi = new System.Windows.Forms.TextBox();
      this.btnTimKiem = new System.Windows.Forms.Button();
      this.btnXuat = new System.Windows.Forms.Button();
      this.btnThoat = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dvgTonKho)).BeginInit();
      this.SuspendLayout();
      //
      // dvgTonKho
      //
      this.dvgTonKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
      | System.Windows.Forms.AnchorStyles.Left)
      | System.Windows.Forms.AnchorStyles.Right)));
      this.dvgTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dvgTonKho.Location = new System.Drawing.Point(12, 120); // Điều chỉnh vị trí phù hợp
      this.dvgTonKho.Name = "dvgTonKho";
      this.dvgTonKho.RowHeadersWidth = 51;
      this.dvgTonKho.RowTemplate.Height = 24;
      this.dvgTonKho.Size = new System.Drawing.Size(776, 318); // Điều chỉnh kích thước phù hợp
      this.dvgTonKho.TabIndex = 0;
      //
      // lblChatLieu
      //
      this.lblChatLieu.AutoSize = true;
      this.lblChatLieu.Location = new System.Drawing.Point(12, 20);
      this.lblChatLieu.Name = "lblChatLieu";
      this.lblChatLieu.Size = new System.Drawing.Size(65, 16);
      this.lblChatLieu.TabIndex = 1;
      this.lblChatLieu.Text = "Chất liệu:";
      //
      // cbChatLieu
      //
      this.cbChatLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbChatLieu.FormattingEnabled = true;
      this.cbChatLieu.Location = new System.Drawing.Point(83, 17);
      this.cbChatLieu.Name = "cbChatLieu";
      this.cbChatLieu.Size = new System.Drawing.Size(121, 24);
      this.cbChatLieu.TabIndex = 2;
      //
      // lblCo
      //
      this.lblCo.AutoSize = true;
      this.lblCo.Location = new System.Drawing.Point(220, 20);
      this.lblCo.Name = "lblCo";
      this.lblCo.Size = new System.Drawing.Size(28, 16);
      this.lblCo.TabIndex = 3;
      this.lblCo.Text = "Cỡ:";
      //
      // cbCo
      //
      this.cbCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbCo.FormattingEnabled = true;
      this.cbCo.Location = new System.Drawing.Point(254, 17);
      this.cbCo.Name = "cbCo";
      this.cbCo.Size = new System.Drawing.Size(121, 24);
      this.cbCo.TabIndex = 4;
      //
      // lblLoai
      //
      this.lblLoai.AutoSize = true;
      this.lblLoai.Location = new System.Drawing.Point(12, 55);
      this.lblLoai.Name = "lblLoai";
      this.lblLoai.Size = new System.Drawing.Size(36, 16);
      this.lblLoai.TabIndex = 5;
      this.lblLoai.Text = "Loại:";
      //
      // cbLoai
      //
      this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbLoai.FormattingEnabled = true;
      this.cbLoai.Location = new System.Drawing.Point(83, 52);
      this.cbLoai.Name = "cbLoai";
      this.cbLoai.Size = new System.Drawing.Size(121, 24);
      this.cbLoai.TabIndex = 6;
      //
      // lblMua
      //
      this.lblMua.AutoSize = true;
      this.lblMua.Location = new System.Drawing.Point(220, 55);
      this.lblMua.Name = "lblMua";
      this.lblMua.Size = new System.Drawing.Size(36, 16);
      this.lblMua.TabIndex = 7;
      this.lblMua.Text = "Mùa:";
      //
      // cbMua
      //
      this.cbMua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbMua.FormattingEnabled = true;
      this.cbMua.Location = new System.Drawing.Point(254, 52);
      this.cbMua.Name = "cbMua";
      this.cbMua.Size = new System.Drawing.Size(121, 24);
      this.cbMua.TabIndex = 8;
      //
      // lblMaQuanAo
      //
      this.lblMaQuanAo.AutoSize = true;
      this.lblMaQuanAo.Location = new System.Drawing.Point(400, 20);
      this.lblMaQuanAo.Name = "lblMaQuanAo";
      this.lblMaQuanAo.Size = new System.Drawing.Size(89, 16);
      this.lblMaQuanAo.TabIndex = 9;
      this.lblMaQuanAo.Text = "Mã Quần Áo:";
      //
      // txtMaQuanAoi
      //
      this.txtMaQuanAoi.Location = new System.Drawing.Point(495, 17);
      this.txtMaQuanAoi.Name = "txtMaQuanAoi";
      this.txtMaQuanAoi.Size = new System.Drawing.Size(150, 22);
      this.txtMaQuanAoi.TabIndex = 10;
      //
      // btnTimKiem
      //
      this.btnTimKiem.Location = new System.Drawing.Point(495, 50);
      this.btnTimKiem.Name = "btnTimKiem";
      this.btnTimKiem.Size = new System.Drawing.Size(100, 30);
      this.btnTimKiem.TabIndex = 11;
      this.btnTimKiem.Text = "Tìm Kiếm";
      this.btnTimKiem.UseVisualStyleBackColor = true;
      //
      // btnXuat
      //
      this.btnXuat.Location = new System.Drawing.Point(601, 50);
      this.btnXuat.Name = "btnXuat";
      this.btnXuat.Size = new System.Drawing.Size(100, 30);
      this.btnXuat.TabIndex = 12;
      this.btnXuat.Text = "Xuất Excel";

      //
      // btnThoat
      //
      this.btnThoat.Location = new System.Drawing.Point(707, 50);
      this.btnThoat.Name = "btnThoat";
      this.btnThoat.Size = new System.Drawing.Size(80, 30);
      this.btnThoat.TabIndex = 13;
      this.btnThoat.Text = "Thoát";
      this.btnThoat.UseVisualStyleBackColor = true;
      //
      // frmBaoCaoTonKho
      //
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnThoat);
      this.Controls.Add(this.btnXuat);
      this.Controls.Add(this.btnTimKiem);
      this.Controls.Add(this.txtMaQuanAoi);
      this.Controls.Add(this.lblMaQuanAo);
      this.Controls.Add(this.cbMua);
      this.Controls.Add(this.lblMua);
      this.Controls.Add(this.cbLoai);
      this.Controls.Add(this.lblLoai);
      this.Controls.Add(this.cbCo);
      this.Controls.Add(this.lblCo);
      this.Controls.Add(this.cbChatLieu);
      this.Controls.Add(this.lblChatLieu);
      this.Controls.Add(this.dvgTonKho);
      this.Name = "frmBaoCaoTonKho";
      this.Text = "Báo Cáo Hàng Tồn Kho";
      ((System.ComponentModel.ISupportInitialize)(this.dvgTonKho)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dvgTonKho;
    private System.Windows.Forms.Label lblChatLieu;
    private System.Windows.Forms.ComboBox cbChatLieu;
    private System.Windows.Forms.Label lblCo;
    private System.Windows.Forms.ComboBox cbCo;
    private System.Windows.Forms.Label lblLoai;
    private System.Windows.Forms.ComboBox cbLoai;
    private System.Windows.Forms.Label lblMua;
    private System.Windows.Forms.ComboBox cbMua;
    private System.Windows.Forms.Label lblMaQuanAo;
    private System.Windows.Forms.TextBox txtMaQuanAoi;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.Button btnXuat;
    private System.Windows.Forms.Button btnThoat;
  }
}
