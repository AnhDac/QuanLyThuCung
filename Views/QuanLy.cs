﻿using QLThuCung.Model;
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
        private String iduser;

        ThuCungEntities db = new ThuCungEntities();

        public QuanLy()
        {
            InitializeComponent();
            iduser = "";//default guest
        }

        public QuanLy(String iduser)
        {
            InitializeComponent();
            this.iduser = iduser;//default guest
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            panelLuuHuy.Hide();
            panelLuuHuyKH.Hide();
            panelLuuHuyNV.Hide();
            pnlLuuHuyUser.Hide();
            pnlLuuHuyProfile.Hide();
            pnlChiTietThuCung.Hide();
            PhanQuyenUser();
            LoadHome();
        }
        void PhanQuyenUser()
        {
            
            string permiss = "";
            var result = db.Users.Where(p => p.ID == iduser).Select(c => new { IDUser = c.ID, Ten = c.Name, Username = c.Username, Password = c.PassWord, Permission = c.Permission }).ToList().SingleOrDefault();
            if (result != null)
                permiss = result.Permission.ToString().Trim();
            switch (permiss)
            {
                case ""://guest
                    tabctrlMain.TabPages.Remove(tabThuCung);
                    tabctrlMain.TabPages.Remove(tabKhachHang);
                    tabctrlMain.TabPages.Remove(tabNhanVien);
                    tabctrlMain.TabPages.Remove(tabUser);
                    tabctrlMain.TabPages.Remove(tabProfile);
                    break;
                case "customer":
                    tabctrlMain.TabPages.Remove(tabThuCung);
                    tabctrlMain.TabPages.Remove(tabKhachHang);
                    tabctrlMain.TabPages.Remove(tabNhanVien);
                    tabctrlMain.TabPages.Remove(tabUser);
                    break;
                case "employee":
                    tabctrlMain.TabPages.Remove(tabNhanVien);
                    tabctrlMain.TabPages.Remove(tabUser);
                    break;
            }


        }

        void ClearTextBox()
        {
            if (pnlDataBind.Visible)
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
            else if (pnlDataBindKH.Visible)
            {
                foreach (Control c in pnlDataBindKH.Controls)
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
            else if (pnlDataBindNV.Visible)
            {
                foreach (Control c in pnlDataBindNV.Controls)
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
            else if (pnlDataBindUser.Visible)
            {
                foreach (Control c in pnlDataBindUser.Controls)
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

        }

        private void tabctrlMain_Click(object sender, EventArgs e)
        {
            if (tabctrlMain.SelectedTab == tabThuCung)
            {
                LoadThuCung();
                cbbTimThuCung.SelectedItem = "Loại";
                //tabctrlMain.TabPages.Remove(tabAdmin);
                //tabctrlMain.TabPages.Add(tabAdmin);
            }
            else if (tabctrlMain.SelectedTab == tabNhanVien)
            {
                LoadNhanVien();
                cbbTimNhanVien.SelectedItem = "Tên";

                //db.usp_MuaDichVu("C101", "E001", "C001", DateTime.Today, 190000, "", "", "S003", "");
            }
            else if (tabctrlMain.SelectedTab == tabKhachHang)
            {
                LoadKhachHang();
                cbTimKhachHang.SelectedItem = "Tên";

            }
            else if (tabctrlMain.SelectedTab == tabUser)
            {
                LoadUser();
                cbFindUser.SelectedItem = "Tên";
            }
            else if (tabctrlMain.SelectedTab == tabProfile)
            {
                getProfileUser();
                tbPerrmissProfle.ReadOnly = true;
                tbIDProfile.ReadOnly = true;
                tbTenProfile.ReadOnly = true;
                tbUsernameProfile.ReadOnly = true;
                tbPasswordProfile.ReadOnly = true;
            }
        }

        #region TAB THU CUNG
        //======================Start THU CUNG============================
        void DataBindThuCung()
        {

            tbIDThuCung.Text = dgvThuCung.CurrentRow.Cells[0].Value.ToString();
            tbLoaiThuCung.Text = dgvThuCung.CurrentRow.Cells[1].Value.ToString();
            //cbLoaiThuCung.SelectedIndex = cbLoaiThuCung.FindStringExact("");
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
                if (MessageBox.Show("Do you want delete this pet?", "Delete Pet", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Pet pet = db.Pets.Where(p => p.ID_Pet == tbIDThuCung.Text.ToString()).SingleOrDefault();
                    db.Pets.Remove(pet);
                    db.SaveChanges();
                    MessageBox.Show("Delete Successfull!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThuCung();
                }
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
            Boolean flag_error = false;
            var ms = db.Pets.Where(p => p.ID_Spec == tbTimThuCung.Text.ToString()).Select(c => new { IDPet = c.ID_Pet, Loai = c.ID_Spec, GioiTinh = c.Sex, PriceImport = c.PriceImport, NCC = c.ID_Sup, CanNang = c.Weight, Tuoi = c.Age }).ToList();
            switch (loaitimkiem)
            {
                case "Giới Tính":
                    ms = db.Pets.Where(p => p.Sex == tbTimThuCung.Text.ToString()).Select(c => new { IDPet = c.ID_Pet, Loai = c.ID_Spec, GioiTinh = c.Sex, PriceImport = c.PriceImport, NCC = c.ID_Sup, CanNang = c.Weight, Tuoi = c.Age }).ToList();
                    break;
                case "Tuổi":
                    try
                    {
                        int age = Convert.ToInt32(tbTimThuCung.Text.ToString());
                        ms = db.Pets.Where(p => p.Age == age).Select(c => new { IDPet = c.ID_Pet, Loai = c.ID_Spec, GioiTinh = c.Sex, PriceImport = c.PriceImport, NCC = c.ID_Sup, CanNang = c.Weight, Tuoi = c.Age }).ToList();
                        break;
                    }
                    catch (Exception)
                    {
                        flag_error = true;
                        break;
                    }
            }
            if (flag_error)
            {
                MessageBox.Show("Lỗi! Vui lòng kiểm tra dữ liệu nhập vào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var result = from c in db.Pets select new { IDPet = c.ID_Pet, Loai = c.ID_Spec, GioiTinh = c.Sex, PriceImport = c.PriceImport, NCC = c.ID_Sup, CanNang = c.Weight, Tuoi = c.Age };
                dgvThuCung.DataSource = result.ToList();
            }
            else
                dgvThuCung.DataSource = ms;
        }

        private void btnReloadTC_Click(object sender, EventArgs e)
        {
            LoadThuCung();
        }

        //======================End THU CUNG============================
        #endregion

        #region TAB KHACH HANG
        void DataBindKhachHang()
        {
            txtMaKhachHang.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKhachHang.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtSDTKhachHang.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtTuoiKhachHang.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
        }
        void LoadKhachHang()
        {
            var result = from c in db.Customers select new { IDCus = c.ID_Cus, TenKhachHang = c.Name, SDT = c.Phone, Tuoi = c.Age };
            dgvKhachHang.DataSource = result.ToList();
            DataBindKhachHang();
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBindKhachHang();
        }
        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            btnSuaKhachHang.Enabled = false;
            btnXoaKhachHang.Enabled = false;
            panelLuuHuyKH.Show();
        }
        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                string idkh = dgvKhachHang.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim();
                Customer cus = db.Customers.Find(idkh);
                cus.Name = txtTenKhachHang.Text.ToString().Trim();
                cus.Phone = txtSDTKhachHang.Text.ToString().Trim();
                cus.Age = Convert.ToInt32(txtTuoiKhachHang.Text);

                db.SaveChanges();
                MessageBox.Show("Update Successfull!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHang();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Update Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadKhachHang();
            }
        }
        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want delete this customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Customer cus = db.Customers.Where(p => p.ID_Cus == txtMaKhachHang.Text.ToString()).SingleOrDefault();
                    db.Customers.Remove(cus);
                    db.SaveChanges();
                    MessageBox.Show("Delete Successfull!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Delete Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadKhachHang();
            }
        }
        private void btnLuuKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                Customer cus = new Customer();

                cus.ID_Cus = txtMaKhachHang.Text.ToString().Trim();
                cus.Name = txtTenKhachHang.Text.ToString().Trim();
                cus.Phone = txtSDTKhachHang.Text.ToString().Trim();
                cus.Age = Convert.ToInt32(txtTuoiKhachHang.Text);

                db.Customers.Add(cus);
                db.SaveChanges();

                MessageBox.Show("Thêm Thành Công!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHang();
                panelLuuHuyKH.Hide();
                btnSuaKhachHang.Enabled = true;
                btnXoaKhachHang.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thêm Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadKhachHang();
            }
        }
        private void btnHuyKhachHang_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
            panelLuuHuyKH.Hide();
            btnSuaKhachHang.Enabled = true;
            btnXoaKhachHang.Enabled = true;
        }
        private void btnTimKhachHang_Click(object sender, EventArgs e)
        {
            String loaitimkiem = cbTimKhachHang.Text.ToString();
            Boolean flag_error = false;


            var ms = db.Customers.Where(p => p.Name.Contains(tbTimKhachHang.Text.ToString())).Select(c => new { IDCus = c.ID_Cus, TenKhachHang = c.Name, SDT = c.Phone, Tuoi = c.Age }).ToList();
            switch (loaitimkiem)
            {
                case "SĐT":
                    try
                    {
                        int age = Convert.ToInt32(tbTimKhachHang.Text.ToString());
                        ms = db.Customers.Where(p => p.Phone == tbTimKhachHang.Text.ToString()).Select(c => new { IDCus = c.ID_Cus, TenKhachHang = c.Name, SDT = c.Phone, Tuoi = c.Age }).ToList();
                        break;
                    }
                    catch (Exception)
                    {
                        flag_error = true;
                        break;
                    }
                case "Tuổi":
                    try
                    {
                        int age = Convert.ToInt32(tbTimKhachHang.Text.ToString());
                        ms = db.Customers.Where(p => p.Age == age).Select(c => new { IDCus = c.ID_Cus, TenKhachHang = c.Name, SDT = c.Phone, Tuoi = c.Age }).ToList();
                        break;
                    }
                    catch (Exception)
                    {
                        flag_error = true;
                        break;
                    }
            }
            if (flag_error)
            {
                MessageBox.Show("Lỗi! Vui lòng kiểm tra dữ liệu nhập vào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //var result = from c in db.Customers select new { IDCus = c.ID_Cus, TenKhachHang = c.Name, SDT = c.Phone, Tuoi = c.Age };
                //dgvKhachHang.DataSource = result.ToList();
                LoadKhachHang();
            }
            else
                dgvKhachHang.DataSource = ms;
        }

        private void btnReloadKH_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
        }
        #endregion

        #region TAB NHAN VIEN
        void DataBindNhanVien()
        {
            txtMaNhanVien.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNhanVien.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtSDTNhanVien.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtTuoiNhanVien.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtDiaChiNhanVien.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtLuongNhanVien.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            dtpNgayVaoLam.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
        }

        void LoadNhanVien()
        {
            var result = from c in db.Employees select new { IDEmp = c.ID_Emp, TenNhanVien = c.Name, SDT = c.Phone, Tuoi = c.Age, DiaChi = c.Address, Luong = c.Salary, NgayVaoLam = c.DateStart };
            dgvNhanVien.DataSource = result.ToList();
            DataBindNhanVien();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBindNhanVien();
        }
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            btnSuaNhanVien.Enabled = false;
            btnXoaNhanVien.Enabled = false;
            panelLuuHuyNV.Show();
        }
        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                string idemp = dgvNhanVien.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim();
                Employee emp = db.Employees.Find(idemp);
                emp.Name = txtTenNhanVien.Text.ToString().Trim();
                emp.Phone = txtSDTNhanVien.Text.ToString().Trim();
                emp.Age = Convert.ToInt32(txtTuoiNhanVien.Text);
                emp.Address = txtDiaChiNhanVien.Text.ToString().Trim();
                emp.Salary = Convert.ToInt32(txtLuongNhanVien.Text);
                emp.DateStart = DateTime.Parse(dtpNgayVaoLam.Text);

                db.SaveChanges();
                MessageBox.Show("Update Successfull!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Update Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadNhanVien();
            }
        }
        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want delete this employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Employee emp = db.Employees.Where(p => p.ID_Emp == txtMaNhanVien.Text.ToString()).SingleOrDefault();
                    db.Employees.Remove(emp);
                    db.SaveChanges();
                    MessageBox.Show("Delete Successfull!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVien();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Delete Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadNhanVien();
            }
        }
        private void btnLuuNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();

                emp.ID_Emp = txtMaNhanVien.Text.ToString().Trim();
                emp.Name = txtTenNhanVien.Text.ToString().Trim();
                emp.Phone = txtSDTNhanVien.Text.ToString().Trim();
                emp.Age = Convert.ToInt32(txtTuoiNhanVien.Text);
                emp.Address = txtDiaChiNhanVien.Text.ToString().Trim();
                emp.Salary = Convert.ToInt32(txtLuongNhanVien.Text);
                emp.DateStart = DateTime.Parse(dtpNgayVaoLam.Text);

                db.Employees.Add(emp);
                db.SaveChanges();

                MessageBox.Show("Thêm Thành Công!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();

                panelLuuHuyNV.Hide();
                btnSuaNhanVien.Enabled = true;
                btnXoaNhanVien.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thêm Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadNhanVien();
            }
        }


        private void btnHuyNhanVien_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
            panelLuuHuyNV.Hide();
            btnSuaNhanVien.Enabled = true;
            btnXoaNhanVien.Enabled = true;
        }


        private void btnTimNhanVien_Click(object sender, EventArgs e)
        {
            String loaitimkiem = cbbTimNhanVien.Text.ToString();
            Boolean flag_error = false;

            var ms = db.Employees.Where(p => p.Name.Contains(tbTimNhanVien.Text.ToString())).Select(c => new { IDEmp = c.ID_Emp, TenNhanVien = c.Name, SDT = c.Phone, Tuoi = c.Age, DiaChi = c.Address, Luong = c.Salary, NgayVaoLam = c.DateStart }).ToList();
            switch (loaitimkiem)
            {
                case "SĐT":
                    try
                    {
                        int age = Convert.ToInt32(tbTimNhanVien.Text.ToString());
                        ms = db.Employees.Where(p => p.Phone == tbTimNhanVien.Text.ToString()).Select(c => new { IDEmp = c.ID_Emp, TenNhanVien = c.Name, SDT = c.Phone, Tuoi = c.Age, DiaChi = c.Address, Luong = c.Salary, NgayVaoLam = c.DateStart }).ToList();
                        break;
                    }
                    catch (Exception)
                    {
                        flag_error = true;
                        break;
                    }
                case "Tuổi":
                    try
                    {
                        int age = Convert.ToInt32(tbTimNhanVien.Text.ToString());
                        ms = db.Employees.Where(p => p.Age == age).Select(c => new { IDEmp = c.ID_Emp, TenNhanVien = c.Name, SDT = c.Phone, Tuoi = c.Age, DiaChi = c.Address, Luong = c.Salary, NgayVaoLam = c.DateStart }).ToList();
                        break;
                    }
                    catch (Exception)
                    {
                        flag_error = true;
                        break;
                    }
                case "Lương":
                    try
                    {
                        int salary = Convert.ToInt32(tbTimNhanVien.Text.ToString());
                        ms = db.Employees.Where(p => p.Salary == salary).Select(c => new { IDEmp = c.ID_Emp, TenNhanVien = c.Name, SDT = c.Phone, Tuoi = c.Age, DiaChi = c.Address, Luong = c.Salary, NgayVaoLam = c.DateStart }).ToList();
                        break;
                    }
                    catch (Exception)
                    {
                        flag_error = true;
                        break;
                    }
            }

            if (flag_error)
            {
                MessageBox.Show("Lỗi! Vui lòng kiểm tra dữ liệu nhập vào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //var result = from c in db.Employees select new { IDEmp = c.ID_Emp, TenNhanVien = c.Name, SDT = c.Phone, Tuoi = c.Age, DiaChi = c.Address, Luong = c.Salary, NgayVaoLam = c.DateStart };
                //dgvNhanVien.DataSource = result.ToList();
                LoadNhanVien();
            }
            else
                dgvNhanVien.DataSource = ms;
        }

        private void btnReloadNV_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        #endregion

        #region TAB ADMIN
        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoCao frmbaocao = new BaoCao();
            frmbaocao.ShowDialog();
            this.Show();
        }


        #endregion

        #region TAB HOME

        private void btnHDDV_Click(object sender, EventArgs e)
        {
            HopDongDV hopDongDV = new HopDongDV();
            hopDongDV.ShowDialog();
        }
        private void LoadHome()
        {
            //List<Species> lstSpecies = db.Species.ToList();
            //  foreach(Species a in lstSpecies)
            //{
            int count = 0;
                List<Pet> lstPet = db.Pets.ToList();
                foreach (Pet pet in lstPet)
                {
                    count++;
                    Button btn = new Button();
                    btn.Text = "Thú Cưng "+count;
                    btn.Width = 150;
                    btn.Height = 150;
                    btn.Click += (sender, args) =>
                    {

                        txtIDChiTietThuCung.Text = pet.ID_Pet;
                        txtLoaiChiTietThuCung.Text = pet.ID_Spec;
                        txtNCCChiTietThuCung.Text = pet.Supplier.Name;
                        txtCanNangChiTietThuCung.Text = pet.Weight + "";
                        txtTuoiChiTietThuCung.Text = pet.Age + "";
                        txtGenderChiTietThuCung.Text = pet.Sex;

                       // fpnlMain.Hide();
                        pnlChiTietThuCung.Show();
                        //ChiTietThuCung frm = new ChiTietThuCung(a);
                        //frm.ShowDialog();
                    };
                    fpnlMain.Controls.Add(btn);
              //  }
             }
        }
        private void btnBackHome_Click(object sender, EventArgs e)
        {
           // fpnlMain.Show();
            pnlChiTietThuCung.Hide();
        }
        #endregion

        #region TAB USER
        //======================Start User============================
        void DataBindUser()
        {
            tbIDUser.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            tbTenUser.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            tbUsernameUser.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
            tbPasswordUser.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
            cbPermissionUser.SelectedItem = dgvUser.CurrentRow.Cells[4].Value.ToString().Trim();
        }

        void LoadUser()
        {
            var result = from c in db.Users select new { IDUser = c.ID, Ten = c.Name, Username = c.Username, Password = c.PassWord, Permission = c.Permission };
            dgvUser.DataSource = result.ToList();
            DataBindUser();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBindUser();
        }


        private void btnFindUser_Click(object sender, EventArgs e)
        {
            String loaitimkiem = cbFindUser.Text.ToString();
            Boolean flag_error = false;
            var ms = db.Users.Where(p => p.Name == tbFindUser.Text.ToString()).Select(c => new { IDUser = c.ID, Ten = c.Name, Username = c.Username, Password = c.PassWord, Permission = c.Permission }).ToList();
            switch (loaitimkiem)
            {
                case "Username":
                    ms = db.Users.Where(p => p.Username == tbFindUser.Text.ToString()).Select(c => new { IDUser = c.ID, Ten = c.Name, Username = c.Username, Password = c.PassWord, Permission = c.Permission }).ToList();
                    break;
            }
            if (flag_error)
            {
                MessageBox.Show("Lỗi! Vui lòng kiểm tra dữ liệu nhập vào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var result = from c in db.Users select new { IDUser = c.ID, Ten = c.Name, Username = c.Username, Password = c.PassWord, Permission = c.Permission };
            }
            else
                dgvUser.DataSource = ms;
        }

        private void btnThemUser_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            btnSuaUser.Enabled = false;
            btnXoaUser.Enabled = false;
            pnlLuuHuyUser.Show();
        }

        private void btnHuyUser_Click(object sender, EventArgs e)
        {
            LoadUser();
            pnlLuuHuyUser.Hide();
            btnSuaUser.Enabled = true;
            btnXoaUser.Enabled = true;
        }

        private void btnLuuUser_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();

                user.ID = tbIDUser.Text.ToString().Trim();
                user.Name = tbTenUser.Text.ToString().Trim();
                user.Username = tbUsernameUser.Text.ToString().Trim();
                user.PassWord = tbPasswordUser.Text.ToString().Trim();
                user.Permission = cbPermissionUser.Text.ToString().Trim();

                db.Users.Add(user);
                db.SaveChanges();

                MessageBox.Show("Thêm Thành Công!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUser();
                pnlLuuHuyUser.Hide();
                btnSuaUser.Enabled = true;
                btnXoaUser.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thêm Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadUser();
            }
        }

        private void btnXoaUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    User user = db.Users.Where(p => p.ID == tbIDUser.Text.ToString()).SingleOrDefault();
                    db.Users.Remove(user);
                    db.SaveChanges();
                    MessageBox.Show("Delete Successfull!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUser();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Delete Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadUser();
            }
        }

        private void btnSuaUser_Click(object sender, EventArgs e)
        {
            try
            {
                string iduser = dgvUser.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim();
                User user = db.Users.Find(iduser);
                user.Name = tbTenUser.Text.ToString().Trim();
                user.Username = tbUsernameUser.Text.ToString().Trim();
                user.PassWord = tbPasswordUser.Text.ToString().Trim();
                user.Permission = cbPermissionUser.Text.ToString().Trim();

                db.SaveChanges();
                MessageBox.Show("Update Successfull!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUser();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Update Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadUser();
            }
        }

        private void btnReloadUser_Click(object sender, EventArgs e)
        {
            LoadUser();
        }

        #endregion

        #region TAB PROFILE

        void getProfileUser()
        {
            var result = db.Users.Where(p => p.ID == iduser).Select(c => new { IDUser = c.ID, Ten = c.Name, Username = c.Username, Password = c.PassWord, Permission = c.Permission }).ToList().SingleOrDefault();
            tbIDProfile.Text = result.IDUser.ToString();
            tbTenProfile.Text = result.Ten.ToString();
            tbUsernameProfile.Text = result.Username.ToString();
            tbPasswordProfile.Text = result.Password.ToString();
            tbPerrmissProfle.Text = result.Permission.ToString();
        }

        private void btnSuaProfile_Click(object sender, EventArgs e)
        {
            btnSuaProfile.Enabled = false;
            pnlLuuHuyProfile.Show();
            tbTenProfile.ReadOnly = false;
            tbUsernameProfile.ReadOnly = false;
            tbPasswordProfile.ReadOnly = false;
        }

        private void btnLuuProfie_Click(object sender, EventArgs e)
        {
            try
            {
                string iduser = this.iduser;
                User user = db.Users.Find(iduser);
                user.Name = tbTenProfile.Text.ToString().Trim();
                user.Username = tbUsernameProfile.Text.ToString().Trim();
                user.PassWord = tbPasswordProfile.Text.ToString().Trim();

                db.SaveChanges();
                MessageBox.Show("Update Successfull!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HandleBtnHuyProfile();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Update Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
            }
        }
        void HandleBtnHuyProfile()
        {
            pnlLuuHuyProfile.Hide();
            btnSuaProfile.Enabled = true;
            tbTenProfile.ReadOnly = true;
            tbUsernameProfile.ReadOnly = true;
            tbPasswordProfile.ReadOnly = true;
        }

        private void btnHuyProfile_Click(object sender, EventArgs e)
        {
            HandleBtnHuyProfile();
        }


        #endregion


    }
}
