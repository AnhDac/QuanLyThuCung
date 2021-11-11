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
    public partial class ChiTietThuCung : Form
    {
        ThuCungEntities db = new ThuCungEntities();

        public ChiTietThuCung(Pet pet)
        {
            InitializeComponent();

            txtID.Text = pet.ID_Pet;
            txtSpecies.Text = pet.ID_Spec;
            txtNCC.Text = pet.Supplier.Name;
            txtCanNang.Text = pet.Weight + "";
            txtTuoi.Text = pet.Age + "";
            txtGender.Text = pet.Sex;
        }

        private void ChiTietThuCung_Load(object sender, EventArgs e)
        {

        }
    }
}
