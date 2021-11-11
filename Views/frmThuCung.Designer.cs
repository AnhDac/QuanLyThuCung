
namespace QLThuCung
{
    partial class frmThuCung
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
            this.dgvListThuCung = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListThuCung)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListThuCung
            // 
            this.dgvListThuCung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListThuCung.Location = new System.Drawing.Point(12, 12);
            this.dgvListThuCung.Name = "dgvListThuCung";
            this.dgvListThuCung.RowHeadersWidth = 51;
            this.dgvListThuCung.RowTemplate.Height = 24;
            this.dgvListThuCung.Size = new System.Drawing.Size(776, 426);
            this.dgvListThuCung.TabIndex = 0;
            // 
            // frmThuCung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListThuCung);
            this.Name = "frmThuCung";
            this.Text = "frmThuCung";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListThuCung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListThuCung;
    }
}