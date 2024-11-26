namespace btl_ngk
{
	partial class frmNGK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNGK));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNGK = new System.Windows.Forms.TextBox();
            this.txtMaNGK = new System.Windows.Forms.TextBox();
            this.lblMaLoaiNGK = new System.Windows.Forms.Label();
            this.lblTenNGK = new System.Windows.Forms.Label();
            this.cboMaLoaiNGK = new System.Windows.Forms.ComboBox();
            this.lblMaNGK = new System.Windows.Forms.Label();
            this.dgvNGK = new System.Windows.Forms.DataGridView();
            this.colMaDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLoaiDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblDoChoi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThongTinChung = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNGK)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.txtDonGia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTenNGK);
            this.panel1.Controls.Add(this.txtMaNGK);
            this.panel1.Controls.Add(this.lblMaLoaiNGK);
            this.panel1.Controls.Add(this.lblTenNGK);
            this.panel1.Controls.Add(this.cboMaLoaiNGK);
            this.panel1.Controls.Add(this.lblMaNGK);
            this.panel1.Location = new System.Drawing.Point(12, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 91);
            this.panel1.TabIndex = 29;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Location = new System.Drawing.Point(498, 55);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(177, 22);
            this.txtDonGia.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(343, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Đơn giá:";
            // 
            // txtTenNGK
            // 
            this.txtTenNGK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNGK.Location = new System.Drawing.Point(132, 59);
            this.txtTenNGK.Name = "txtTenNGK";
            this.txtTenNGK.Size = new System.Drawing.Size(177, 22);
            this.txtTenNGK.TabIndex = 14;
            // 
            // txtMaNGK
            // 
            this.txtMaNGK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNGK.Location = new System.Drawing.Point(132, 20);
            this.txtMaNGK.Name = "txtMaNGK";
            this.txtMaNGK.Size = new System.Drawing.Size(177, 22);
            this.txtMaNGK.TabIndex = 13;
            // 
            // lblMaLoaiNGK
            // 
            this.lblMaLoaiNGK.AutoSize = true;
            this.lblMaLoaiNGK.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMaLoaiNGK.Location = new System.Drawing.Point(343, 22);
            this.lblMaLoaiNGK.Name = "lblMaLoaiNGK";
            this.lblMaLoaiNGK.Size = new System.Drawing.Size(139, 16);
            this.lblMaLoaiNGK.TabIndex = 12;
            this.lblMaLoaiNGK.Text = "Mã loại nước giải khát:";
            // 
            // lblTenNGK
            // 
            this.lblTenNGK.AutoSize = true;
            this.lblTenNGK.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTenNGK.Location = new System.Drawing.Point(3, 61);
            this.lblTenNGK.Name = "lblTenNGK";
            this.lblTenNGK.Size = new System.Drawing.Size(119, 16);
            this.lblTenNGK.TabIndex = 6;
            this.lblTenNGK.Text = "Tên nước giải khát:";
            // 
            // cboMaLoaiNGK
            // 
            this.cboMaLoaiNGK.FormattingEnabled = true;
            this.cboMaLoaiNGK.Location = new System.Drawing.Point(498, 19);
            this.cboMaLoaiNGK.Name = "cboMaLoaiNGK";
            this.cboMaLoaiNGK.Size = new System.Drawing.Size(218, 24);
            this.cboMaLoaiNGK.TabIndex = 20;
            // 
            // lblMaNGK
            // 
            this.lblMaNGK.AutoSize = true;
            this.lblMaNGK.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMaNGK.Location = new System.Drawing.Point(3, 22);
            this.lblMaNGK.Name = "lblMaNGK";
            this.lblMaNGK.Size = new System.Drawing.Size(114, 16);
            this.lblMaNGK.TabIndex = 5;
            this.lblMaNGK.Text = "Mã nước giải khát:";
            // 
            // dgvNGK
            // 
            this.dgvNGK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNGK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNGK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNGK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDC,
            this.colTenDC,
            this.colMaLoaiDC});
            this.dgvNGK.Location = new System.Drawing.Point(12, 230);
            this.dgvNGK.MultiSelect = false;
            this.dgvNGK.Name = "dgvNGK";
            this.dgvNGK.ReadOnly = true;
            this.dgvNGK.RowHeadersWidth = 51;
            this.dgvNGK.RowTemplate.Height = 24;
            this.dgvNGK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNGK.Size = new System.Drawing.Size(717, 199);
            this.dgvNGK.TabIndex = 28;
            this.dgvNGK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvNGK_MouseClick);
            // 
            // colMaDC
            // 
            this.colMaDC.DataPropertyName = "MaNGK";
            this.colMaDC.HeaderText = "Mã nước giải khát";
            this.colMaDC.MinimumWidth = 6;
            this.colMaDC.Name = "colMaDC";
            this.colMaDC.ReadOnly = true;
            // 
            // colTenDC
            // 
            this.colTenDC.DataPropertyName = "TenNGK";
            this.colTenDC.HeaderText = "Tên nước giải khát";
            this.colTenDC.MinimumWidth = 6;
            this.colTenDC.Name = "colTenDC";
            this.colTenDC.ReadOnly = true;
            // 
            // colMaLoaiDC
            // 
            this.colMaLoaiDC.DataPropertyName = "MaLoai";
            this.colMaLoaiDC.HeaderText = "Mã loại nước giải khát";
            this.colMaLoaiDC.MinimumWidth = 6;
            this.colMaLoaiDC.Name = "colMaLoaiDC";
            this.colMaLoaiDC.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(12, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 62);
            this.panel2.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.Controls.Add(this.btnLoad);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Location = new System.Drawing.Point(196, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(507, 45);
            this.panel4.TabIndex = 54;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Cornsilk;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnLoad.Location = new System.Drawing.Point(8, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(92, 39);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Reload";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSua.Location = new System.Drawing.Point(302, 3);
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
            this.btnThem.Location = new System.Drawing.Point(106, 3);
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
            this.btnExit.Location = new System.Drawing.Point(400, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 39);
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
            this.btnXoa.Location = new System.Drawing.Point(204, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 39);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblDoChoi
            // 
            this.lblDoChoi.AutoSize = true;
            this.lblDoChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoChoi.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDoChoi.Location = new System.Drawing.Point(209, 54);
            this.lblDoChoi.Name = "lblDoChoi";
            this.lblDoChoi.Size = new System.Drawing.Size(0, 29);
            this.lblDoChoi.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(741, 71);
            this.label4.TabIndex = 52;
            this.label4.Text = "Danh Mục Nước Giải Khát";
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
            this.lblThongTinChung.Size = new System.Drawing.Size(185, 25);
            this.lblThongTinChung.TabIndex = 53;
            this.lblThongTinChung.Text = "Thông tin danh mục";
            // 
            // frmNGK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 514);
            this.Controls.Add(this.lblThongTinChung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvNGK);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDoChoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNGK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nước Giải Khát";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNGK)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtTenNGK;
		private System.Windows.Forms.TextBox txtMaNGK;
		private System.Windows.Forms.Label lblMaLoaiNGK;
		private System.Windows.Forms.Label lblTenNGK;
		private System.Windows.Forms.ComboBox cboMaLoaiNGK;
		private System.Windows.Forms.Label lblMaNGK;
		private System.Windows.Forms.DataGridView dgvNGK;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaDC;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTenDC;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiDC;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Label lblDoChoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblThongTinChung;
        private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.Label label1;
	}
}