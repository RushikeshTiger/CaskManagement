using CaskInventory.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.distillery.Create
{
    public class CreateDistilleryCommand : IRequest<Distillery>
    {
        public string? DistilleryName { get; set; }

        public string? DistilleryIlocation { get; set; }
    }
}
