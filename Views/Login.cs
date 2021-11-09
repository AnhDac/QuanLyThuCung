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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        ThuCungEntities db = new ThuCungEntities();
        private void Login_Load(object sender, EventArgs e)
        {

        }
        public static string User = "";
        private void btDN_Click(object sender, EventArgs e)
        {
            String dangnhap = btDN.Text.ToString();
            //Boolean flag_error = false;


            String Username = txtTK.Text.ToString().Trim();
            String PassWord = txtMK.Text.ToString().Trim();
            var dn = from kq in db.User where kq.Username == Username && kq.PassWord == PassWord select new { Use = kq.Username, pass = kq.PassWord, Permission = kq.Permission };

            foreach (var item in dn.ToList())
            {
                if (item.Use != "" && item.pass != "")
                {
                    QuanLy quan = new QuanLy();
                    quan.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
                break;
            }

        }

    }
}
