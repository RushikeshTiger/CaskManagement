using CaskInventory.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.caskFilling.Create
{
    public class CreateCaskFillingCommand : IRequest<Caskfilling>
    {
        public int? DistilleryId { get; set; }

        public int? CaskId { get; set; }

        public decimal? Rlaola { get; set; }

        public decimal? Abv { get; set; }

        public decimal? CaskPrice { get; set; }

        public decimal? BulkLiture { get; set; }

        public string? Region { get; set; }

        public DateTime? FillingDate { get; set; }
    }
}
