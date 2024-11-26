namespace btl_ngk
{
	partial class frmPGH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPGH));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvPhieuGH = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTimMaPGH = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.cboMaNGK = new System.Windows.Forms.ComboBox();
            this.cboMaDDH = new System.Windows.Forms.ComboBox();
            this.lblMaNGK = new System.Windows.Forms.Label();
            this.txtMaPhieuGH = new System.Windows.Forms.TextBox();
            this.lblMaPhieuGH = new System.Windows.Forms.Label();
            this.lblNgayGiao = new System.Windows.Forms.Label();
            this.lblMaDDH = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThongTinChung = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuGH)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(22, 523);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 67);
            this.panel2.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Location = new System.Drawing.Point(244, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 46);
            this.panel4.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(14, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSua.Location = new System.Drawing.Point(213, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 39);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Cornsilk;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnThem.Location = new System.Drawing.Point(113, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 39);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Cornsilk;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Location = new System.Drawing.Point(409, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 39);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Cornsilk;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.Location = new System.Drawing.Point(311, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 39);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvPhieuGH
            // 
            this.dgvPhieuGH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuGH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieuGH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuGH.Location = new System.Drawing.Point(22, 309);
            this.dgvPhieuGH.Name = "dgvPhieuGH";
            this.dgvPhieuGH.ReadOnly = true;
            this.dgvPhieuGH.RowHeadersWidth = 51;
            this.dgvPhieuGH.RowTemplate.Height = 24;
            this.dgvPhieuGH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuGH.Size = new System.Drawing.Size(784, 189);
            this.dgvPhieuGH.TabIndex = 40;
            this.dgvPhieuGH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPhieuGH_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FloralWhite;
            this.panel3.Controls.Add(this.txtTimMaPGH);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Controls.Add(this.lblTimKiem);
            this.panel3.Location = new System.Drawing.Point(22, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 47);
            this.panel3.TabIndex = 39;
            // 
            // txtTimMaPGH
            // 
            this.txtTimMaPGH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimMaPGH.Location = new System.Drawing.Point(218, 13);
            this.txtTimMaPGH.Name = "txtTimMaPGH";
            this.txtTimMaPGH.Size = new System.Drawing.Size(171, 22);
            this.txtTimMaPGH.TabIndex = 28;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cornsilk;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTimKiem.Location = new System.Drawing.Point(395, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 40);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Search";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimKiem.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTimKiem.Location = new System.Drawing.Point(3, 16);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(205, 16);
            this.lblTimKiem.TabIndex = 11;
            this.lblTimKiem.Text = "Tìm thông tin bằng mã phiếu:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpNgayGiao);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtDonGia);
            this.panel1.Controls.Add(this.lblSoLuong);
            this.panel1.Controls.Add(this.lblDonGia);
            this.panel1.Controls.Add(this.cboMaNGK);
            this.panel1.Controls.Add(this.cboMaDDH);
            this.panel1.Controls.Add(this.lblMaNGK);
            this.panel1.Controls.Add(this.txtMaPhieuGH);
            this.panel1.Controls.Add(this.lblMaPhieuGH);
            this.panel1.Controls.Add(this.lblNgayGiao);
            this.panel1.Controls.Add(this.lblMaDDH);
            this.panel1.Location = new System.Drawing.Point(22, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 129);
            this.panel1.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "x";
            // 
            // dtpNgayGiao
            // 
            this.dtpNgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayGiao.Location = new System.Drawing.Point(597, 55);
            this.dtpNgayGiao.Name = "dtpNgayGiao";
            this.dtpNgayGiao.Size = new System.Drawing.Size(167, 22);
            this.dtpNgayGiao.TabIndex = 16;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Location = new System.Drawing.Point(598, 88);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(166, 22);
            this.txtSoLuong.TabIndex = 15;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Location = new System.Drawing.Point(175, 90);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(166, 22);
            this.txtDonGia.TabIndex = 14;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSoLuong.Location = new System.Drawing.Point(465, 90);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(63, 16);
            this.lblSoLuong.TabIndex = 13;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDonGia.Location = new System.Drawing.Point(24, 94);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(86, 16);
            this.lblDonGia.TabIndex = 12;
            this.lblDonGia.Text = "Đơn giá giao:";
            // 
            // cboMaNGK
            // 
            this.cboMaNGK.FormattingEnabled = true;
            this.cboMaNGK.Location = new System.Drawing.Point(175, 56);
            this.cboMaNGK.Name = "cboMaNGK";
            this.cboMaNGK.Size = new System.Drawing.Size(166, 24);
            this.cboMaNGK.TabIndex = 11;
            // 
            // cboMaDDH
            // 
            this.cboMaDDH.FormattingEnabled = true;
            this.cboMaDDH.Location = new System.Drawing.Point(598, 18);
            this.cboMaDDH.Name = "cboMaDDH";
            this.cboMaDDH.Size = new System.Drawing.Size(166, 24);
            this.cboMaDDH.TabIndex = 10;
            this.cboMaDDH.SelectedIndexChanged += new System.EventHandler(this.cboMaDDH_SelectedIndexChanged);
            // 
            // lblMaNGK
            // 
            this.lblMaNGK.AutoSize = true;
            this.lblMaNGK.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMaNGK.Location = new System.Drawing.Point(24, 61);
            this.lblMaNGK.Name = "lblMaNGK";
            this.lblMaNGK.Size = new System.Drawing.Size(114, 16);
            this.lblMaNGK.TabIndex = 4;
            this.lblMaNGK.Text = "Mã nước giải khát:";
            // 
            // txtMaPhieuGH
            // 
            this.txtMaPhieuGH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhieuGH.Location = new System.Drawing.Point(175, 18);
            this.txtMaPhieuGH.Name = "txtMaPhieuGH";
            this.txtMaPhieuGH.Size = new System.Drawing.Size(166, 22);
            this.txtMaPhieuGH.TabIndex = 5;
            // 
            // lblMaPhieuGH
            // 
            this.lblMaPhieuGH.AutoSize = true;
            this.lblMaPhieuGH.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMaPhieuGH.Location = new System.Drawing.Point(24, 22);
            this.lblMaPhieuGH.Name = "lblMaPhieuGH";
            this.lblMaPhieuGH.Size = new System.Drawing.Size(128, 16);
            this.lblMaPhieuGH.TabIndex = 3;
            this.lblMaPhieuGH.Text = "Mã phiếu giao hàng:";
            // 
            // lblNgayGiao
            // 
            this.lblNgayGiao.AutoSize = true;
            this.lblNgayGiao.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNgayGiao.Location = new System.Drawing.Point(465, 60);
            this.lblNgayGiao.Name = "lblNgayGiao";
            this.lblNgayGiao.Size = new System.Drawing.Size(73, 16);
            this.lblNgayGiao.TabIndex = 2;
            this.lblNgayGiao.Text = "Ngày giao:";
            // 
            // lblMaDDH
            // 
            this.lblMaDDH.AutoSize = true;
            this.lblMaDDH.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMaDDH.Location = new System.Drawing.Point(465, 22);
            this.lblMaDDH.Name = "lblMaDDH";
            this.lblMaDDH.Size = new System.Drawing.Size(110, 16);
            this.lblMaDDH.TabIndex = 1;
            this.lblMaDDH.Text = "Mã đơn đặt hàng:";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblHoaDon.Location = new System.Drawing.Point(302, 25);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(0, 29);
            this.lblHoaDon.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(835, 71);
            this.label4.TabIndex = 54;
            this.label4.Text = "Phiếu Giao Hàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThongTinChung
            // 
            this.lblThongTinChung.AutoSize = true;
            this.lblThongTinChung.BackColor = System.Drawing.Color.White;
            this.lblThongTinChung.CausesValidation = false;
            this.lblThongTinChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinChung.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblThongTinChung.Location = new System.Drawing.Point(6, 86);
            this.lblThongTinChung.Name = "lblThongTinChung";
            this.lblThongTinChung.Size = new System.Drawing.Size(247, 25);
            this.lblThongTinChung.TabIndex = 55;
            this.lblThongTinChung.Text = "Thông tin Phiếu Giao Hàng";
            // 
            // frmPGH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 611);
            this.Controls.Add(this.lblThongTinChung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvPhieuGH);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPGH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Giao Hàng";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuGH)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.DataGridView dgvPhieuGH;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtTimMaPGH;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.Label lblTimKiem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dtpNgayGiao;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.Label lblSoLuong;
		private System.Windows.Forms.Label lblDonGia;
		private System.Windows.Forms.ComboBox cboMaNGK;
		private System.Windows.Forms.ComboBox cboMaDDH;
		private System.Windows.Forms.Label lblMaNGK;
		private System.Windows.Forms.TextBox txtMaPhieuGH;
		private System.Windows.Forms.Label lblMaPhieuGH;
		private System.Windows.Forms.Label lblNgayGiao;
		private System.Windows.Forms.Label lblMaDDH;
		private System.Windows.Forms.Label lblHoaDon;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblThongTinChung;
        private System.Windows.Forms.Panel panel4;
    }
}