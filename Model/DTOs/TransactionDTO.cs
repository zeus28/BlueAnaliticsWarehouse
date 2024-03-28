using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueAnaliticsWarehouse.Model.DTOs
{
    public class TransactionDTO
    {
        public int war_prod_id { get; set; }
        public int userId { get; set; }
        public string? trans_type { get; set; }
        public DateTime trans_date { get; set; }
        public int quantity { get; set; }
        public int customerId { get; set; }
        public string? CustomerFriendlyName { get; set; }
        public string? WarehouseName { get; set; }
        public string? ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Total { get; set; }
    }
}
