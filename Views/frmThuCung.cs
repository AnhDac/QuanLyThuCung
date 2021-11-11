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
    public partial class frmThuCung : Form
    {
        public frmThuCung()
        {
            InitializeComponent();
        }
        public frmThuCung(List<Pet> lst)
        {
            InitializeComponent();
            dgvListThuCung.DataSource = lst;
        }
    }
}
