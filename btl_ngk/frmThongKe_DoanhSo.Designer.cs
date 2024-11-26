namespace btl_ngk
{
	partial class frmThongKe_DoanhSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe_DoanhSo));
            this.dtpTK = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDoanhSo = new System.Windows.Forms.DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhSo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTK
            // 
            this.dtpTK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTK.Location = new System.Drawing.Point(579, 95);
            this.dtpTK.Name = "dtpTK";
            this.dtpTK.Size = new System.Drawing.Size(200, 22);
            this.dtpTK.TabIndex = 15;
            this.dtpTK.ValueChanged += new System.EventHandler(this.dtpTK_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(22, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tông tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(140, 377);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(291, 30);
            this.txtTongTien.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 12;
            // 
            // dgvDoanhSo
            // 
            this.dgvDoanhSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhSo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colMaNGK,
            this.colSoLuongMua,
            this.colDonGiaBan});
            this.dgvDoanhSo.Location = new System.Drawing.Point(27, 123);
            this.dgvDoanhSo.MultiSelect = false;
            this.dgvDoanhSo.Name = "dgvDoanhSo";
            this.dgvDoanhSo.ReadOnly = true;
            this.dgvDoanhSo.RowHeadersWidth = 51;
            this.dgvDoanhSo.RowTemplate.Height = 24;
            this.dgvDoanhSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhSo.Size = new System.Drawing.Size(752, 243);
            this.dgvDoanhSo.TabIndex = 11;
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
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Cornsilk;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnThoat.Location = new System.Drawing.Point(628, 372);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 41);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(800, 71);
            this.label4.TabIndex = 57;
            this.label4.Text = "Thống Kê Doanh Số";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThongKe_DoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDoanhSo);
            this.Controls.Add(this.btnThoat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongKe_DoanhSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Doanh Số";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpTK;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvDoanhSo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaNGK;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongMua;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaBan;
		private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
    }
}