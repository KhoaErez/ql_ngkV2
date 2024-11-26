namespace btl_ngk
{
	partial class frmLoaiNGK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiNGK));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.cboMaNhaCC = new System.Windows.Forms.ComboBox();
            this.txtTenLoaiNGK = new System.Windows.Forms.TextBox();
            this.txtMaLoaiNGK = new System.Windows.Forms.TextBox();
            this.lblTenLoaiNGK = new System.Windows.Forms.Label();
            this.lblMaLoaiNGK = new System.Windows.Forms.Label();
            this.dgvLoaiNGK = new System.Windows.Forms.DataGridView();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblLoaiDoChoi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThongTinChung = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNGK)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.lblMaNCC);
            this.panel1.Controls.Add(this.cboMaNhaCC);
            this.panel1.Controls.Add(this.txtTenLoaiNGK);
            this.panel1.Controls.Add(this.txtMaLoaiNGK);
            this.panel1.Controls.Add(this.lblTenLoaiNGK);
            this.panel1.Controls.Add(this.lblMaLoaiNGK);
            this.panel1.Location = new System.Drawing.Point(9, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 85);
            this.panel1.TabIndex = 28;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMaNCC.Location = new System.Drawing.Point(9, 51);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(112, 16);
            this.lblMaNCC.TabIndex = 23;
            this.lblMaNCC.Text = "Mã nhà cung cấp:";
            // 
            // cboMaNhaCC
            // 
            this.cboMaNhaCC.FormattingEnabled = true;
            this.cboMaNhaCC.Location = new System.Drawing.Point(157, 51);
            this.cboMaNhaCC.Name = "cboMaNhaCC";
            this.cboMaNhaCC.Size = new System.Drawing.Size(176, 24);
            this.cboMaNhaCC.TabIndex = 22;
            // 
            // txtTenLoaiNGK
            // 
            this.txtTenLoaiNGK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLoaiNGK.Location = new System.Drawing.Point(505, 16);
            this.txtTenLoaiNGK.Name = "txtTenLoaiNGK";
            this.txtTenLoaiNGK.Size = new System.Drawing.Size(187, 22);
            this.txtTenLoaiNGK.TabIndex = 5;
            // 
            // txtMaLoaiNGK
            // 
            this.txtMaLoaiNGK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLoaiNGK.Location = new System.Drawing.Point(157, 16);
            this.txtMaLoaiNGK.Name = "txtMaLoaiNGK";
            this.txtMaLoaiNGK.Size = new System.Drawing.Size(176, 22);
            this.txtMaLoaiNGK.TabIndex = 4;
            // 
            // lblTenLoaiNGK
            // 
            this.lblTenLoaiNGK.AutoSize = true;
            this.lblTenLoaiNGK.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTenLoaiNGK.Location = new System.Drawing.Point(354, 18);
            this.lblTenLoaiNGK.Name = "lblTenLoaiNGK";
            this.lblTenLoaiNGK.Size = new System.Drawing.Size(144, 16);
            this.lblTenLoaiNGK.TabIndex = 1;
            this.lblTenLoaiNGK.Text = "Tên loại nước giải khát:";
            // 
            // lblMaLoaiNGK
            // 
            this.lblMaLoaiNGK.AutoSize = true;
            this.lblMaLoaiNGK.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMaLoaiNGK.Location = new System.Drawing.Point(9, 18);
            this.lblMaLoaiNGK.Name = "lblMaLoaiNGK";
            this.lblMaLoaiNGK.Size = new System.Drawing.Size(139, 16);
            this.lblMaLoaiNGK.TabIndex = 0;
            this.lblMaLoaiNGK.Text = "Mã loại nước giải khát:";
            // 
            // dgvLoaiNGK
            // 
            this.dgvLoaiNGK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiNGK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLoaiNGK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiNGK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoai,
            this.TenLoai,
            this.MaNhaCC});
            this.dgvLoaiNGK.Location = new System.Drawing.Point(9, 205);
            this.dgvLoaiNGK.Name = "dgvLoaiNGK";
            this.dgvLoaiNGK.ReadOnly = true;
            this.dgvLoaiNGK.RowHeadersWidth = 51;
            this.dgvLoaiNGK.RowTemplate.Height = 24;
            this.dgvLoaiNGK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiNGK.Size = new System.Drawing.Size(695, 204);
            this.dgvLoaiNGK.TabIndex = 27;
            this.dgvLoaiNGK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvLoaiNGK_MouseClick);
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã loại nước giải khát";
            this.MaLoai.MinimumWidth = 6;
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "Tên loại nước giải khát";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            // 
            // MaNhaCC
            // 
            this.MaNhaCC.DataPropertyName = "MaNCC";
            this.MaNhaCC.HeaderText = "Mã nhà cung cấp";
            this.MaNhaCC.MinimumWidth = 6;
            this.MaNhaCC.Name = "MaNhaCC";
            this.MaNhaCC.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(6, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 63);
            this.panel2.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.btnLoad);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Location = new System.Drawing.Point(232, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(453, 45);
            this.panel4.TabIndex = 29;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Cornsilk;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Location = new System.Drawing.Point(367, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 39);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Cornsilk;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnThem.Location = new System.Drawing.Point(93, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 39);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Cornsilk;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnLoad.Location = new System.Drawing.Point(5, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 39);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Reload";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Cornsilk;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.Location = new System.Drawing.Point(189, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 39);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSua.Location = new System.Drawing.Point(281, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 39);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblLoaiDoChoi
            // 
            this.lblLoaiDoChoi.AutoSize = true;
            this.lblLoaiDoChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiDoChoi.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblLoaiDoChoi.Location = new System.Drawing.Point(193, 17);
            this.lblLoaiDoChoi.Name = "lblLoaiDoChoi";
            this.lblLoaiDoChoi.Size = new System.Drawing.Size(0, 29);
            this.lblLoaiDoChoi.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(727, 71);
            this.label4.TabIndex = 51;
            this.label4.Text = "Loại Nước Giải Khát";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThongTinChung
            // 
            this.lblThongTinChung.AutoSize = true;
            this.lblThongTinChung.BackColor = System.Drawing.Color.White;
            this.lblThongTinChung.CausesValidation = false;
            this.lblThongTinChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinChung.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblThongTinChung.Location = new System.Drawing.Point(8, 80);
            this.lblThongTinChung.Name = "lblThongTinChung";
            this.lblThongTinChung.Size = new System.Drawing.Size(177, 25);
            this.lblThongTinChung.TabIndex = 54;
            this.lblThongTinChung.Text = "Thông tin loại nước";
            // 
            // frmLoaiNGK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 510);
            this.Controls.Add(this.lblThongTinChung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLoaiNGK);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblLoaiDoChoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoaiNGK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại NGK";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNGK)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblMaNCC;
		private System.Windows.Forms.ComboBox cboMaNhaCC;
		private System.Windows.Forms.TextBox txtTenLoaiNGK;
		private System.Windows.Forms.TextBox txtMaLoaiNGK;
		private System.Windows.Forms.Label lblTenLoaiNGK;
		private System.Windows.Forms.Label lblMaLoaiNGK;
		private System.Windows.Forms.DataGridView dgvLoaiNGK;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Label lblLoaiDoChoi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblThongTinChung;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaCC;
	}
}