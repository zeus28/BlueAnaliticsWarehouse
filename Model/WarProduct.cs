using System;
using System.Collections.Generic;

namespace BlueAnaliticsWarehouse.model;

public partial class WarProduct
{
    public int WarProdId { get; set; }

    public int ProductId { get; set; }

    public int? WarId { get; set; }

    public int? UnitsInStock { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual Warehouse? War { get; set; }
}
