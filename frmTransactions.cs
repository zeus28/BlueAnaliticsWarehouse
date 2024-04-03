using BlueAnaliticsWarehouse.model;
using BlueAnaliticsWarehouse.Model;
using BlueAnaliticsWarehouse.Model.DTOs;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueAnaliticsWarehouse
{
    public partial class frmTransactions : Form
    {

        public List<WarProduct> warProducts;
        public List<SellingPriceHistory> sellingPriceHistory;
        public List<OrderingPriceHistory> orderingPriceHistory;
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void frmTransactions_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.errorProvider1.HasErrors)
            {

            }
            else
            {

            }
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            try
            {

                using (var ctx = new BlueAnaliticsContext())
                {
                    this.statusStrip1.Items[0].Text = "";

                    var cont = ctx.Contacts.ToList();
                    var w = ctx.Warehouses.ToList();

                    this.cboCustomer.DataSource = cont;
                    this.cboCustomer.ValueMember = "ContactId";
                    this.cboCustomer.DisplayMember = "ContactName";
                    this.cboCustomer.SelectedIndex = -1;


                    this.cboWareHouse.DataSource = w;
                    this.cboWareHouse.ValueMember = "WarId";
                    this.cboWareHouse.DisplayMember = "WarName";
                    this.cboWareHouse.SelectedIndex = -1;
                    this.cboWareHouse.Focus();

                    List<InOut> inOut = new List<InOut>() { new InOut() { o = "In", v = 1 }, new InOut() { o = "Out", v = -1 } };
                    this.cboInout.Items.Clear();
                    this.cboInout.DataSource = inOut;
                    this.cboInout.ValueMember = "v";
                    this.cboInout.DisplayMember = "o";

                    this.warProducts = ctx.WarProducts.ToList();
                    this.sellingPriceHistory = ctx.SellingPriceHistories.ToList();
                    this.orderingPriceHistory = ctx.OrderingPriceHistories.ToList();

                }

                this.dataGridView1.DataSource = this.transactionDTOBindingSource;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void cboWareHouse_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboWareHouse.SelectedIndex == -1)
            {
                this.errorProvider1.SetError(cboWareHouse, "Please Select Warehouse");
                this.errorProvider1.SetIconAlignment(cboWareHouse, ErrorIconAlignment.TopLeft);
                

                e.Cancel = true;

            }
            else
            {
                this.errorProvider1.Clear();
            }

        }

        private void cboProducts_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboProducts.SelectedIndex == -1)
            {

                this.errorProvider1.SetError(cboProducts, "Please Select Products");
                this.errorProvider1.SetIconAlignment(cboProducts, ErrorIconAlignment.MiddleRight);
                e.Cancel = true;

            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void cboInout_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboInout.SelectedIndex == -1)
            {

                this.errorProvider1.SetError(cboInout, "Define trunsaction type");
                this.errorProvider1.SetIconAlignment(cboInout, ErrorIconAlignment.TopLeft);
                e.Cancel = true;

            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void nfQty_Validating(object sender, CancelEventArgs e)
        {
            if (Int32.Parse(this.nfQty.Text) == 0)
            {

                this.errorProvider1.SetError(this.nfQty, "Quantity must be greater then zero");
                this.errorProvider1.SetIconAlignment(nfQty, ErrorIconAlignment.TopLeft);
                e.Cancel = true;

            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.errorProvider1.HasErrors)
            {

                var warPodId = this.warProducts.Where(n => n.ProductId == Convert.ToInt32(cboProducts.SelectedValue) && n.WarId == Convert.ToInt32(this.cboWareHouse.SelectedValue)).FirstOrDefault();
                var unitPrice = this.sellingPriceHistory.Where(n => n.FromDt <= this.dfTransDate.Value && (n.UntilDt == null ? DateTime.Now : n.UntilDt) >= this.dfTransDate.Value && n.ProductId == Convert.ToInt32(cboProducts.SelectedValue)).FirstOrDefault();
                if (warPodId == null)
                {
                    //should not happen;
                    throw new Exception("Unable to get Warehouse info ");
                }


                var ntdto = new TransactionDTO()
                {
                    CustomerFriendlyName = (cboCustomer.SelectedItem as Contact)?.ContactName,
                    customerId = Convert.ToInt32(this.cboCustomer.SelectedValue),
                    ProductName = (cboProducts.SelectedItem as Product)?.PruductName,

                    quantity = Convert.ToInt32(this.nfQty.Value) * Convert.ToInt32(this.cboInout.SelectedValue),
                    trans_date = this.dfTransDate.Value,
                    trans_type = (cboInout.SelectedItem as InOut)?.o,
                    WarehouseName = (cboWareHouse.SelectedItem as Warehouse)?.WarName,
                    war_prod_id = warPodId.WarProdId,
                    userId = 1, // This must be replced with authenticated userid 
                    UnitPrice = unitPrice?.SellingPrice,
                    Total = Convert.ToInt32(this.nfQty.Value) * unitPrice?.SellingPrice



                };

                this.transactionDTOBindingSource.Add(ntdto);
                this.transactionDTOBindingSource.ResetBindings(false);
                this.dataGridView1.Refresh();

                clearField();

                //this.ListTransactionDTO.Add(ntdto);

                //this.transactionDTOBindingSource.




            }
        }
        private void clearField()
        {

            this.cboCustomer.SelectedIndex = -1;
            //this.cboInout.SelectedIndex = -1;
            this.cboProducts.SelectedIndex = -1;
            this.cboWareHouse.SelectedIndex = -1;
            this.nfQty.Value = 0;

            //this.dfTransDate.Value = dfTransDate.MinDate;
            //this.dfTransDate.CustomFormat = "";
        }
        private void cboWareHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (this.cboWareHouse.SelectedIndex > -1)
            {
                
                using (var ctx = new BlueAnaliticsContext())
                {
                    var warHouse = (Warehouse)cboWareHouse.SelectedValue;

                    var p = ctx.WarProducts.Where(n => n.WarId == warHouse.WarId).ToList();
                    this.cboProducts.DataSource = p;
                    this.cboProducts.ValueMember = "ProductId";
                    this.cboProducts.DisplayMember = "ProductName";
                    this.cboProducts.Enabled = p.Count > 0;
                }
                
            }*/
        }

        private void cboWareHouse_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.cboProducts.DataSource = null;
            if (this.cboWareHouse.SelectedIndex > -1)
            {

                using (var ctx = new BlueAnaliticsContext())
                {


                    var p = ctx.WarProducts.Where(n => n.WarId == Convert.ToInt32(this.cboWareHouse.SelectedValue)).Select(n => n.Product).ToList();

                    this.cboProducts.DataSource = p;
                    this.cboProducts.ValueMember = "ProductId";
                    this.cboProducts.DisplayMember = "PruductName";// typo in PrOductName
                    this.cboProducts.Enabled = p.Count > 0;
                    this.cboProducts.SelectedIndex = -1;
                }


            }
        }

        private void cboProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {

            using (var ctx = new BlueAnaliticsContext())
            {

                var warId = new SqlParameter("@warId", this.cboWareHouse.SelectedValue);
                var productId = new SqlParameter("@productId", this.cboProducts.SelectedValue);
                int currentStockLevel = ctx.Database.SqlQuery<int>($"exec [dbo].[getCurrentStockQty] @warId={warId},@productId={productId},@fromDate=null").ToList().FirstOrDefault();
                this.ttCurrentStockLevel.Text = "Current Stock :" + currentStockLevel;
            }

        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                var currentTransactions = transactionDTOBindingSource.Cast<TransactionDTO>().ToList().
                       Select(n => new Transaction()
                       {
                           CustomerId = n.customerId,
                           Quantity = n.quantity,
                           TransDate = n.trans_date,
                           WarProdId = n.war_prod_id,
                           TransType = n.trans_type,
                           Userid = n.userId,
                       }).ToList();

                using (var ctx = new BlueAnaliticsContext())
                {
                    ctx.AddRange(currentTransactions);
                    await ctx.SaveChangesAsync();
                    MessageBox.Show($"{currentTransactions.Count} Transaction items Have been saved");
                    transactionDTOBindingSource.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMovingAvg_Click(object sender, EventArgs e)
        {
            var currentList = transactionDTOBindingSource.Cast<TransactionDTO>().ToList().Where(n => n.trans_type == "Out");
            if (currentList.Count() > 0)
            {
                var groupedAvg = currentList.GroupBy(t => (t.ProductName, t.WarehouseName)).Select(group => new
                {
                    ProductName = group.Key.ProductName,
                    WarehouseName = group.Key.WarehouseName,
                    Avg = group.Average(t => t.UnitPrice * System.Math.Abs(t.quantity))
                }).ToList();

                var sb = new StringBuilder();
                foreach (var group in groupedAvg)
                {
                    sb.Append($"{group.WarehouseName}, {group.ProductName} , Avg:  {group.Avg} \n");
                }
                MessageBox.Show(sb.ToString(), "Purchases Moving Average");
            }
            else
            {
                MessageBox.Show("No Out items are available");
            }


        }

        private void cboCustomer_Validating(object sender, CancelEventArgs e)
        {
            if (this.cboCustomer.SelectedIndex == -1)
            {

                this.errorProvider1.SetError(cboCustomer, "Customer can not be empty");
                this.errorProvider1.SetIconAlignment(cboCustomer, ErrorIconAlignment.TopLeft);
                e.Cancel = true;

            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
