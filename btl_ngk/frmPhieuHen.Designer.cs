namespace btl_ngk
{
	partial class frmPhieuHen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuHen));
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.dgvPhieuHen = new System.Windows.Forms.DataGridView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txtMaPhieuHen = new System.Windows.Forms.TextBox();
			this.lblMaPH = new System.Windows.Forms.Label();
			this.btnTim = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
			this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
			this.txtSoLuong = new System.Windows.Forms.MaskedTextBox();
			this.lblSoLuong = new System.Windows.Forms.Label();
			this.cboMaNGK = new System.Windows.Forms.ComboBox();
			this.lblMaNGK = new System.Windows.Forms.Label();
			this.cboMaKH = new System.Windows.Forms.ComboBox();
			this.txtMaPH = new System.Windows.Forms.TextBox();
			this.lblNgayHenGiao = new System.Windows.Forms.Label();
			this.lblMaPhieuHen = new System.Windows.Forms.Label();
			this.lblMaKH = new System.Windows.Forms.Label();
			this.lblNgayLapPH = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblThongTinChung = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhieuHen)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FloralWhite;
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Location = new System.Drawing.Point(12, 516);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(790, 68);
			this.panel2.TabIndex = 54;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.MistyRose;
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.btnThem);
			this.panel3.Controls.Add(this.btnSua);
			this.panel3.Controls.Add(this.btnXoa);
			this.panel3.Controls.Add(this.btnExit);
			this.panel3.Location = new System.Drawing.Point(277, 10);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(501, 50);
			this.panel3.TabIndex = 40;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Cornsilk;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = System.Drawing.Color.OrangeRed;
			this.button1.Location = new System.Drawing.Point(13, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 39);
			this.button1.TabIndex = 51;
			this.button1.Text = "Reload";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.Cornsilk;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnThem.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnThem.Location = new System.Drawing.Point(111, 8);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(92, 39);
			this.btnThem.TabIndex = 11;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.Cornsilk;
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnSua.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnSua.Location = new System.Drawing.Point(307, 8);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(92, 39);
			this.btnSua.TabIndex = 13;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.Cornsilk;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnXoa.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnXoa.Location = new System.Drawing.Point(209, 8);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(92, 39);
			this.btnXoa.TabIndex = 14;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Cornsilk;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnExit.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnExit.Location = new System.Drawing.Point(405, 8);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(92, 39);
			this.btnExit.TabIndex = 15;
			this.btnExit.Text = "Đóng";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// dgvPhieuHen
			// 
			this.dgvPhieuHen.AllowUserToAddRows = false;
			this.dgvPhieuHen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPhieuHen.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvPhieuHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPhieuHen.Location = new System.Drawing.Point(12, 266);
			this.dgvPhieuHen.Name = "dgvPhieuHen";
			this.dgvPhieuHen.ReadOnly = true;
			this.dgvPhieuHen.RowHeadersWidth = 51;
			this.dgvPhieuHen.RowTemplate.Height = 24;
			this.dgvPhieuHen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPhieuHen.Size = new System.Drawing.Size(792, 193);
			this.dgvPhieuHen.TabIndex = 53;
			this.dgvPhieuHen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPhieuHen_MouseClick);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FloralWhite;
			this.panel4.Controls.Add(this.txtMaPhieuHen);
			this.panel4.Controls.Add(this.lblMaPH);
			this.panel4.Controls.Add(this.btnTim);
			this.panel4.Location = new System.Drawing.Point(12, 465);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(377, 45);
			this.panel4.TabIndex = 52;
			// 
			// txtMaPhieuHen
			// 
			this.txtMaPhieuHen.Location = new System.Drawing.Point(110, 10);
			this.txtMaPhieuHen.Name = "txtMaPhieuHen";
			this.txtMaPhieuHen.Size = new System.Drawing.Size(127, 22);
			this.txtMaPhieuHen.TabIndex = 50;
			// 
			// lblMaPH
			// 
			this.lblMaPH.AutoSize = true;
			this.lblMaPH.ForeColor = System.Drawing.Color.OrangeRed;
			this.lblMaPH.Location = new System.Drawing.Point(14, 13);
			this.lblMaPH.Name = "lblMaPH";
			this.lblMaPH.Size = new System.Drawing.Size(90, 16);
			this.lblMaPH.TabIndex = 40;
			this.lblMaPH.Text = "Mã phiếu hẹn:";
			// 
			// btnTim
			// 
			this.btnTim.BackColor = System.Drawing.Color.Cornsilk;
			this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnTim.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnTim.Location = new System.Drawing.Point(243, 4);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(118, 34);
			this.btnTim.TabIndex = 43;
			this.btnTim.Text = "Tìm kiếm";
			this.btnTim.UseVisualStyleBackColor = false;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FloralWhite;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.dtpNgayLap);
			this.panel1.Controls.Add(this.dtpNgayHen);
			this.panel1.Controls.Add(this.txtSoLuong);
			this.panel1.Controls.Add(this.lblSoLuong);
			this.panel1.Controls.Add(this.cboMaNGK);
			this.panel1.Controls.Add(this.lblMaNGK);
			this.panel1.Controls.Add(this.cboMaKH);
			this.panel1.Controls.Add(this.txtMaPH);
			this.panel1.Controls.Add(this.lblNgayHenGiao);
			this.panel1.Controls.Add(this.lblMaPhieuHen);
			this.panel1.Controls.Add(this.lblMaKH);
			this.panel1.Controls.Add(this.lblNgayLapPH);
			this.panel1.Location = new System.Drawing.Point(14, 123);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(790, 126);
			this.panel1.TabIndex = 51;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(313, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(15, 16);
			this.label3.TabIndex = 65;
			this.label3.Text = "X";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(313, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 16);
			this.label2.TabIndex = 64;
			this.label2.Text = "X";
			// 
			// dtpNgayLap
			// 
			this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayLap.Location = new System.Drawing.Point(607, 16);
			this.dtpNgayLap.Name = "dtpNgayLap";
			this.dtpNgayLap.Size = new System.Drawing.Size(113, 22);
			this.dtpNgayLap.TabIndex = 63;
			// 
			// dtpNgayHen
			// 
			this.dtpNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayHen.Location = new System.Drawing.Point(607, 54);
			this.dtpNgayHen.Name = "dtpNgayHen";
			this.dtpNgayHen.Size = new System.Drawing.Size(113, 22);
			this.dtpNgayHen.TabIndex = 62;
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSoLuong.Location = new System.Drawing.Point(607, 90);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(148, 22);
			this.txtSoLuong.TabIndex = 61;
			// 
			// lblSoLuong
			// 
			this.lblSoLuong.AutoSize = true;
			this.lblSoLuong.ForeColor = System.Drawing.Color.OrangeRed;
			this.lblSoLuong.Location = new System.Drawing.Point(475, 93);
			this.lblSoLuong.Name = "lblSoLuong";
			this.lblSoLuong.Size = new System.Drawing.Size(63, 16);
			this.lblSoLuong.TabIndex = 60;
			this.lblSoLuong.Text = "Số lượng:";
			// 
			// cboMaNGK
			// 
			this.cboMaNGK.FormattingEnabled = true;
			this.cboMaNGK.Location = new System.Drawing.Point(149, 88);
			this.cboMaNGK.Name = "cboMaNGK";
			this.cboMaNGK.Size = new System.Drawing.Size(155, 24);
			this.cboMaNGK.TabIndex = 59;
			// 
			// lblMaNGK
			// 
			this.lblMaNGK.AutoSize = true;
			this.lblMaNGK.ForeColor = System.Drawing.Color.OrangeRed;
			this.lblMaNGK.Location = new System.Drawing.Point(26, 93);
			this.lblMaNGK.Name = "lblMaNGK";
			this.lblMaNGK.Size = new System.Drawing.Size(114, 16);
			this.lblMaNGK.TabIndex = 58;
			this.lblMaNGK.Text = "Mã nước giải khát:";
			// 
			// cboMaKH
			// 
			this.cboMaKH.FormattingEnabled = true;
			this.cboMaKH.Location = new System.Drawing.Point(149, 52);
			this.cboMaKH.Name = "cboMaKH";
			this.cboMaKH.Size = new System.Drawing.Size(155, 24);
			this.cboMaKH.TabIndex = 57;
			// 
			// txtMaPH
			// 
			this.txtMaPH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaPH.Location = new System.Drawing.Point(149, 16);
			this.txtMaPH.Name = "txtMaPH";
			this.txtMaPH.Size = new System.Drawing.Size(155, 22);
			this.txtMaPH.TabIndex = 56;
			// 
			// lblNgayHenGiao
			// 
			this.lblNgayHenGiao.AutoSize = true;
			this.lblNgayHenGiao.ForeColor = System.Drawing.Color.OrangeRed;
			this.lblNgayHenGiao.Location = new System.Drawing.Point(475, 56);
			this.lblNgayHenGiao.Name = "lblNgayHenGiao";
			this.lblNgayHenGiao.Size = new System.Drawing.Size(98, 16);
			this.lblNgayHenGiao.TabIndex = 55;
			this.lblNgayHenGiao.Text = "Ngày hẹn giao:";
			// 
			// lblMaPhieuHen
			// 
			this.lblMaPhieuHen.AutoSize = true;
			this.lblMaPhieuHen.ForeColor = System.Drawing.Color.OrangeRed;
			this.lblMaPhieuHen.Location = new System.Drawing.Point(26, 16);
			this.lblMaPhieuHen.Name = "lblMaPhieuHen";
			this.lblMaPhieuHen.Size = new System.Drawing.Size(90, 16);
			this.lblMaPhieuHen.TabIndex = 54;
			this.lblMaPhieuHen.Text = "Mã phiếu hẹn:";
			// 
			// lblMaKH
			// 
			this.lblMaKH.AutoSize = true;
			this.lblMaKH.ForeColor = System.Drawing.Color.OrangeRed;
			this.lblMaKH.Location = new System.Drawing.Point(26, 56);
			this.lblMaKH.Name = "lblMaKH";
			this.lblMaKH.Size = new System.Drawing.Size(101, 16);
			this.lblMaKH.TabIndex = 53;
			this.lblMaKH.Text = "Mã khách hàng:";
			// 
			// lblNgayLapPH
			// 
			this.lblNgayLapPH.AutoSize = true;
			this.lblNgayLapPH.ForeColor = System.Drawing.Color.OrangeRed;
			this.lblNgayLapPH.Location = new System.Drawing.Point(475, 16);
			this.lblNgayLapPH.Name = "lblNgayLapPH";
			this.lblNgayLapPH.Size = new System.Drawing.Size(126, 16);
			this.lblNgayLapPH.TabIndex = 52;
			this.lblNgayLapPH.Text = "Ngày lập phiếu hẹn:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.CadetBlue;
			this.label1.Location = new System.Drawing.Point(359, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 29);
			this.label1.TabIndex = 50;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Cornsilk;
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Salmon;
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(827, 71);
			this.label4.TabIndex = 55;
			this.label4.Text = "Phiếu Hẹn";
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
			this.lblThongTinChung.Size = new System.Drawing.Size(190, 25);
			this.lblThongTinChung.TabIndex = 56;
			this.lblThongTinChung.Text = "Thông tin Phiếu Hẹn";
			// 
			// frmPhieuHen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(827, 607);
			this.Controls.Add(this.lblThongTinChung);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dgvPhieuHen);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmPhieuHen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phiếu Hẹn";
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvPhieuHen)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
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
		private System.Windows.Forms.DataGridView dgvPhieuHen;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox txtMaPhieuHen;
		private System.Windows.Forms.Label lblMaPH;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dtpNgayLap;
		private System.Windows.Forms.DateTimePicker dtpNgayHen;
		private System.Windows.Forms.MaskedTextBox txtSoLuong;
		private System.Windows.Forms.Label lblSoLuong;
		private System.Windows.Forms.ComboBox cboMaNGK;
		private System.Windows.Forms.Label lblMaNGK;
		private System.Windows.Forms.ComboBox cboMaKH;
		private System.Windows.Forms.TextBox txtMaPH;
		private System.Windows.Forms.Label lblNgayHenGiao;
		private System.Windows.Forms.Label lblMaPhieuHen;
		private System.Windows.Forms.Label lblMaKH;
		private System.Windows.Forms.Label lblNgayLapPH;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblThongTinChung;
        private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}