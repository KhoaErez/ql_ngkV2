namespace btl_ngk
{
	partial class frmThongKeNGK_BanChay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeNGK_BanChay));
			this.btnThoat = new System.Windows.Forms.Button();
			this.dgvTkeBanChay = new System.Windows.Forms.DataGridView();
			this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMaNGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSoLuongMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvTkeBanChay)).BeginInit();
			this.SuspendLayout();
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.Cornsilk;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnThoat.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnThoat.Location = new System.Drawing.Point(590, 329);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(128, 37);
			this.btnThoat.TabIndex = 6;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// dgvTkeBanChay
			// 
			this.dgvTkeBanChay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTkeBanChay.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvTkeBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTkeBanChay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colMaNGK,
            this.colSoLuongMua,
            this.colDonGiaBan});
			this.dgvTkeBanChay.Location = new System.Drawing.Point(30, 80);
			this.dgvTkeBanChay.Name = "dgvTkeBanChay";
			this.dgvTkeBanChay.ReadOnly = true;
			this.dgvTkeBanChay.RowHeadersWidth = 51;
			this.dgvTkeBanChay.RowTemplate.Height = 24;
			this.dgvTkeBanChay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTkeBanChay.Size = new System.Drawing.Size(688, 243);
			this.dgvTkeBanChay.TabIndex = 4;
			this.dgvTkeBanChay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTkeBanChay_CellContentClick);
			// 
			// colMaHD
			// 
			this.colMaHD.DataPropertyName = "MaHD";
			this.colMaHD.HeaderText = "Mã hóa đơn";
			this.colMaHD.MinimumWidth = 6;
			this.colMaHD.Name = "colMaHD";
			this.colMaHD.ReadOnly = true;
			// 
			// colMaNGK
			// 
			this.colMaNGK.DataPropertyName = "MaNGK";
			this.colMaNGK.HeaderText = "Mã nước giải khát";
			this.colMaNGK.MinimumWidth = 6;
			this.colMaNGK.Name = "colMaNGK";
			this.colMaNGK.ReadOnly = true;
			// 
			// colSoLuongMua
			// 
			this.colSoLuongMua.DataPropertyName = "SoLuongMua";
			this.colSoLuongMua.HeaderText = "Số lượng mua";
			this.colSoLuongMua.MinimumWidth = 6;
			this.colSoLuongMua.Name = "colSoLuongMua";
			this.colSoLuongMua.ReadOnly = true;
			// 
			// colDonGiaBan
			// 
			this.colDonGiaBan.DataPropertyName = "DonGiaBan";
			this.colDonGiaBan.HeaderText = "Đơn giá bán";
			this.colDonGiaBan.MinimumWidth = 6;
			this.colDonGiaBan.Name = "colDonGiaBan";
			this.colDonGiaBan.ReadOnly = true;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Cornsilk;
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Salmon;
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(748, 71);
			this.label4.TabIndex = 57;
			this.label4.Text = "Thống Kê Nước Giải Khát Bán CHayk";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmThongKeNGK_BanChay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(748, 395);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dgvTkeBanChay);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmThongKeNGK_BanChay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thống Kê Loại Bán Chạy";
			((System.ComponentModel.ISupportInitialize)(this.dgvTkeBanChay)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.DataGridView dgvTkeBanChay;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaNGK;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongMua;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaBan;
        private System.Windows.Forms.Label label4;
    }
}