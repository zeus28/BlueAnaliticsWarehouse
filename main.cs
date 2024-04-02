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
        public WarehouseReport WarehouseReport;
        public Profitability Profitability;
        Dictionary<string, Form> dictClickedForm = new Dictionary<string, Form>();
        public Main()
        {
            InitializeComponent();
            TransactionForm = new frmTransactions();
            WarehouseReport = new WarehouseReport();
            Profitability = new Profitability();

            TransactionForm.MdiParent = this;
            WarehouseReport.MdiParent = this;
            Profitability.MdiParent = this;

        }



        private void Main_Load(object sender, EventArgs e)
        {
            dictClickedForm.Add("Transactions", this.TransactionForm);
            dictClickedForm.Add("Warehouse", this.WarehouseReport);
            dictClickedForm.Add("Profitability", this.Profitability);

            SubscribeToClickEvents(this.menuStrip1.Items);
        }
        private void SubscribeToClickEvents(ToolStripItemCollection items)
        {
            foreach (ToolStripItem item in items)
            {
                if (item is ToolStripMenuItem menuItem)
                {
                    // Subscribe to Click event for ToolStripMenuItem
                    menuItem.Click += ToolStripMenuItem_Click;

                    // If the menu item has dropdown items, recursively subscribe to their Click events
                    if (menuItem.HasDropDownItems)
                    {
                        SubscribeToClickEvents(menuItem.DropDownItems);
                    }
                }
            }
        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get the clicked ToolStripMenuItem
            if (sender is ToolStripMenuItem clickedItem)
            {
                // Use the clicked item
                //MessageBox.Show("Clicked item: " + clickedItem.Text);
                if (dictClickedForm.ContainsKey(clickedItem.Text))
                {
                    dictClickedForm[clickedItem.Text].Show();
                }
                // You can also perform other actions based on the clicked item
            }
        }




    }
}
