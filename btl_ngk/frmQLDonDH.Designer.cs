namespace btl_ngk
{
	partial class frmQLDonDH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLDonDH));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnGuiDon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvDonDH = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.dtpNgayDH = new System.Windows.Forms.DateTimePicker();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.txtMaDDH = new System.Windows.Forms.TextBox();
            this.lblMaDonDH = new System.Windows.Forms.Label();
            this.lblNgayDH = new System.Windows.Forms.Label();
            this.lblThongTinChung = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaNGK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblMaNGK = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnGuiDon);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Location = new System.Drawing.Point(327, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 42);
            this.panel3.TabIndex = 55;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Cornsilk;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(270, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 34);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(102, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 34);
            this.btnSua.TabIndex = 43;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnGuiDon
            // 
            this.btnGuiDon.BackColor = System.Drawing.Color.Cornsilk;
            this.btnGuiDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGuiDon.Location = new System.Drawing.Point(15, 5);
            this.btnGuiDon.Name = "btnGuiDon";
            this.btnGuiDon.Size = new System.Drawing.Size(81, 34);
            this.btnGuiDon.TabIndex = 41;
            this.btnGuiDon.Text = "Reload";
            this.btnGuiDon.UseVisualStyleBackColor = false;
            this.btnGuiDon.Click += new System.EventHandler(this.btnGuiDon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Cornsilk;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(186, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 34);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvDonDH
            // 
            this.dgvDonDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonDH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDonDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonDH.Location = new System.Drawing.Point(12, 248);
            this.dgvDonDH.Name = "dgvDonDH";
            this.dgvDonDH.ReadOnly = true;
            this.dgvDonDH.RowHeadersWidth = 51;
            this.dgvDonDH.RowTemplate.Height = 24;
            this.dgvDonDH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDonDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonDH.Size = new System.Drawing.Size(723, 205);
            this.dgvDonDH.TabIndex = 54;
            this.dgvDonDH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDonDH_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.txtMaNCC);
            this.panel1.Controls.Add(this.dtpNgayDH);
            this.panel1.Controls.Add(this.lblMaNCC);
            this.panel1.Controls.Add(this.txtMaDDH);
            this.panel1.Controls.Add(this.lblMaDonDH);
            this.panel1.Controls.Add(this.lblNgayDH);
            this.panel1.Location = new System.Drawing.Point(12, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 128);
            this.panel1.TabIndex = 59;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNCC.Location = new System.Drawing.Point(151, 85);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(155, 22);
            this.txtMaNCC.TabIndex = 22;
            // 
            // dtpNgayDH
            // 
            this.dtpNgayDH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDH.Location = new System.Drawing.Point(152, 57);
            this.dtpNgayDH.Name = "dtpNgayDH";
            this.dtpNgayDH.Size = new System.Drawing.Size(154, 22);
            this.dtpNgayDH.TabIndex = 21;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMaNCC.Location = new System.Drawing.Point(24, 90);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(112, 16);
            this.lblMaNCC.TabIndex = 10;
            this.lblMaNCC.Text = "Mã nhà cung cấp:";
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDDH.Location = new System.Drawing.Point(151, 19);
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.ReadOnly = true;
            this.txtMaDDH.Size = new System.Drawing.Size(155, 22);
            this.txtMaDDH.TabIndex = 5;
            // 
            // lblMaDonDH
            // 
            this.lblMaDonDH.AutoSize = true;
            this.lblMaDonDH.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMaDonDH.Location = new System.Drawing.Point(24, 21);
            this.lblMaDonDH.Name = "lblMaDonDH";
            this.lblMaDonDH.Size = new System.Drawing.Size(110, 16);
            this.lblMaDonDH.TabIndex = 3;
            this.lblMaDonDH.Text = "Mã đơn đặt hàng:";
            // 
            // lblNgayDH
            // 
            this.lblNgayDH.AutoSize = true;
            this.lblNgayDH.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNgayDH.Location = new System.Drawing.Point(24, 57);
            this.lblNgayDH.Name = "lblNgayDH";
            this.lblNgayDH.Size = new System.Drawing.Size(98, 16);
            this.lblNgayDH.TabIndex = 1;
            this.lblNgayDH.Text = "Ngày đặt hàng:";
            // 
            // lblThongTinChung
            // 
            this.lblThongTinChung.AutoSize = true;
            this.lblThongTinChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblThongTinChung.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblThongTinChung.Location = new System.Drawing.Point(8, 82);
            this.lblThongTinChung.Name = "lblThongTinChung";
            this.lblThongTinChung.Size = new System.Drawing.Size(153, 25);
            this.lblThongTinChung.TabIndex = 60;
            this.lblThongTinChung.Text = "Thông tin chung";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.Controls.Add(this.txtMaNGK);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.lblMaNGK);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(368, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 124);
            this.panel2.TabIndex = 61;
            // 
            // txtMaNGK
            // 
            this.txtMaNGK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNGK.Location = new System.Drawing.Point(158, 16);
            this.txtMaNGK.Name = "txtMaNGK";
            this.txtMaNGK.ReadOnly = true;
            this.txtMaNGK.Size = new System.Drawing.Size(155, 22);
            this.txtMaNGK.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 24;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Location = new System.Drawing.Point(158, 52);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(155, 22);
            this.txtSoLuong.TabIndex = 21;
            // 
            // lblMaNGK
            // 
            this.lblMaNGK.AutoSize = true;
            this.lblMaNGK.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMaNGK.Location = new System.Drawing.Point(10, 18);
            this.lblMaNGK.Name = "lblMaNGK";
            this.lblMaNGK.Size = new System.Drawing.Size(114, 16);
            this.lblMaNGK.TabIndex = 3;
            this.lblMaNGK.Text = "Mã nước giải khát:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(10, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng đặt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(363, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Thông tin nước giải khát";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(756, 71);
            this.label2.TabIndex = 63;
            this.label2.Text = "Đơn Đặt Hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FloralWhite;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(13, 477);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(722, 61);
            this.panel4.TabIndex = 64;
            // 
            // frmQLDonDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 547);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThongTinChung);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDonDH);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLDonDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn Đặt Hàng";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.DataGridView dgvDonDH;
		private System.Windows.Forms.Button btnGuiDon;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dtpNgayDH;
		private System.Windows.Forms.Label lblMaNCC;
		private System.Windows.Forms.TextBox txtMaDDH;
		private System.Windows.Forms.Label lblMaDonDH;
		private System.Windows.Forms.Label lblNgayDH;
		private System.Windows.Forms.Label lblThongTinChung;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Label lblMaNGK;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMaNCC;
		private System.Windows.Forms.TextBox txtMaNGK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
    }
}