using System;
using System.Collections.Generic;

namespace BlueAnaliticsWarehouse.model;

public partial class SellingPriceHistory
{
    public int ShChangeId { get; set; }

    public int ProductId { get; set; }

    public decimal? SellingPrice { get; set; }

    public DateTime? FromDt { get; set; }

    public DateTime? UntilDt { get; set; }

    public virtual Product Product { get; set; } = null!;
}
