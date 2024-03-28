using System;
using System.Collections.Generic;

namespace BlueAnaliticsWarehouse.model;

public partial class Warehouse
{
    public int WarId { get; set; }

    public string? WarName { get; set; }

    public string? WarLocation { get; set; }

    public virtual ICollection<WarProduct> WarProducts { get; set; } = new List<WarProduct>();
}
