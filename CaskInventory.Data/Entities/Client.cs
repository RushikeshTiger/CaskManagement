using System;
using System.Collections.Generic;

namespace CaskInventory.Data.Entities;

public partial class Client
{
    public int ClientId { get; set; }

    public string? ClientName { get; set; }

    public string? ClientEmail { get; set; }

    public string? ClientAddress { get; set; }

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();

    public virtual ICollection<Transfer> TransferFromClients { get; set; } = new List<Transfer>();

    public virtual ICollection<Transfer> TransferToClients { get; set; } = new List<Transfer>();
}
