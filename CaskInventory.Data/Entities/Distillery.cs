using System;
using System.Collections.Generic;

namespace CaskInventory.Data.Entities;

public partial class Distillery
{
    public int DistilleryId { get; set; }

    public string? DistilleryName { get; set; }

    public string? DistilleryIlocation { get; set; }

    public virtual ICollection<Caskfilling> Caskfillings { get; set; } = new List<Caskfilling>();
}
