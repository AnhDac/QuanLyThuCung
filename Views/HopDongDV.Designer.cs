﻿
namespace QLThuCung.Views
{
    partial class HopDongDV
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.txtHD_IDConser = new System.Windows.Forms.TextBox();
            this.txtHD_IDEmp = new System.Windows.Forms.TextBox();
            this.txtHD_IDCus = new System.Windows.Forms.TextBox();
            this.txtHD_DateBuy = new System.Windows.Forms.TextBox();
            this.txtHD_Price = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cbHD = new System.Windows.Forms.ComboBox();
            this.bthHD_Insert = new System.Windows.Forms.Button();
            this.btnHD_xoa = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnHD_Reload = new System.Windows.Forms.Button();
            this.bthHD_TimKiem = new System.Windows.Forms.Button();
            this.txtHD_SoLuong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bthHD_chiTiet = new System.Windows.Forms.Button();
            this.dgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.bthHD_Thoat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1019, 591);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1011, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dịch vụ chăm sóc";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bthHD_Thoat);
            this.tabPage2.Controls.Add(this.bthHD_chiTiet);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.txtHD_SoLuong);
            this.tabPage2.Controls.Add(this.bthHD_TimKiem);
            this.tabPage2.Controls.Add(this.btnHD_Reload);
            this.tabPage2.Controls.Add(this.btnLuuHD);
            this.tabPage2.Controls.Add(this.btnHD_xoa);
            this.tabPage2.Controls.Add(this.bthHD_Insert);
            this.tabPage2.Controls.Add(this.cbHD);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.txtHD_Price);
            this.tabPage2.Controls.Add(this.txtHD_DateBuy);
            this.tabPage2.Controls.Add(this.txtHD_IDCus);
            this.tabPage2.Controls.Add(this.txtHD_IDEmp);
            this.tabPage2.Controls.Add(this.txtHD_IDConser);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1011, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hợp đồng thú cưng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvHD
            // 
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(14, 40);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowHeadersWidth = 51;
            this.dgvHD.RowTemplate.Height = 24;
            this.dgvHD.Size = new System.Drawing.Size(579, 217);
            this.dgvHD.TabIndex = 0;
            this.dgvHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellClick);
            // 
            // txtHD_IDConser
            // 
            this.txtHD_IDConser.Location = new System.Drawing.Point(663, 105);
            this.txtHD_IDConser.Name = "txtHD_IDConser";
            this.txtHD_IDConser.Size = new System.Drawing.Size(131, 22);
            this.txtHD_IDConser.TabIndex = 1;
            // 
            // txtHD_IDEmp
            // 
            this.txtHD_IDEmp.Location = new System.Drawing.Point(663, 152);
            this.txtHD_IDEmp.Name = "txtHD_IDEmp";
            this.txtHD_IDEmp.Size = new System.Drawing.Size(131, 22);
            this.txtHD_IDEmp.TabIndex = 2;
            // 
            // txtHD_IDCus
            // 
            this.txtHD_IDCus.Location = new System.Drawing.Point(663, 198);
            this.txtHD_IDCus.Name = "txtHD_IDCus";
            this.txtHD_IDCus.Size = new System.Drawing.Size(131, 22);
            this.txtHD_IDCus.TabIndex = 3;
            // 
            // txtHD_DateBuy
            // 
            this.txtHD_DateBuy.Location = new System.Drawing.Point(663, 243);
            this.txtHD_DateBuy.Name = "txtHD_DateBuy";
            this.txtHD_DateBuy.Size = new System.Drawing.Size(131, 22);
            this.txtHD_DateBuy.TabIndex = 4;
            // 
            // txtHD_Price
            // 
            this.txtHD_Price.Location = new System.Drawing.Point(663, 284);
            this.txtHD_Price.Name = "txtHD_Price";
            this.txtHD_Price.Size = new System.Drawing.Size(131, 22);
            this.txtHD_Price.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(892, 379);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 6;
            // 
            // cbHD
            // 
            this.cbHD.FormattingEnabled = true;
            this.cbHD.Location = new System.Drawing.Point(652, 45);
            this.cbHD.Name = "cbHD";
            this.cbHD.Size = new System.Drawing.Size(121, 24);
            this.cbHD.TabIndex = 7;
            // 
            // bthHD_Insert
            // 
            this.bthHD_Insert.Location = new System.Drawing.Point(677, 482);
            this.bthHD_Insert.Name = "bthHD_Insert";
            this.bthHD_Insert.Size = new System.Drawing.Size(75, 23);
            this.bthHD_Insert.TabIndex = 8;
            this.bthHD_Insert.Text = "Thêm";
            this.bthHD_Insert.UseVisualStyleBackColor = true;
            this.bthHD_Insert.Click += new System.EventHandler(this.bthHD_Insert_Click);
            // 
            // btnHD_xoa
            // 
            this.btnHD_xoa.Location = new System.Drawing.Point(708, 391);
            this.btnHD_xoa.Name = "btnHD_xoa";
            this.btnHD_xoa.Size = new System.Drawing.Size(75, 23);
            this.btnHD_xoa.TabIndex = 10;
            this.btnHD_xoa.Text = "xóa";
            this.btnHD_xoa.UseVisualStyleBackColor = true;
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Location = new System.Drawing.Point(771, 439);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(75, 23);
            this.btnLuuHD.TabIndex = 11;
            this.btnLuuHD.Text = "Lưu";
            this.btnLuuHD.UseVisualStyleBackColor = true;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // btnHD_Reload
            // 
            this.btnHD_Reload.Location = new System.Drawing.Point(882, 466);
            this.btnHD_Reload.Name = "btnHD_Reload";
            this.btnHD_Reload.Size = new System.Drawing.Size(75, 23);
            this.btnHD_Reload.TabIndex = 12;
            this.btnHD_Reload.Text = "ReLoad";
            this.btnHD_Reload.UseVisualStyleBackColor = true;
            this.btnHD_Reload.Click += new System.EventHandler(this.btnHD_Reload_Click);
            // 
            // bthHD_TimKiem
            // 
            this.bthHD_TimKiem.Location = new System.Drawing.Point(790, 36);
            this.bthHD_TimKiem.Name = "bthHD_TimKiem";
            this.bthHD_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.bthHD_TimKiem.TabIndex = 13;
            this.bthHD_TimKiem.Text = "Tìm kiếm";
            this.bthHD_TimKiem.UseVisualStyleBackColor = true;
            // 
            // txtHD_SoLuong
            // 
            this.txtHD_SoLuong.Location = new System.Drawing.Point(892, 94);
            this.txtHD_SoLuong.Name = "txtHD_SoLuong";
            this.txtHD_SoLuong.Size = new System.Drawing.Size(100, 22);
            this.txtHD_SoLuong.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHD);
            this.groupBox1.Location = new System.Drawing.Point(5, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 303);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hợp đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(814, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tổng số ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvChiTietHD);
            this.groupBox2.Location = new System.Drawing.Point(19, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 156);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hợp hồng tìm kiếm";
            // 
            // bthHD_chiTiet
            // 
            this.bthHD_chiTiet.Location = new System.Drawing.Point(688, 328);
            this.bthHD_chiTiet.Name = "bthHD_chiTiet";
            this.bthHD_chiTiet.Size = new System.Drawing.Size(75, 23);
            this.bthHD_chiTiet.TabIndex = 18;
            this.bthHD_chiTiet.Text = "Chi tiết";
            this.bthHD_chiTiet.UseVisualStyleBackColor = true;
            // 
            // dgvChiTietHD
            // 
            this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHD.Location = new System.Drawing.Point(6, 30);
            this.dgvChiTietHD.Name = "dgvChiTietHD";
            this.dgvChiTietHD.RowHeadersWidth = 51;
            this.dgvChiTietHD.RowTemplate.Height = 24;
            this.dgvChiTietHD.Size = new System.Drawing.Size(587, 110);
            this.dgvChiTietHD.TabIndex = 0;
            // 
            // bthHD_Thoat
            // 
            this.bthHD_Thoat.Location = new System.Drawing.Point(817, 509);
            this.bthHD_Thoat.Name = "bthHD_Thoat";
            this.bthHD_Thoat.Size = new System.Drawing.Size(75, 23);
            this.bthHD_Thoat.TabIndex = 19;
            this.bthHD_Thoat.Text = "Thoát";
            this.bthHD_Thoat.UseVisualStyleBackColor = true;
            // 
            // HopDongDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 615);
            this.Controls.Add(this.tabControl1);
            this.Name = "HopDongDV";
            this.Text = "HopDongDV";
            this.Load += new System.EventHandler(this.HopDongDV_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bthHD_Thoat;
        private System.Windows.Forms.Button bthHD_chiTiet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvChiTietHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.TextBox txtHD_SoLuong;
        private System.Windows.Forms.Button bthHD_TimKiem;
        private System.Windows.Forms.Button btnHD_Reload;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Button btnHD_xoa;
        private System.Windows.Forms.Button bthHD_Insert;
        private System.Windows.Forms.ComboBox cbHD;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtHD_Price;
        private System.Windows.Forms.TextBox txtHD_DateBuy;
        private System.Windows.Forms.TextBox txtHD_IDCus;
        private System.Windows.Forms.TextBox txtHD_IDEmp;
        private System.Windows.Forms.TextBox txtHD_IDConser;
    }
}