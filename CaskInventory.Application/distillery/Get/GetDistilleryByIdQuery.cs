using CaskInventory.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.distillery.Get
{
    public class GetDistilleryByIdQuery : IRequest<Distillery>
    {
        public int DistilleryId { get; set; }
    }
}
