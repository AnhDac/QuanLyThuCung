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
        ThuCung1Entities db = new ThuCung1Entities();
        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        public static string User = "";
       

        private void btDN_Click_1(object sender, EventArgs e)
        {
           
            String PassWord = txtMK.Text.ToString().Trim();
            String Username = txtTK.Text.ToString().Trim();
            var dn = (from kq in db.Users where kq.Username == Username && kq.PassWord == PassWord select kq).ToList();
            foreach(var item in dn)
            {
               
                if(item.ID !="")
                {
 
                    QuanLy quan = new QuanLy();
                    quan.Show();
                    break;
                }

            }
           

        }
    }
}
