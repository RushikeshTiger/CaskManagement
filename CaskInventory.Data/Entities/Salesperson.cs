using System;
using System.Collections.Generic;

namespace CaskInventory.Data.Entities;

public partial class Salesperson
{
    public int SalespersonId { get; set; }

    public string? SalespersonName { get; set; }

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
}
