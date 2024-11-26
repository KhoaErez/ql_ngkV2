namespace btl_ngk
{
	partial class frmPhieuNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNo));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.dgvPhieuTraNo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.txtSoTienTra = new System.Windows.Forms.TextBox();
            this.txtMaPhieuTN = new System.Windows.Forms.TextBox();
            this.lblSoTienTra = new System.Windows.Forms.Label();
            this.lblMaPhieuGN = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThongTinChung = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTraNo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FloralWhite;
            this.panel3.Controls.Add(this.txtTimKiem);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Controls.Add(this.lblTimKiem);
            this.panel3.Location = new System.Drawing.Point(22, 211);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 47);
            this.panel3.TabIndex = 38;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Location = new System.Drawing.Point(206, 10);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(155, 22);
            this.txtTimKiem.TabIndex = 28;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cornsilk;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTimKiem.Location = new System.Drawing.Point(374, 3);
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
            this.lblTimKiem.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTimKiem.Location = new System.Drawing.Point(3, 16);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(177, 16);
            this.lblTimKiem.TabIndex = 11;
            this.lblTimKiem.Text = "Tìm thông tin bằng mã phiếu:";
            // 
            // dgvPhieuTraNo
            // 
            this.dgvPhieuTraNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuTraNo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieuTraNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuTraNo.Location = new System.Drawing.Point(22, 264);
            this.dgvPhieuTraNo.Name = "dgvPhieuTraNo";
            this.dgvPhieuTraNo.ReadOnly = true;
            this.dgvPhieuTraNo.RowHeadersWidth = 51;
            this.dgvPhieuTraNo.RowTemplate.Height = 24;
            this.dgvPhieuTraNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuTraNo.Size = new System.Drawing.Size(656, 172);
            this.dgvPhieuTraNo.TabIndex = 35;
            this.dgvPhieuTraNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPhieuTraNo_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(22, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 70);
            this.panel2.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Location = new System.Drawing.Point(131, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(507, 50);
            this.panel4.TabIndex = 58;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(10, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Cornsilk;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnThem.Location = new System.Drawing.Point(108, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 40);
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
            this.btnExit.Location = new System.Drawing.Point(402, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 40);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSua.Location = new System.Drawing.Point(206, 7);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 40);
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
            this.btnXoa.Location = new System.Drawing.Point(304, 7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 40);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.dtpNgayTra);
            this.panel1.Controls.Add(this.cboMaHD);
            this.panel1.Controls.Add(this.txtSoTienTra);
            this.panel1.Controls.Add(this.txtMaPhieuTN);
            this.panel1.Controls.Add(this.lblSoTienTra);
            this.panel1.Controls.Add(this.lblMaPhieuGN);
            this.panel1.Controls.Add(this.lblNgayTra);
            this.panel1.Controls.Add(this.lblMaHD);
            this.panel1.Location = new System.Drawing.Point(22, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 95);
            this.panel1.TabIndex = 36;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(138, 55);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(153, 22);
            this.dtpNgayTra.TabIndex = 11;
            // 
            // cboMaHD
            // 
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(460, 18);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(166, 24);
            this.cboMaHD.TabIndex = 10;
            // 
            // txtSoTienTra
            // 
            this.txtSoTienTra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoTienTra.Location = new System.Drawing.Point(460, 55);
            this.txtSoTienTra.Name = "txtSoTienTra";
            this.txtSoTienTra.Size = new System.Drawing.Size(166, 22);
            this.txtSoTienTra.TabIndex = 9;
            // 
            // txtMaPhieuTN
            // 
            this.txtMaPhieuTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhieuTN.Location = new System.Drawing.Point(138, 19);
            this.txtMaPhieuTN.Name = "txtMaPhieuTN";
            this.txtMaPhieuTN.Size = new System.Drawing.Size(155, 22);
            this.txtMaPhieuTN.TabIndex = 5;
            // 
            // lblSoTienTra
            // 
            this.lblSoTienTra.AutoSize = true;
            this.lblSoTienTra.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSoTienTra.Location = new System.Drawing.Point(371, 61);
            this.lblSoTienTra.Name = "lblSoTienTra";
            this.lblSoTienTra.Size = new System.Drawing.Size(69, 16);
            this.lblSoTienTra.TabIndex = 4;
            this.lblSoTienTra.Text = "Số tiền trả:";
            // 
            // lblMaPhieuGN
            // 
            this.lblMaPhieuGN.AutoSize = true;
            this.lblMaPhieuGN.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMaPhieuGN.Location = new System.Drawing.Point(24, 21);
            this.lblMaPhieuGN.Name = "lblMaPhieuGN";
            this.lblMaPhieuGN.Size = new System.Drawing.Size(104, 16);
            this.lblMaPhieuGN.TabIndex = 3;
            this.lblMaPhieuGN.Text = "Mã phiếu ghi nợ:";
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNgayTra.Location = new System.Drawing.Point(24, 60);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(61, 16);
            this.lblNgayTra.TabIndex = 2;
            this.lblNgayTra.Text = "Ngày trả:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMaHD.Location = new System.Drawing.Point(371, 21);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(81, 16);
            this.lblMaHD.TabIndex = 1;
            this.lblMaHD.Text = "Mã hóa đơn:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(696, 71);
            this.label4.TabIndex = 56;
            this.label4.Text = "Phiếu Nợ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThongTinChung
            // 
            this.lblThongTinChung.AutoSize = true;
            this.lblThongTinChung.BackColor = System.Drawing.Color.White;
            this.lblThongTinChung.CausesValidation = false;
            this.lblThongTinChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinChung.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblThongTinChung.Location = new System.Drawing.Point(6, 82);
            this.lblThongTinChung.Name = "lblThongTinChung";
            this.lblThongTinChung.Size = new System.Drawing.Size(179, 25);
            this.lblThongTinChung.TabIndex = 57;
            this.lblThongTinChung.Text = "Thông tin Phiếu Nợ";
            // 
            // frmPhieuNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 533);
            this.Controls.Add(this.lblThongTinChung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvPhieuTraNo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhieuNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Nợ";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTraNo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.Label lblTimKiem;
		private System.Windows.Forms.DataGridView dgvPhieuTraNo;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dtpNgayTra;
		private System.Windows.Forms.ComboBox cboMaHD;
		private System.Windows.Forms.TextBox txtSoTienTra;
		private System.Windows.Forms.TextBox txtMaPhieuTN;
		private System.Windows.Forms.Label lblSoTienTra;
		private System.Windows.Forms.Label lblMaPhieuGN;
		private System.Windows.Forms.Label lblNgayTra;
		private System.Windows.Forms.Label lblMaHD;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblThongTinChung;
        private System.Windows.Forms.Panel panel4;
    }
}