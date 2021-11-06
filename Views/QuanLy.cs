using QLThuCung.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuCung.Views
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }
        ThuCungEntities db = new ThuCungEntities();
        private void QuanLy_Load(object sender, EventArgs e)
        {
            panelLuuHuy.Hide();
        }

        void ClearTextBox()
        {
            foreach (Control c in pnlDataBind.Controls)
            {
                if (c is TextBox)
                {
                    TextBox questionTextBox = c as TextBox;
                    if (questionTextBox != null)
                    {
                        questionTextBox.Text = "";
                    }
                }
            }

        }
       


        private void tabctrlMain_Click(object sender, EventArgs e)
        {
           if (tabctrlMain.SelectedTab == tabThuCung)
            {
                LoadThuCung();
                tabctrlMain.TabPages.Remove(tabAdmin);
                tabctrlMain.TabPages.Add(tabAdmin);
            }
            else if (tabctrlMain.SelectedTab == tabNhanVien)
            {
                //db.usp_MuaDichVu("C101", "E001", "C001", DateTime.Today, 190000, "", "", "S003", "");
            }
            else if (tabctrlMain.SelectedTab == tabKhachHang)
            {
                //var result = from c in db.Customers select new { IDCus = c.ID_Cus, Name = c.Name, Phone = c.Phone };
               // dgvThuCung.DataSource = result.ToList();
            }
        }

        
        //======================Start THU CUNG============================
        void DataBindThuCung()
        {

            tbIDThuCung.Text = dgvThuCung.CurrentRow.Cells[0].Value.ToString();
            tbLoaiThuCung.Text = dgvThuCung.CurrentRow.Cells[1].Value.ToString();
            //cbLoaiThuCung.SelectedIndex = cbLoaiThuCung.FindStringExact("");
            cbbTimThuCung.SelectedItem = "Loại";
            cbGioitinh.SelectedItem = dgvThuCung.CurrentRow.Cells[2].Value.ToString(); 
            tbGiaNhapThuCung.Text = dgvThuCung.CurrentRow.Cells[3].Value.ToString();
            tbNccThuCung.Text = dgvThuCung.CurrentRow.Cells[4].Value.ToString();
            tbCanNangThuCung.Text = dgvThuCung.CurrentRow.Cells[5].Value.ToString();
            tbTuoiThuCung.Text = dgvThuCung.CurrentRow.Cells[6].Value.ToString();
        }

        void LoadThuCung()
        {
            var result = from c in db.Pets select new { IDPet = c.ID_Pet, Loai = c.ID_Spec, GioiTinh = c.Sex, PriceImport = c.PriceImport, NCC = c.ID_Sup, CanNang = c.Weight, Tuoi = c.Age };
            dgvThuCung.DataSource = result.ToList();

            //using (ThụCungEntities spec = new ThụCungEntities())
            //{ 
            //    cbLoaiThuCung.DataSource = spec.Species.ToList();
            //    cbLoaiThuCung.ValueMember = "ID_Spec";
            //    cbLoaiThuCung.DisplayMember = "Name";
            //}
            DataBindThuCung();
        }

        private void dgvThuCung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBindThuCung();
        }

        private void btnThemThuCung_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            btnSuaThuCung.Enabled = false;
            btnXoaThuCung.Enabled = false;
            panelLuuHuy.Show();
        }

        private void btnLuuThuCung_Click(object sender, EventArgs e)
        {
            try
            {
                Pet pet = new Pet();
   
                pet.ID_Pet = tbIDThuCung.Text.ToString().Trim();
                pet.ID_Spec = tbLoaiThuCung.Text.ToString().Trim();
                pet.Sex = cbGioitinh.Text.ToString().Trim();
                pet.PriceImport = Convert.ToInt32(tbGiaNhapThuCung.Text);
                pet.ID_Sup = tbNccThuCung.Text.ToString().Trim();
                pet.Weight = Convert.ToDouble(tbCanNangThuCung.Text);
                pet.Age = Convert.ToInt32(tbTuoiThuCung.Text);

                db.Pets.Add(pet);
                db.SaveChanges();

                MessageBox.Show("Thêm Thành Công!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThuCung();
                panelLuuHuy.Hide();
                btnSuaThuCung.Enabled = true;
                btnXoaThuCung.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thêm Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadThuCung();
            }
        }

        private void btnHuyThuCung_Click(object sender, EventArgs e)
        {
            LoadThuCung();
            panelLuuHuy.Hide();
            btnSuaThuCung.Enabled = true;
            btnXoaThuCung.Enabled = true;
        }

        private void btnSuaThuCung_Click(object sender, EventArgs e)
        {

            try
            {
                string idpet = dgvThuCung.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim();
                Pet pet = db.Pets.Find(idpet);
                pet.ID_Spec = tbLoaiThuCung.Text.ToString().Trim();
                pet.Sex = cbGioitinh.Text.ToString().Trim();
                pet.PriceImport = Convert.ToInt32(tbGiaNhapThuCung.Text);
                pet.ID_Sup = tbNccThuCung.Text.ToString().Trim();
                pet.Weight = Convert.ToDouble(tbCanNangThuCung.Text);
                pet.Age = Convert.ToInt32(tbTuoiThuCung.Text);

                db.SaveChanges();
                MessageBox.Show("Update Successfull!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThuCung();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Update Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadThuCung();
            }
        }

        private void btnXoaThuCung_Click(object sender, EventArgs e)
        {
            try
            {
                Pet pet = db.Pets.Where(p => p.ID_Pet == tbIDThuCung.Text.ToString()).SingleOrDefault();
                db.Pets.Remove(pet);
                db.SaveChanges();
                MessageBox.Show("Delete Successfull!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThuCung();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Delete Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadThuCung();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            String loaitimkiem = cbbTimThuCung.Text.ToString();
            var ms = db.Pets.Where(p => p.ID_Spec == tbTimThuCung.Text.ToString()).Select(c => new { IDPet = c.ID_Pet, Loai = c.ID_Spec, GioiTinh = c.Sex, PriceImport = c.PriceImport, NCC = c.ID_Sup, CanNang = c.Weight, Tuoi = c.Age }).ToList();
            switch (loaitimkiem)
            {
                case "Giới Tính":
                    ms = db.Pets.Where(p => p.Sex == tbTimThuCung.Text.ToString()).Select(c => new { IDPet = c.ID_Pet, Loai = c.ID_Spec, GioiTinh = c.Sex, PriceImport = c.PriceImport, NCC = c.ID_Sup, CanNang = c.Weight, Tuoi = c.Age }).ToList();
                    break;
                case "Tuổi":
                    int age = Convert.ToInt32(tbTimThuCung.Text.ToString());
                    ms = db.Pets.Where(p => p.Age == age).Select(c => new { IDPet = c.ID_Pet, Loai = c.ID_Spec, GioiTinh = c.Sex, PriceImport = c.PriceImport, NCC = c.ID_Sup, CanNang = c.Weight, Tuoi = c.Age }).ToList();
                    break;
            }
            dgvThuCung.DataSource = ms;
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            
        }
        //======================End THU CUNG============================
    }
}
