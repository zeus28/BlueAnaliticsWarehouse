using System;
using System.Collections.Generic;

namespace BlueAnaliticsWarehouse.model;

public partial class Contact
{
    public int ContactId { get; set; }

    public string? ContactName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
