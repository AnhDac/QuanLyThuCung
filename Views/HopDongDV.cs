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
          //  LoadHopDongThuCung();
            LoadDVChamSoc();
           // LoadHopDongDV();
            
        }
        //----hợp đồng dịch vụ--\\\\\
        void LoadHopDongDV()
        {
            var result = from kq in db.Contract_Ser join kq2 in db.Servics on kq.ID_Ser equals kq2.ID_Ser  select new { IDConser = kq.ID_ConSer, IDEmp = kq.ID_Emp, IDCus = kq.ID_Cus, DateBuy = kq.DateBuy, ID_Ser=kq.ID_Ser , Name=kq2.Name,Price=kq2.Price};
            var customers = db.Customers.ToList();
            var kq1 = db.view_HDDichVu;
            cbDV.DataSource = customers;
            cbDV.DisplayMember = "ID_Cus";
            cbDV.ValueMember = "ID_Cus";
            
            int tam = 2018;
            for(int i=0;i<6;i++)
            {
                cbYear.Items.Add(tam+i);
            }    
            for(int i=1; i<=31;i++)
            {   
                if(i<13)
                {
                    cbMonth.Items.Add(i);
                }    
                cbDay.Items.Add(i);
            }    

           
            dgvHD.DataSource = result.ToList();
            txtHD_SoLuong.Text = dgvHD.Rows.Count.ToString();
            binHopDongDV();
            
        }
        void binHopDongDV()
        {
            txtHD_IDConser.Text = dgvHD.CurrentRow.Cells[0].Value.ToString().Trim();
            txtHD_IDEmp.Text = dgvHD.CurrentRow.Cells[1].Value.ToString().Trim();
            txtHD_IDCus.Text = dgvHD.CurrentRow.Cells[2].Value.ToString().Trim();
            dateSell_BuyDate.Text = dgvHD.CurrentRow.Cells[3].Value.ToString().Trim();
            txtHD_ser.Text= dgvHD.CurrentRow.Cells[4].Value.ToString().Trim();
            txtHD_Name.Text= dgvHD.CurrentRow.Cells[5].Value.ToString().Trim();
            txtHD_Price.Text= dgvHD.CurrentRow.Cells[6].Value.ToString().Trim();
            //------

        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binHopDongDV();
        }
        
        private void btnLuuHD_Click(object sender, EventArgs e)
        { 
               try
                {
                if (MessageBox.Show("Do you want update this Ser?", "update Ser", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string id = dgvHD.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim();
                    Contract_Ser contract = db.Contract_Ser.Find(id);
                    contract.ID_Emp = txtHD_IDEmp.Text.ToString().Trim();
                    contract.ID_Cus = txtHD_IDCus.Text.ToString().Trim();
                    contract.DateBuy = Convert.ToDateTime(dateSell_BuyDate.Text);
                    
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
                if (MessageBox.Show("Do you want insert this Contract_Ser?", "Delete Contract_Ser", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Contract_Ser contract = new Contract_Ser();

                    contract.ID_ConSer = txtHD_IDConser.Text.ToString().Trim();
                    contract.ID_Emp = txtHD_IDEmp.Text.ToString().Trim();
                    contract.ID_Cus = txtHD_IDCus.Text.ToString().Trim();
                    contract.DateBuy = Convert.ToDateTime(dateSell_BuyDate.Text);
                    contract.ID_Ser = txtDV_IDSer.Text.ToString().Trim();
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
                if (MessageBox.Show("Do you want delete this Ser?", "Delete Ser", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            int day = int.Parse(cbDay.Text.ToString().Trim());
            int month= int.Parse(cbMonth.Text.ToString().Trim());
            int year = int.Parse(cbYear.Text.ToString().Trim());
            string ID_cus = cbDV.Text.ToString().Trim();
            var kq = db.timKiem(year, month, day, ID_cus);
            dgvHD.DataSource = kq.ToList();
            txtHD_SoLuong.Text = dataGridView1.Rows.Count.ToString();
        }


        private void bthHD_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tl =
                 MessageBox.Show("Bạn muốn Thoát ???", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //---------form dịch vụ chăm sóc thú cưng---------không cần sửa\\
        void LoadDVChamSoc()
        {
            var result = from kq in db.Servics select new { IDSer = kq.ID_Ser, name = kq.Name, price = kq.Price };
            comboBox1.DataSource = result.ToList();
            comboBox1.DisplayMember = "name";
            comboBox1.SelectedItem = "name";
            dvgDV.DataSource = result.ToList();
            binDVChamSoc();
            
        }
        void binDVChamSoc()
        {
            txtDV_IDSer.Text = dvgDV.CurrentRow.Cells[0].Value.ToString().Trim();
            txtDV_name.Text = dvgDV.CurrentRow.Cells[1].Value.ToString().Trim();
            txtDV_price.Text = dvgDV.CurrentRow.Cells[2].Value.ToString().Trim();
        }

        private void dvgDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binDVChamSoc();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDVChamSoc();
        }

        private void btnDV_timKiem_Click(object sender, EventArgs e)
        {
            String tam = comboBox1.Text.ToString().Trim();
            var result = from kq in db.Servics where kq.Name == tam select new { IDSer = kq.ID_Ser, name = kq.Name, price = kq.Price };
            dvgDV.DataSource = result.ToList();
        }

        private void btnDV_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want update this servic?", "update servic", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string id = dvgDV.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim();
                    Servic servic = db.Servics.Find(id);
                    servic.Name =txtDV_name.Text.ToString().Trim();
                    servic.Price = Convert.ToInt32( txtDV_price.Text.ToString().Trim());
                    db.SaveChanges();

                    MessageBox.Show("update Thành Công!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDVChamSoc();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không update được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadDVChamSoc();
            }

        }

        private void btnDV_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want insert this servic?", "insert servic", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Servic servic = new Servic();

                    servic.ID_Ser = txtDV_IDSer.Text.ToString().Trim();
                    servic.Name = txtDV_name.Text.ToString().Trim();
                    servic.Price = int.Parse(txtDV_price.Text.ToString());
    


                    db.Servics.Add(servic);
                    db.SaveChanges();

                    MessageBox.Show("Thêm Thành Công!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDVChamSoc();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thêm Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadDVChamSoc();
            }
        }

        private void btnDV_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want delete this servic?", "Delete servic", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Servic servic = db.Servics.Where(p => p.ID_Ser == txtDV_IDSer.Text.ToString().Trim()).SingleOrDefault();
                    db.Servics.Remove(servic);
                    db.SaveChanges();
                    MessageBox.Show("Delete Successfull!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDVChamSoc();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Delete Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadDVChamSoc();
            }
        }

        // Hợp đồng thú cưng thêm xóa sửa reload 
        //----------hợp đồng bán  thú cưng-----\\\
        void binHopDongThuCung()
        {
            txtSell_IDCon.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            txtSell_IDEmp.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            txtSell_IDCus.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
            txtSell_IDPet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
            txtSell_Caltel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
            dateSell_DateSell.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
            txtSell_Price.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString().Trim();
        }
        void LoadHopDongThuCung()
        {
            var result = from kq in db.Contract_Sell select new { ID_ConSell = kq.ID_ConSell, ID_Emp = kq.ID_Emp, ID_Cus = kq.ID_Cus, ID_Pet = kq.ID_Pet, CateInsurance = kq.CateInsurance, DateSell = kq.DateSell, Price = kq.Price };
            dataGridView1.DataSource = result.ToList();
            binHopDongThuCung();
           
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binHopDongThuCung();
        }
        private void btnSell_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want update this Contract_Sell?", "Contract_Sell", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string id = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString().Trim();
                    Contract_Sell contract_Sell1 = db.Contract_Sell.Find(id);
                    
                    contract_Sell1.ID_Emp = txtSell_IDEmp.Text.ToString().Trim();
                    contract_Sell1.ID_Cus = txtSell_IDCus.Text.ToString().Trim();
                    contract_Sell1.ID_Pet = txtSell_IDPet.Text.ToString().Trim();
                    contract_Sell1.CateInsurance = txtSell_Caltel.Text.ToString().Trim();
                    contract_Sell1.DateSell = Convert.ToDateTime(dateSell_DateSell.Text);
                    contract_Sell1.Price = Convert.ToInt32(txtSell_Price.Text);
                    db.SaveChanges();

                    MessageBox.Show("update Thành Công!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHopDongThuCung();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không update được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadHopDongThuCung();
            }
        }

        private void btnSell_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want delete this Contract_Sell ?", "Delete Contract_Sell", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Contract_Sell contract = db.Contract_Sell.Where(p => p.ID_ConSell == txtSell_IDCon.Text.ToString().Trim()).SingleOrDefault();
                    db.Contract_Sell.Remove(contract);
                    db.SaveChanges();
                    MessageBox.Show("Delete Successfull!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHopDongThuCung();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Delete Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadHopDongThuCung();
            }
        }

        private void btnSell_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want insert this  Contract_Sell?", "insert Contract_Sell", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Contract_Sell contract_sell = new Contract_Sell();

                    contract_sell.ID_ConSell =txtSell_IDCon.Text.ToString().Trim();
                    contract_sell.ID_Emp = txtSell_IDEmp.Text.ToString().Trim();
                    contract_sell.ID_Cus = txtSell_IDCus.Text.ToString().Trim();
                    contract_sell.ID_Pet = txtSell_IDPet.Text.ToString().Trim();
                    contract_sell.CateInsurance = txtSell_Caltel.Text.ToString().Trim();
                    contract_sell.DateSell = Convert.ToDateTime(dateSell_DateSell.Text);
                    contract_sell.Price = Convert.ToInt32(txtSell_Price.Text);
                    db.Contract_Sell.Add(contract_sell);
                    db.SaveChanges();

                    MessageBox.Show("Thêm Thành Công!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHopDongThuCung();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thêm Được!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                db = new ThuCungEntities();
                LoadHopDongThuCung();
            }
        }

        private void btnHDThuCung_reload_Click(object sender, EventArgs e)
        {
            LoadHopDongDV();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab==tabPage2)
            {
                LoadHopDongDV();
            }
            if(tabControl1.SelectedTab==tabPage3)
            {

                LoadHopDongThuCung();
             }
        }
    }
}
