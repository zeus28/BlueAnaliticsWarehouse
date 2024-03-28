using System;
using System.Collections.Generic;

namespace BlueAnaliticsWarehouse.model;

public partial class Product
{
    public int ProductId { get; set; }

    public string? PruductName { get; set; }

    public int? SupplierId { get; set; }

    public int? CategoryId { get; set; }

    public string? QtyPerUnit { get; set; }

    public virtual ICollection<OrderingPriceHistory> OrderingPriceHistories { get; set; } = new List<OrderingPriceHistory>();

    public virtual ICollection<SellingPriceHistory> SellingPriceHistories { get; set; } = new List<SellingPriceHistory>();

    public virtual Contact? Supplier { get; set; }

    public virtual ICollection<WarProduct> WarProducts { get; set; } = new List<WarProduct>();
}
