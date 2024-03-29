using BlueAnaliticsWarehouse.model;
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
    public partial class WarehouseReport : Form
    {
        public WarehouseReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new BlueAnaliticsContext()) {


                var r = ctx.Database.SqlQueryRaw<Model.DTOs.WarehouseReportDTO>("exec getStockDetailsPerWareHouse '2023-02-01' , '2024-03-29' , null , 1").ToList();

            }
        }
    }
}
