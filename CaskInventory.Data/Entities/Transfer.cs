using System;
using System.Collections.Generic;

namespace CaskInventory.Data.Entities;

public partial class Transfer
{
    public int TransferId { get; set; }

    public int? CaskId { get; set; }

    public DateTime? TransferDate { get; set; }

    public int? FromClientId { get; set; }

    public int? ToClientId { get; set; }

    public virtual Cask? Cask { get; set; }

    public virtual Client? FromClient { get; set; }

    public virtual Client? ToClient { get; set; }
}
