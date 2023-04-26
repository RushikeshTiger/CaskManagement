using System;
using System.Collections.Generic;

namespace CaskInventory.Data.Entities;

public partial class Caskfilling
{
    public int CfId { get; set; }

    public int? DistilleryId { get; set; }

    public int? CaskId { get; set; }

    public decimal? Rlaola { get; set; }

    public decimal? Abv { get; set; }

    public decimal? CaskPrice { get; set; }

    public decimal? BulkLiture { get; set; }

    public string? Region { get; set; }

    public DateTime? FillingDate { get; set; }

    public virtual Cask? Cask { get; set; }

    public virtual Distillery? Distillery { get; set; }

   
}
