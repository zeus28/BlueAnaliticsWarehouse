using System;
using System.Collections.Generic;

namespace BlueAnaliticsWarehouse.model;

public partial class OrderingPriceHistory
{
    public int PriceChangeId { get; set; }

    public int? ProductId { get; set; }

    public decimal? OrderingPrice { get; set; }

    public DateTime? FromDt { get; set; }

    public DateTime? UntilDt { get; set; }

    public virtual Product? Product { get; set; }
}
