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
    public partial class DangNhap : Form
    {
        ThuCungEntities db = new ThuCungEntities();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String PassWord = tbPassword.Text.ToString().Trim();
            String Username = tbUsername.Text.ToString().Trim();
            var result = db.Users.Where(p => p.Username == Username && p.PassWord == PassWord).Select(c => new { IDUser = c.ID, Ten = c.Name, Username = c.Username, Password = c.PassWord, Permission = c.Permission }).ToList().SingleOrDefault();
            if (result != null)
            {
                String id = result.IDUser.ToString().Trim();
                this.Hide();
                QuanLy frmbaocao = new QuanLy(id);
                frmbaocao.ShowDialog();
                tbPassword.Text = "";
                tbUsername.Text = "";
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLater_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLy frmbaocao = new QuanLy("");
            frmbaocao.ShowDialog();
            tbPassword.Text = "";
            tbUsername.Text = "";
            this.Show();
        }
    }
}
