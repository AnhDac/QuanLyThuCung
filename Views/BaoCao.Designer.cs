
namespace QLThuCung.Views
{
    partial class BaoCao
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabBCContractSelll = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoGiaoDichContractSell = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProfitContractSell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotalMoneyTransContractSell = new System.Windows.Forms.TextBox();
            this.btnShowContractSell = new System.Windows.Forms.Button();
            this.cbNamBCContractSell = new System.Windows.Forms.ComboBox();
            this.cbThangBCContractSell = new System.Windows.Forms.ComboBox();
            this.dgvContractSell = new System.Windows.Forms.DataGridView();
            this.tabContractSer = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSoGiaoDichContractSer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotalMoneyContractSer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbNamContractSer = new System.Windows.Forms.ComboBox();
            this.cbThangContractSer = new System.Windows.Forms.ComboBox();
            this.dgvContractSer = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabBCContractSelll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractSell)).BeginInit();
            this.tabContractSer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractSer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabBCContractSelll);
            this.tabMain.Controls.Add(this.tabContractSer);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(776, 426);
            this.tabMain.TabIndex = 0;
            this.tabMain.Click += new System.EventHandler(this.tabMain_Click);
            // 
            // tabBCContractSelll
            // 
            this.tabBCContractSelll.Controls.Add(this.label7);
            this.tabBCContractSelll.Controls.Add(this.label3);
            this.tabBCContractSelll.Controls.Add(this.tbSoGiaoDichContractSell);
            this.tabBCContractSelll.Controls.Add(this.label2);
            this.tabBCContractSelll.Controls.Add(this.tbProfitContractSell);
            this.tabBCContractSelll.Controls.Add(this.label1);
            this.tabBCContractSelll.Controls.Add(this.tbTotalMoneyTransContractSell);
            this.tabBCContractSelll.Controls.Add(this.btnShowContractSell);
            this.tabBCContractSelll.Controls.Add(this.cbNamBCContractSell);
            this.tabBCContractSelll.Controls.Add(this.cbThangBCContractSell);
            this.tabBCContractSelll.Controls.Add(this.dgvContractSell);
            this.tabBCContractSelll.Location = new System.Drawing.Point(4, 22);
            this.tabBCContractSelll.Name = "tabBCContractSelll";
            this.tabBCContractSelll.Padding = new System.Windows.Forms.Padding(3);
            this.tabBCContractSelll.Size = new System.Drawing.Size(768, 400);
            this.tabBCContractSelll.TabIndex = 0;
            this.tabBCContractSelll.Text = "Bán Thú Cưng";
            this.tabBCContractSelll.UseVisualStyleBackColor = true;
            this.tabBCContractSelll.Click += new System.EventHandler(this.tabBCContractSelll_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số Giao Dịch:";
            // 
            // tbSoGiaoDichContractSell
            // 
            this.tbSoGiaoDichContractSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoGiaoDichContractSell.Location = new System.Drawing.Point(639, 134);
            this.tbSoGiaoDichContractSell.Name = "tbSoGiaoDichContractSell";
            this.tbSoGiaoDichContractSell.Size = new System.Drawing.Size(100, 26);
            this.tbSoGiaoDichContractSell.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lợi Nhuận:";
            // 
            // tbProfitContractSell
            // 
            this.tbProfitContractSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfitContractSell.Location = new System.Drawing.Point(639, 289);
            this.tbProfitContractSell.Name = "tbProfitContractSell";
            this.tbProfitContractSell.Size = new System.Drawing.Size(100, 26);
            this.tbProfitContractSell.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tổng Giá Trị Giao Dịch:";
            // 
            // tbTotalMoneyTransContractSell
            // 
            this.tbTotalMoneyTransContractSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalMoneyTransContractSell.Location = new System.Drawing.Point(639, 226);
            this.tbTotalMoneyTransContractSell.Name = "tbTotalMoneyTransContractSell";
            this.tbTotalMoneyTransContractSell.Size = new System.Drawing.Size(100, 26);
            this.tbTotalMoneyTransContractSell.TabIndex = 8;
            // 
            // btnShowContractSell
            // 
            this.btnShowContractSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowContractSell.Location = new System.Drawing.Point(562, 342);
            this.btnShowContractSell.Name = "btnShowContractSell";
            this.btnShowContractSell.Size = new System.Drawing.Size(95, 35);
            this.btnShowContractSell.TabIndex = 7;
            this.btnShowContractSell.Text = "Show";
            this.btnShowContractSell.UseVisualStyleBackColor = true;
            this.btnShowContractSell.Click += new System.EventHandler(this.btnShowContractSell_Click);
            // 
            // cbNamBCContractSell
            // 
            this.cbNamBCContractSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamBCContractSell.FormattingEnabled = true;
            this.cbNamBCContractSell.Location = new System.Drawing.Point(669, 58);
            this.cbNamBCContractSell.Name = "cbNamBCContractSell";
            this.cbNamBCContractSell.Size = new System.Drawing.Size(89, 28);
            this.cbNamBCContractSell.TabIndex = 6;
            // 
            // cbThangBCContractSell
            // 
            this.cbThangBCContractSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThangBCContractSell.FormattingEnabled = true;
            this.cbThangBCContractSell.Location = new System.Drawing.Point(577, 58);
            this.cbThangBCContractSell.Name = "cbThangBCContractSell";
            this.cbThangBCContractSell.Size = new System.Drawing.Size(68, 28);
            this.cbThangBCContractSell.TabIndex = 5;
            // 
            // dgvContractSell
            // 
            this.dgvContractSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractSell.Location = new System.Drawing.Point(18, 25);
            this.dgvContractSell.Name = "dgvContractSell";
            this.dgvContractSell.Size = new System.Drawing.Size(471, 316);
            this.dgvContractSell.TabIndex = 0;
            // 
            // tabContractSer
            // 
            this.tabContractSer.Controls.Add(this.label5);
            this.tabContractSer.Controls.Add(this.label4);
            this.tabContractSer.Controls.Add(this.tbSoGiaoDichContractSer);
            this.tabContractSer.Controls.Add(this.label6);
            this.tabContractSer.Controls.Add(this.tbTotalMoneyContractSer);
            this.tabContractSer.Controls.Add(this.button1);
            this.tabContractSer.Controls.Add(this.cbNamContractSer);
            this.tabContractSer.Controls.Add(this.cbThangContractSer);
            this.tabContractSer.Controls.Add(this.dgvContractSer);
            this.tabContractSer.Location = new System.Drawing.Point(4, 22);
            this.tabContractSer.Name = "tabContractSer";
            this.tabContractSer.Padding = new System.Windows.Forms.Padding(3);
            this.tabContractSer.Size = new System.Drawing.Size(768, 400);
            this.tabContractSer.TabIndex = 1;
            this.tabContractSer.Text = "Dịch vụ chăm sóc";
            this.tabContractSer.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(508, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Chọn Tháng:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Số Giao Dịch:";
            // 
            // tbSoGiaoDichContractSer
            // 
            this.tbSoGiaoDichContractSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoGiaoDichContractSer.Location = new System.Drawing.Point(627, 160);
            this.tbSoGiaoDichContractSer.Name = "tbSoGiaoDichContractSer";
            this.tbSoGiaoDichContractSer.Size = new System.Drawing.Size(100, 26);
            this.tbSoGiaoDichContractSer.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(508, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tổng Giá Trị Giao Dịch:";
            // 
            // tbTotalMoneyContractSer
            // 
            this.tbTotalMoneyContractSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalMoneyContractSer.Location = new System.Drawing.Point(627, 261);
            this.tbTotalMoneyContractSer.Name = "tbTotalMoneyContractSer";
            this.tbTotalMoneyContractSer.Size = new System.Drawing.Size(100, 26);
            this.tbTotalMoneyContractSer.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(561, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbNamContractSer
            // 
            this.cbNamContractSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamContractSer.FormattingEnabled = true;
            this.cbNamContractSer.Location = new System.Drawing.Point(653, 75);
            this.cbNamContractSer.Name = "cbNamContractSer";
            this.cbNamContractSer.Size = new System.Drawing.Size(89, 28);
            this.cbNamContractSer.TabIndex = 16;
            // 
            // cbThangContractSer
            // 
            this.cbThangContractSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThangContractSer.FormattingEnabled = true;
            this.cbThangContractSer.Location = new System.Drawing.Point(561, 75);
            this.cbThangContractSer.Name = "cbThangContractSer";
            this.cbThangContractSer.Size = new System.Drawing.Size(68, 28);
            this.cbThangContractSer.TabIndex = 15;
            // 
            // dgvContractSer
            // 
            this.dgvContractSer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContractSer.Location = new System.Drawing.Point(27, 32);
            this.dgvContractSer.Name = "dgvContractSer";
            this.dgvContractSer.Size = new System.Drawing.Size(471, 316);
            this.dgvContractSer.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(520, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Chọn Tháng:";
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaoCao";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            this.tabMain.ResumeLayout(false);
            this.tabBCContractSelll.ResumeLayout(false);
            this.tabBCContractSelll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractSell)).EndInit();
            this.tabContractSer.ResumeLayout(false);
            this.tabContractSer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContractSer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabBCContractSelll;
        private System.Windows.Forms.TabPage tabContractSer;
        private System.Windows.Forms.DataGridView dgvContractSell;
        private System.Windows.Forms.ComboBox cbNamBCContractSell;
        private System.Windows.Forms.ComboBox cbThangBCContractSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoGiaoDichContractSell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProfitContractSell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTotalMoneyTransContractSell;
        private System.Windows.Forms.Button btnShowContractSell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSoGiaoDichContractSer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTotalMoneyContractSer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbNamContractSer;
        private System.Windows.Forms.ComboBox cbThangContractSer;
        private System.Windows.Forms.DataGridView dgvContractSer;
        private System.Windows.Forms.Label label7;
    }
}