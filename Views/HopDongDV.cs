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
            var result = from kq in db.Contract_Ser select new { IDConser = kq.ID_ConSer, IDEmp = kq.ID_Emp, IDCus = kq.ID_Cus, DateBuy = kq.DateBuy, Price = kq.Price };
            var empl = db.Employees.ToList();
            cbDV.DataSource = empl;
            cbDV.DisplayMember = "ID_Emp";
            cbDV.ValueMember = "ID_Emp";
            cbHD.DataSource = result.ToList();
            cbHD.DisplayMember = "ID_ConSer";
            cbHD.ValueMember = "IDConser";
            dgvHD.DataSource = result.ToList();
            txtHD_SoLuong.Text = dgvHD.Rows.Count.ToString();
        }
        void binHopDongDV()
        {
            txtHD_IDConser.Text = dgvHD.CurrentRow.Cells[0].Value.ToString().Trim();
            txtHD_IDEmp.Text = dgvHD.CurrentRow.Cells[1].Value.ToString().Trim();
            txtHD_IDCus.Text = dgvHD.CurrentRow.Cells[2].Value.ToString().Trim();
            txtHD_DateBuy.Text = dgvHD.CurrentRow.Cells[3].Value.ToString().Trim();
            txtHD_Price.Text = dgvHD.CurrentRow.Cells[4].Value.ToString().Trim();
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binHopDongDV();
        }
        
        private void btnLuuHD_Click(object sender, EventArgs e)
        { 
               try
                {
                if (MessageBox.Show("Do you want update this pet?", "Delete Pet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string id = dgvHD.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim();
                    Contract_Ser contract = db.Contract_Ser.Find(id);
                    contract.ID_Emp = txtHD_IDEmp.Text.ToString().Trim();
                    contract.ID_Cus = txtHD_IDCus.Text.ToString().Trim();
                    contract.DateBuy = Convert.ToDateTime(txtHD_DateBuy.Text);
                    contract.Price = Convert.ToInt32(txtHD_Price.Text);
                    db.SaveChanges();

                    MessageBox.Show("update Thành Công!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHopDongDV();
                }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi không update được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (MessageBox.Show("Do you want insert this pet?", "Delete Pet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thêm Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadHopDongDV();
            }
        }

        private void btnHD_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want delete this pet?", "Delete Pet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Contract_Ser Contrac = db.Contract_Ser.Where(p => p.ID_ConSer == txtHD_IDConser.Text.ToString().Trim()).SingleOrDefault();
                    db.Contract_Ser.Remove(Contrac);
                    db.SaveChanges();
                    MessageBox.Show("Delete Successfull!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHopDongDV();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Delete Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadHopDongDV();
            }
        }

        private void bthHD_TimKiem_Click(object sender, EventArgs e)
        {
            String tam = cbDV.Text.ToString().Trim();
            var kq = db.view_Contract(tam);
            dgvHD.DataSource = kq.ToList();
            txtHD_SoLuong.Text = dgvHD.Rows.Count.ToString();
        }

        private void bthHD_chiTiet_Click(object sender, EventArgs e)
        {
            String tam = cbHD.Text.ToString().Trim();
            var kq = db.view_DetaiContracser(tam);
            dgvChiTietHD.DataSource = kq.ToList();
        }
    }
}
