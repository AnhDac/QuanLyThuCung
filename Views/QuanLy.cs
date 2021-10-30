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
        ThụCungEntities db = new ThụCungEntities();
        private void QuanLy_Load(object sender, EventArgs e)
        {
            
        }

        void ClearDataBind()
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
        void DataBindThuCung()
        {

        }
        private void tabctrlMain_Click(object sender, EventArgs e)
        {
           if (tabctrlMain.SelectedTab == tabThuCung)
            {
                var result = from c in db.Pets select new { IDCus = c.ID_Pet, Name = c.ID_Spec, GioiTinh = c.Sex, PriceImport = c.PriceImport, NCC = c.ID_Sup, CanNang = c.Weight, Tuoi = c.Age };
                dgvThuCung.DataSource = result.ToList();
                DataBindThuCung();
               
            }
            else if (tabctrlMain.SelectedTab == tabNhanVien)
            {
                MessageBox.Show("SCHEDULE PAGE");
            }
            else if (tabctrlMain.SelectedTab == tabKhachHang)
            {
                //var result = from c in db.Customers select new { IDCus = c.ID_Cus, Name = c.Name, Phone = c.Phone };
               // dgvThuCung.DataSource = result.ToList();
            }
        }
    }
}
