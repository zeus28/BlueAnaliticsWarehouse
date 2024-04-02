using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueAnaliticsWarehouse.Model.DTOs
{
    public class ProfitabilityDTO
    {
        public int product_id { get; set; }
        public string? ProductName { get; set; }
        public int ItemAverCost { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal GrossProfit { get; set; }
        public decimal GrossMargin { get; set; }

    }
}
