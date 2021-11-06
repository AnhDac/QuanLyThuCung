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
    public partial class FormDemo : Form
    {
        ThuCungEntities db = new ThuCungEntities();
        public FormDemo()
        {
            InitializeComponent();
        }
       
        void LoadThuCung()
        {
            var result = db.view_Contract_ser.ToList();
            comboBox2.DataSource = result;
            comboBox3.Items.Add("ThanhQuang");
            comboBox3.Items.Add("ThanhQuang2");
            comboBox3.Items.Add("ThanhQuang3");
            comboBox2.DisplayMember = "ID_ConSer";// Ten trong database
            comboBox2.ValueMember = "result.ID_ConSer"; // tên trong bảng biến
            textBox1.Text = result[0].ID_ConSer;
            dataGridView2.DataSource = result;
           
        }
        void LoadThuCung1()
        {
            var result = db.view_Contract_ser.ToList();
            comboBox1.DataSource = result;
            comboBox1.DisplayMember = "ID_ConSer";// Ten trong database
            comboBox1.ValueMember = "ID_ConSer"; // tên trong bảng biến
            dataGridView1.DataSource = result;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDemo_Load(object sender, EventArgs e)
        {
            dataGridView2.Enabled = false;
            LoadThuCung1();
        }
        void databn ()
        {
            textBox1.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Enabled = true;
            LoadThuCung();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            databn();
        }
    }
}
