using System;
using System.Collections.Generic;

namespace CaskInventory.Data.Entities;

public partial class Cask 
{
    public int CaskId { get; set; }

    public string? CaskDescription { get; set; }

    public string? CaskType { get; set; }

    public virtual ICollection<Caskfilling> Caskfillings { get; set; } = new List<Caskfilling>();

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();

    public virtual ICollection<Storage> Storages { get; set; } = new List<Storage>();

    public virtual ICollection<Transfer> Transfers { get; set; } = new List<Transfer>();
}
