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
            binHopDongDV();
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
            textBox1.Text = dgvHD.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dgvHD.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dgvHD.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dgvHD.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dgvHD.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binHopDongDV();
        }
    }
}
