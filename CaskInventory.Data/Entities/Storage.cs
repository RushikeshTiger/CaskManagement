using System;
using System.Collections.Generic;

namespace CaskInventory.Data.Entities;

public partial class Storage
{
    public int StorageId { get; set; }

    public int? CaskId { get; set; }

    public string? StorageAnniversary { get; set; }

    public string? StorageInventorySent { get; set; }

    public string? StorageReminder { get; set; }

    public virtual Cask? Cask { get; set; }
}
