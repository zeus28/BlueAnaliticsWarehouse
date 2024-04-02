using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueAnaliticsWarehouse.Model.DTOs
{
    public class WarehouseReportDTO
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int ItemsIn { get; set; }
        public int ItemsOut { get; set; }
        public int BeginningStock { get; set; }
        public int CurrentStock { get; set; }

    }
}
