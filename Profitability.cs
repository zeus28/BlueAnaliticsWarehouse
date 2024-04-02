using BlueAnaliticsWarehouse.model;
using BlueAnaliticsWarehouse.Model.DTOs;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueAnaliticsWarehouse
{
    public partial class Profitability : Form
    {
        public Profitability()
        {
            InitializeComponent();
        }

        private void Profitability_Load(object sender, EventArgs e)
        {
            this.dtFrom.Value = DateTime.Today.AddYears(-1);
            this.dtTo.Value = DateTime.Today;

            try
            {

                using (var ctx = new BlueAnaliticsContext())
                {

                    var w = ctx.Warehouses.ToList();
                    this.cboWarehouse.DataSource = w;
                    this.cboWarehouse.ValueMember = "WarId";
                    this.cboWarehouse.DisplayMember = "WarName";
                    this.cboWarehouse.SelectedIndex = -1;
                    this.cboWarehouse.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboWarehouse_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.cboProducts.DataSource = null;
            if (this.cboWarehouse.SelectedIndex > -1)
            {

                using (var ctx = new BlueAnaliticsContext())
                {


                    var p = ctx.WarProducts.Where(n => n.WarId == Convert.ToInt32(this.cboWarehouse.SelectedValue)).Select(n => n.Product).ToList();

                    this.cboProducts.DataSource = p;
                    this.cboProducts.ValueMember = "ProductId";
                    this.cboProducts.DisplayMember = "PruductName";// typo in PrOductName
                    this.cboProducts.Enabled = p.Count > 0;
                    this.cboProducts.SelectedIndex = -1;
                }


            }
        }

        private void Profitability_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void ProfitabilityReport_Click(object sender, EventArgs e)
        {
            try
            {

                using (var ctx = new BlueAnaliticsContext()) {


                    var fromDate = new Microsoft.Data.SqlClient.SqlParameter("@fromDate", this.dtFrom.Value);
                    var toDate = new Microsoft.Data.SqlClient.SqlParameter("@toDate", this.dtTo.Value);
                    var productId = new Microsoft.Data.SqlClient.SqlParameter("@productId", cboProducts.SelectedValue == null ? DBNull.Value : cboProducts.SelectedValue);
                    var warId = new Microsoft.Data.SqlClient.SqlParameter("@warId", Convert.ToInt32(cboWarehouse.SelectedValue));

                    var qparams = new SqlParameter[] { fromDate, toDate, warId, productId };
                      

                    var r = ctx.Database.SqlQueryRaw<ProfitabilityDTO>("exec [dbo].[getProfitabilityData] @fromDate,@toDate,@warId, @productId " , qparams).ToList();
                    this.dataGridView1.DataSource = r;

                }

            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
