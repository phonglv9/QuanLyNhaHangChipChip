﻿
namespace _3_GUI
{
    partial class FrmQuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyNhanVien));
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtnHDnhanvien = new System.Windows.Forms.RadioButton();
            this.rbtnKHDnhanvien = new System.Windows.Forms.RadioButton();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.rbtn_QuanTri = new System.Windows.Forms.RadioButton();
            this.rbtn_NhanVien = new System.Windows.Forms.RadioButton();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_DiaChiNV = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(422, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(51, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Email :";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.a.ForeColor = System.Drawing.SystemColors.MenuText;
            this.a.Location = new System.Drawing.Point(51, 78);
            this.a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(113, 20);
            this.a.TabIndex = 40;
            this.a.Text = "Mã nhân viên:";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtEmail.Location = new System.Drawing.Point(183, 185);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 26);
            this.txtEmail.TabIndex = 36;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaNV.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtMaNV.Location = new System.Drawing.Point(183, 74);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(256, 26);
            this.txtMaNV.TabIndex = 39;
            this.txtMaNV.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label7.Location = new System.Drawing.Point(576, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Trạng thái :";
            // 
            // rbtnHDnhanvien
            // 
            this.rbtnHDnhanvien.AutoSize = true;
            this.rbtnHDnhanvien.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbtnHDnhanvien.Location = new System.Drawing.Point(707, 124);
            this.rbtnHDnhanvien.Name = "rbtnHDnhanvien";
            this.rbtnHDnhanvien.Size = new System.Drawing.Size(102, 24);
            this.rbtnHDnhanvien.TabIndex = 42;
            this.rbtnHDnhanvien.TabStop = true;
            this.rbtnHDnhanvien.Text = "Hoạt động";
            this.rbtnHDnhanvien.UseVisualStyleBackColor = true;
            // 
            // rbtnKHDnhanvien
            // 
            this.rbtnKHDnhanvien.AutoSize = true;
            this.rbtnKHDnhanvien.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbtnKHDnhanvien.Location = new System.Drawing.Point(852, 124);
            this.rbtnKHDnhanvien.Name = "rbtnKHDnhanvien";
            this.rbtnKHDnhanvien.Size = new System.Drawing.Size(146, 24);
            this.rbtnKHDnhanvien.TabIndex = 41;
            this.rbtnKHDnhanvien.TabStop = true;
            this.rbtnKHDnhanvien.Text = "Không hoạt động";
            this.rbtnKHDnhanvien.UseVisualStyleBackColor = true;
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.AllowUserToResizeRows = false;
            this.dgvMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonAn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvMonAn.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvMonAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonAn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMonAn.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMonAn.Location = new System.Drawing.Point(29, 365);
            this.dgvMonAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMonAn.MultiSelect = false;
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.RowHeadersVisible = false;
            this.dgvMonAn.RowHeadersWidth = 51;
            this.dgvMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonAn.Size = new System.Drawing.Size(1018, 497);
            this.dgvMonAn.TabIndex = 43;
            this.dgvMonAn.TabStop = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtMatKhau.Location = new System.Drawing.Point(183, 236);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(256, 26);
            this.txtMatKhau.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(55, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.Location = new System.Drawing.Point(51, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Mật Khẩu :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(576, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 23);
            this.label10.TabIndex = 119;
            this.label10.Text = "Vai trò:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(576, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 23);
            this.label11.TabIndex = 120;
            this.label11.Text = "Số điện thoại :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(576, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 23);
            this.label12.TabIndex = 121;
            this.label12.Text = "Địa chỉ :";
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaHang.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblMaHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMaHang.Location = new System.Drawing.Point(51, 134);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(126, 23);
            this.lblMaHang.TabIndex = 122;
            this.lblMaHang.Text = "Tên nhân viên :";
            // 
            // rbtn_QuanTri
            // 
            this.rbtn_QuanTri.AutoSize = true;
            this.rbtn_QuanTri.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbtn_QuanTri.Location = new System.Drawing.Point(707, 184);
            this.rbtn_QuanTri.Name = "rbtn_QuanTri";
            this.rbtn_QuanTri.Size = new System.Drawing.Size(85, 24);
            this.rbtn_QuanTri.TabIndex = 114;
            this.rbtn_QuanTri.TabStop = true;
            this.rbtn_QuanTri.Text = "Quản Trị";
            this.rbtn_QuanTri.UseVisualStyleBackColor = true;
            // 
            // rbtn_NhanVien
            // 
            this.rbtn_NhanVien.AutoSize = true;
            this.rbtn_NhanVien.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rbtn_NhanVien.Location = new System.Drawing.Point(852, 184);
            this.rbtn_NhanVien.Name = "rbtn_NhanVien";
            this.rbtn_NhanVien.Size = new System.Drawing.Size(98, 24);
            this.rbtn_NhanVien.TabIndex = 113;
            this.rbtn_NhanVien.Text = "Nhân Viên";
            this.rbtn_NhanVien.UseVisualStyleBackColor = true;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_SDT.Location = new System.Drawing.Point(707, 71);
            this.txt_SDT.Multiline = true;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(243, 27);
            this.txt_SDT.TabIndex = 111;
            // 
            // txt_DiaChiNV
            // 
            this.txt_DiaChiNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiaChiNV.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_DiaChiNV.Location = new System.Drawing.Point(707, 240);
            this.txt_DiaChiNV.Multiline = true;
            this.txt_DiaChiNV.Name = "txt_DiaChiNV";
            this.txt_DiaChiNV.Size = new System.Drawing.Size(275, 57);
            this.txt_DiaChiNV.TabIndex = 112;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenNV.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_TenNV.Location = new System.Drawing.Point(183, 134);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(256, 27);
            this.txt_TenNV.TabIndex = 110;
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_Search.Location = new System.Drawing.Point(788, 322);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PlaceholderText = "Mời nhập tên hoặc email để tìm kiếm";
            this.txt_Search.Size = new System.Drawing.Size(257, 35);
            this.txt_Search.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(696, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 123;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoaNV.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNV.Image")));
            this.btnXoaNV.Location = new System.Drawing.Point(657, 886);
            this.btnXoaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(125, 49);
            this.btnXoaNV.TabIndex = 127;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaNV.UseVisualStyleBackColor = true;
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuaNV.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNV.Image")));
            this.btnSuaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaNV.Location = new System.Drawing.Point(472, 886);
            this.btnSuaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(125, 49);
            this.btnSuaNV.TabIndex = 126;
            this.btnSuaNV.Text = "Sửa ";
            this.btnSuaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaNV.UseVisualStyleBackColor = true;
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNV.Image")));
            this.btnThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNV.Location = new System.Drawing.Point(289, 886);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(125, 49);
            this.btnThemNV.TabIndex = 125;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            // 
            // FrmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 952);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblMaHang);
            this.Controls.Add(this.rbtn_QuanTri);
            this.Controls.Add(this.rbtn_NhanVien);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_DiaChiNV);
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.dgvMonAn);
            this.Controls.Add(this.rbtnKHDnhanvien);
            this.Controls.Add(this.rbtnHDnhanvien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.a);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtnHDnhanvien;
        private System.Windows.Forms.RadioButton rbtnKHDnhanvien;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.RadioButton rbtn_QuanTri;
        private System.Windows.Forms.RadioButton rbtn_NhanVien;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_DiaChiNV;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnThemNV;
    }
}