using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using BlueAnaliticsWarehouse.Model;

namespace BlueAnaliticsWarehouse
{
    public partial class Main : Form
    {
        public frmTransactions TransactionForm;
        public Main()
        {
            InitializeComponent();
            TransactionForm = new frmTransactions();
            TransactionForm.MdiParent = this;
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["BlueAnaliticsWarehouse.Properties.Settings.conStr"].ConnectionString;

            //SqlConnection con = new SqlConnection(connectionString);
            //try
            //{
            //    con.Open();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally { con.Close(); }
            /*
            using (var ctx = new BlueAnaliticsContext())
            {
                var p = ctx.Products.ToList();
                MessageBox.Show("Total Products Count " + p.Count);
            }*/

            this.TransactionForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
