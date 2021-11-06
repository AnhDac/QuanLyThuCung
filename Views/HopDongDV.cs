using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuCung.Model;
namespace QLThuCung.Views
{
    public partial class HopDongDV : Form
    {
        ThuCungEntities db = new ThuCungEntities();
        public HopDongDV()
        {
            InitializeComponent();
        }

        private void HopDongDV_Load(object sender, EventArgs e)
        {

            LoadHopDongDV();
 
        }
        void LoadHopDongDV()
        {
            var result = db.view_Contract_ser.ToList();
            dgvHD.DataSource = result;
        }
        void LoadDichVu ()
        {
            var result = db.view_Servic.ToList();

        }
        void LoadChiTietHD ()
        {
            var result = db.view_DetailContractser.ToList();
            dgvChiTietHD.DataSource = result;
        }
        void binDichVu ()
        {

        }    
        void binHopDongDV()
        {
            txtHD_IDConser.Text = dgvHD.CurrentRow.Cells[0].Value.ToString();
            txtHD_IDEmp.Text = dgvHD.CurrentRow.Cells[1].Value.ToString();
            txtHD_IDCus.Text = dgvHD.CurrentRow.Cells[2].Value.ToString();
            txtHD_DateBuy.Text = dgvHD.CurrentRow.Cells[3].Value.ToString();
            txtHD_Price.Text = dgvHD.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binHopDongDV();
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        { 
                try
                {
                
                string idpet = dgvHD.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim();
                Contract_Ser contract = db.Contract_Ser.Find(idpet);
                contract.ID_ConSer = txtHD_IDConser.Text.ToString().Trim();
                contract.ID_Emp = txtHD_IDEmp.Text.ToString().Trim();
                contract.ID_Cus = txtHD_IDCus.Text.ToString().Trim();
                contract.DateBuy = Convert.ToDateTime(txtHD_DateBuy.Text);
                contract.Price = Convert.ToInt32(txtHD_Price.Text);
                    db.SaveChanges();

                    MessageBox.Show("Thêm Thành Công!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHopDongDV();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi Không Thêm Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db = new ThuCungEntities();
                    LoadHopDongDV();
                }
            
        }

        private void btnHD_Reload_Click(object sender, EventArgs e)
        {
            LoadHopDongDV();
        }

        private void bthHD_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                Contract_Ser contract = new Contract_Ser();

                contract.ID_ConSer = txtHD_IDConser.Text.ToString().Trim();
                contract.ID_Emp = txtHD_IDEmp.Text.ToString().Trim();
                contract.ID_Cus = txtHD_IDCus.Text.ToString().Trim();
                contract.DateBuy = Convert.ToDateTime(txtHD_DateBuy.Text);
                contract.Price = Convert.ToInt32(txtHD_Price.Text);


                db.Contract_Ser.Add(contract);
                db.SaveChanges();

                MessageBox.Show("Thêm Thành Công!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHopDongDV();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thêm Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadHopDongDV();
            }
        }
    }
}
