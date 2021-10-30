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

namespace QLThuCung
{
    public partial class Form1 : Form
    {
        ThụCungEntities db = new ThụCungEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var result = from c in db.Customers select new { IDCus = c.ID_Cus, Name = c.Name, Phone = c.Phone};
            dgvTest.DataSource = result.ToList();
        }
    }
}
