
namespace QLThuCung.Views
{
    partial class QuanLy
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
            this.tabctrlMain = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabThuCung = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbTimThuCung = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuyThuCung = new System.Windows.Forms.Button();
            this.btnLuuThuCung = new System.Windows.Forms.Button();
            this.btnXoaThuCung = new System.Windows.Forms.Button();
            this.btnThemThuCung = new System.Windows.Forms.Button();
            this.pnlDataBind = new System.Windows.Forms.Panel();
            this.tbGiaNhapThuCung = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCanNangThuCung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNccThuCung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTuoiThuCung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLoaiThuCung = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIDThuCung = new System.Windows.Forms.TextBox();
            this.labMaDoUong = new System.Windows.Forms.Label();
            this.tbTimThuCung = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvThuCung = new System.Windows.Forms.DataGridView();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.btnSuaThuCung = new System.Windows.Forms.Button();
            this.panelLuuHuy = new System.Windows.Forms.Panel();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.tabctrlMain.SuspendLayout();
            this.tabThuCung.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDataBind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).BeginInit();
            this.panelLuuHuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctrlMain
            // 
            this.tabctrlMain.Controls.Add(this.tabHome);
            this.tabctrlMain.Controls.Add(this.tabThuCung);
            this.tabctrlMain.Controls.Add(this.tabKhachHang);
            this.tabctrlMain.Controls.Add(this.tabNhanVien);
            this.tabctrlMain.Controls.Add(this.tabAdmin);
            this.tabctrlMain.ItemSize = new System.Drawing.Size(42, 18);
            this.tabctrlMain.Location = new System.Drawing.Point(12, 12);
            this.tabctrlMain.Name = "tabctrlMain";
            this.tabctrlMain.SelectedIndex = 0;
            this.tabctrlMain.Size = new System.Drawing.Size(969, 621);
            this.tabctrlMain.TabIndex = 0;
            this.tabctrlMain.Click += new System.EventHandler(this.tabctrlMain_Click);
            // 
            // tabHome
            // 
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(961, 595);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabThuCung
            // 
            this.tabThuCung.Controls.Add(this.panel1);
            this.tabThuCung.Controls.Add(this.dgvThuCung);
            this.tabThuCung.Location = new System.Drawing.Point(4, 22);
            this.tabThuCung.Name = "tabThuCung";
            this.tabThuCung.Padding = new System.Windows.Forms.Padding(3);
            this.tabThuCung.Size = new System.Drawing.Size(961, 595);
            this.tabThuCung.TabIndex = 1;
            this.tabThuCung.Text = "ThuCung";
            this.tabThuCung.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbTimThuCung);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlDataBind);
            this.panel1.Controls.Add(this.tbTimThuCung);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Location = new System.Drawing.Point(558, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 532);
            this.panel1.TabIndex = 1;
            // 
            // cbbTimThuCung
            // 
            this.cbbTimThuCung.FormattingEnabled = true;
            this.cbbTimThuCung.Items.AddRange(new object[] {
            "Loại",
            "Giới Tính",
            "Tuổi"});
            this.cbbTimThuCung.Location = new System.Drawing.Point(22, 32);
            this.cbbTimThuCung.Name = "cbbTimThuCung";
            this.cbbTimThuCung.Size = new System.Drawing.Size(90, 21);
            this.cbbTimThuCung.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelLuuHuy);
            this.panel2.Controls.Add(this.btnSuaThuCung);
            this.panel2.Controls.Add(this.btnXoaThuCung);
            this.panel2.Controls.Add(this.btnThemThuCung);
            this.panel2.Location = new System.Drawing.Point(0, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 138);
            this.panel2.TabIndex = 15;
            // 
            // btnHuyThuCung
            // 
            this.btnHuyThuCung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyThuCung.Location = new System.Drawing.Point(115, 9);
            this.btnHuyThuCung.Name = "btnHuyThuCung";
            this.btnHuyThuCung.Size = new System.Drawing.Size(89, 30);
            this.btnHuyThuCung.TabIndex = 19;
            this.btnHuyThuCung.Text = "Hủy";
            this.btnHuyThuCung.UseVisualStyleBackColor = true;
            this.btnHuyThuCung.Click += new System.EventHandler(this.btnHuyThuCung_Click);
            // 
            // btnLuuThuCung
            // 
            this.btnLuuThuCung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuThuCung.Location = new System.Drawing.Point(9, 9);
            this.btnLuuThuCung.Name = "btnLuuThuCung";
            this.btnLuuThuCung.Size = new System.Drawing.Size(89, 30);
            this.btnLuuThuCung.TabIndex = 20;
            this.btnLuuThuCung.Text = "Lưu";
            this.btnLuuThuCung.UseVisualStyleBackColor = true;
            this.btnLuuThuCung.Click += new System.EventHandler(this.btnLuuThuCung_Click);
            // 
            // btnXoaThuCung
            // 
            this.btnXoaThuCung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThuCung.Location = new System.Drawing.Point(222, 9);
            this.btnXoaThuCung.Name = "btnXoaThuCung";
            this.btnXoaThuCung.Size = new System.Drawing.Size(89, 30);
            this.btnXoaThuCung.TabIndex = 18;
            this.btnXoaThuCung.Text = "Xóa";
            this.btnXoaThuCung.UseVisualStyleBackColor = true;
            this.btnXoaThuCung.Click += new System.EventHandler(this.btnXoaThuCung_Click);
            // 
            // btnThemThuCung
            // 
            this.btnThemThuCung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThuCung.Location = new System.Drawing.Point(9, 9);
            this.btnThemThuCung.Name = "btnThemThuCung";
            this.btnThemThuCung.Size = new System.Drawing.Size(89, 30);
            this.btnThemThuCung.TabIndex = 16;
            this.btnThemThuCung.Text = "Thêm";
            this.btnThemThuCung.UseVisualStyleBackColor = true;
            this.btnThemThuCung.Click += new System.EventHandler(this.btnThemThuCung_Click);
            // 
            // pnlDataBind
            // 
            this.pnlDataBind.Controls.Add(this.cbGioitinh);
            this.pnlDataBind.Controls.Add(this.tbGiaNhapThuCung);
            this.pnlDataBind.Controls.Add(this.label6);
            this.pnlDataBind.Controls.Add(this.label5);
            this.pnlDataBind.Controls.Add(this.tbCanNangThuCung);
            this.pnlDataBind.Controls.Add(this.label4);
            this.pnlDataBind.Controls.Add(this.tbNccThuCung);
            this.pnlDataBind.Controls.Add(this.label2);
            this.pnlDataBind.Controls.Add(this.tbTuoiThuCung);
            this.pnlDataBind.Controls.Add(this.label3);
            this.pnlDataBind.Controls.Add(this.tbLoaiThuCung);
            this.pnlDataBind.Controls.Add(this.label7);
            this.pnlDataBind.Controls.Add(this.tbIDThuCung);
            this.pnlDataBind.Controls.Add(this.labMaDoUong);
            this.pnlDataBind.Location = new System.Drawing.Point(4, 86);
            this.pnlDataBind.Name = "pnlDataBind";
            this.pnlDataBind.Size = new System.Drawing.Size(381, 277);
            this.pnlDataBind.TabIndex = 9;
            // 
            // tbGiaNhapThuCung
            // 
            this.tbGiaNhapThuCung.Location = new System.Drawing.Point(106, 212);
            this.tbGiaNhapThuCung.Name = "tbGiaNhapThuCung";
            this.tbGiaNhapThuCung.Size = new System.Drawing.Size(109, 20);
            this.tbGiaNhapThuCung.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá Nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới Tính:";
            // 
            // tbCanNangThuCung
            // 
            this.tbCanNangThuCung.Location = new System.Drawing.Point(91, 126);
            this.tbCanNangThuCung.Name = "tbCanNangThuCung";
            this.tbCanNangThuCung.Size = new System.Drawing.Size(80, 20);
            this.tbCanNangThuCung.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cân Nặng";
            // 
            // tbNccThuCung
            // 
            this.tbNccThuCung.Location = new System.Drawing.Point(78, 82);
            this.tbNccThuCung.Name = "tbNccThuCung";
            this.tbNccThuCung.Size = new System.Drawing.Size(137, 20);
            this.tbNccThuCung.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "NCC:";
            // 
            // tbTuoiThuCung
            // 
            this.tbTuoiThuCung.Location = new System.Drawing.Point(278, 41);
            this.tbTuoiThuCung.Name = "tbTuoiThuCung";
            this.tbTuoiThuCung.Size = new System.Drawing.Size(54, 20);
            this.tbTuoiThuCung.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tuổi:";
            // 
            // tbLoaiThuCung
            // 
            this.tbLoaiThuCung.Location = new System.Drawing.Point(78, 41);
            this.tbLoaiThuCung.Name = "tbLoaiThuCung";
            this.tbLoaiThuCung.Size = new System.Drawing.Size(106, 20);
            this.tbLoaiThuCung.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Loại: ";
            // 
            // tbIDThuCung
            // 
            this.tbIDThuCung.Location = new System.Drawing.Point(78, 4);
            this.tbIDThuCung.Name = "tbIDThuCung";
            this.tbIDThuCung.Size = new System.Drawing.Size(78, 20);
            this.tbIDThuCung.TabIndex = 1;
            // 
            // labMaDoUong
            // 
            this.labMaDoUong.AutoSize = true;
            this.labMaDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaDoUong.Location = new System.Drawing.Point(29, 7);
            this.labMaDoUong.Name = "labMaDoUong";
            this.labMaDoUong.Size = new System.Drawing.Size(28, 17);
            this.labMaDoUong.TabIndex = 0;
            this.labMaDoUong.Text = "ID:";
            // 
            // tbTimThuCung
            // 
            this.tbTimThuCung.Location = new System.Drawing.Point(149, 33);
            this.tbTimThuCung.Name = "tbTimThuCung";
            this.tbTimThuCung.Size = new System.Drawing.Size(125, 20);
            this.tbTimThuCung.TabIndex = 8;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(296, 26);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(89, 30);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvThuCung
            // 
            this.dgvThuCung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuCung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuCung.Location = new System.Drawing.Point(19, 19);
            this.dgvThuCung.Name = "dgvThuCung";
            this.dgvThuCung.Size = new System.Drawing.Size(524, 560);
            this.dgvThuCung.TabIndex = 0;
            this.dgvThuCung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuCung_CellClick);
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Location = new System.Drawing.Point(4, 22);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhachHang.Size = new System.Drawing.Size(961, 595);
            this.tabKhachHang.TabIndex = 2;
            this.tabKhachHang.Text = "Khách Hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(961, 595);
            this.tabNhanVien.TabIndex = 3;
            this.tabNhanVien.Text = "Nhân Viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(961, 595);
            this.tabAdmin.TabIndex = 4;
            this.tabAdmin.Text = "Admin";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSuaThuCung
            // 
            this.btnSuaThuCung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThuCung.Location = new System.Drawing.Point(112, 9);
            this.btnSuaThuCung.Name = "btnSuaThuCung";
            this.btnSuaThuCung.Size = new System.Drawing.Size(89, 30);
            this.btnSuaThuCung.TabIndex = 21;
            this.btnSuaThuCung.Text = "Sửa";
            this.btnSuaThuCung.UseVisualStyleBackColor = true;
            this.btnSuaThuCung.Click += new System.EventHandler(this.btnSuaThuCung_Click);
            // 
            // panelLuuHuy
            // 
            this.panelLuuHuy.Controls.Add(this.btnLuuThuCung);
            this.panelLuuHuy.Controls.Add(this.btnHuyThuCung);
            this.panelLuuHuy.Location = new System.Drawing.Point(178, 69);
            this.panelLuuHuy.Name = "panelLuuHuy";
            this.panelLuuHuy.Size = new System.Drawing.Size(207, 49);
            this.panelLuuHuy.TabIndex = 22;
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGioitinh.Location = new System.Drawing.Point(104, 168);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(67, 21);
            this.cbGioitinh.TabIndex = 4;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 636);
            this.Controls.Add(this.tabctrlMain);
            this.Name = "QuanLy";
            this.Text = "QuanLy";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.tabctrlMain.ResumeLayout(false);
            this.tabThuCung.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlDataBind.ResumeLayout(false);
            this.pnlDataBind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).EndInit();
            this.panelLuuHuy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrlMain;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabThuCung;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvThuCung;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.Panel pnlDataBind;
        private System.Windows.Forms.TextBox tbIDThuCung;
        private System.Windows.Forms.Label labMaDoUong;
        private System.Windows.Forms.TextBox tbTimThuCung;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox tbNccThuCung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTuoiThuCung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCanNangThuCung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGiaNhapThuCung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLoaiThuCung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoaThuCung;
        private System.Windows.Forms.Button btnThemThuCung;
        private System.Windows.Forms.Button btnLuuThuCung;
        private System.Windows.Forms.Button btnHuyThuCung;
        private System.Windows.Forms.ComboBox cbbTimThuCung;
        private System.Windows.Forms.Button btnSuaThuCung;
        private System.Windows.Forms.Panel panelLuuHuy;
        private System.Windows.Forms.ComboBox cbGioitinh;
    }
}