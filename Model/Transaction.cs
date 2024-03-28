using System;
using System.Collections.Generic;

namespace BlueAnaliticsWarehouse.model;

public partial class Transaction
{
    public int TransId { get; set; }

    public int? WarProdId { get; set; }

    public int? Userid { get; set; }

    /// <summary>
    /// in or out
    /// </summary>
    public string? TransType { get; set; }

    /// <summary>
    /// in or out 
    /// </summary>
    public DateTime? TransDate { get; set; }

    public int? Quantity { get; set; }

    public int? CustomerId { get; set; }

    public virtual Contact? Customer { get; set; }

    public virtual User? User { get; set; }

    public virtual WarProduct? WarProd { get; set; }
}
