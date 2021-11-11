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
    public partial class BaoCao : Form
    {
        ThuCungEntities db = new ThuCungEntities();
        
        
        public BaoCao()
        {
            InitializeComponent();
        }

        private void tabBCContractSelll_Click(object sender, EventArgs e)
        {

        }


        private void BaoCao_Load(object sender, EventArgs e)
        {
            
            LoadDataComboboxContractSell();
            LoadDataComboboxContractSer();
            ShowDataContractSell();
        }

        private void tabMain_Click(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tabContractSer)
            {            
                ShowDataContractSer();
            }
        }

        /*============================================
         ===============REPORT CONTRACT SELLL =========
        ==============================================*/

        void LoadDataComboboxContractSell()
        {
            //============Load Combobox Thang=================
            for (int i = 1; i < 13; i++)
            {
                cbThangBCContractSell.Items.Add(i);
            }
            cbThangBCContractSell.Text = DateTime.Now.Month.ToString();

            //============Load Combobox Năm=============
            for (int i = 2019; i <= DateTime.Now.Year; i++)
            {
                cbNamBCContractSell.Items.Add(i);
            }
            cbNamBCContractSell.Text = DateTime.Now.Year.ToString();
        }
        
        void ShowDataContractSell()
        {
            int year = Convert.ToInt32(cbNamBCContractSell.Text.ToString());
            int month = Convert.ToInt32(cbThangBCContractSell.Text.ToString());
            var c = db.usp_GetContractSellTheoThangVaNam(month, year).ToList();
            dgvContractSell.DataSource = c;
            //Get Number Transaction
            tbSoGiaoDichContractSell.Text= "" + c.Count();
            //Get profit
            var total = new System.Data.Entity.Core.Objects.ObjectParameter("total", 0);
            db.usp_GetProfitContractSellTheoThangVaNam(month, year, total);
            tbProfitContractSell.Text = total.Value + "";
            //Get Total Money Transaction
            db.usp_GetTotalMoneyTransactionContractSellTheoThangVaNam(month, year, total);
            tbTotalMoneyTransContractSell.Text = total.Value + "";

        }



        private void btnShowContractSell_Click(object sender, EventArgs e)
        {
            ShowDataContractSell();
        }


        /*============================================
         ===============REPORT CONTRACT SERVICE =======
        ==============================================*/

        void ShowDataContractSer()
        {
            int year = Convert.ToInt32(cbNamContractSer.Text.ToString());
            int month = Convert.ToInt32(cbThangContractSer.Text.ToString());
            var c = db.usp_GetContractSerTheoThangVaNam(month, year).ToList();
            dgvContractSer.DataSource = c;
            //Get Number Transaction
            tbSoGiaoDichContractSer.Text = "" + c.Count();
            //Get Total Money Transaction
            var total = new System.Data.Entity.Core.Objects.ObjectParameter("total", 0);
            db.usp_GetTotalMoneyTransactionContractSerTheoThangVaNam(month, year, total);
            tbTotalMoneyContractSer.Text = total.Value + "";
        }
        void LoadDataComboboxContractSer()
        {
            //============Load Combobox Thang=================
            for (int i = 1; i < 13; i++)
            {
                cbThangContractSer.Items.Add(i);
            }
            cbThangContractSer.Text = DateTime.Now.Month.ToString();

            //============Load Combobox Năm=============
            for (int i = 2019; i <= DateTime.Now.Year; i++)
            {
                cbNamContractSer.Items.Add(i);
            }
            cbNamContractSer.Text = DateTime.Now.Year.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDataContractSer();
        }
    }
}
