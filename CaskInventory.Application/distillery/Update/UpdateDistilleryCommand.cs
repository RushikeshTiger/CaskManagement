using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.distillery.Update
{
    public class UpdateDistilleryCommand : IRequest<int>
    {
        public int DistilleryId { get; set; }
        public string? DistilleryName { get; set; }

        public string? DistilleryIlocation { get; set; }
    }
}
