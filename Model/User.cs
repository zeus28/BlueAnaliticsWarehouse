using System;
using System.Collections.Generic;

namespace BlueAnaliticsWarehouse.model;

public partial class User
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
