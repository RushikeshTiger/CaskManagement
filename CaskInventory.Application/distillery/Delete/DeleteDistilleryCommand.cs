using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.distillery.Delete
{
    public class DeleteDistilleryCommand : IRequest<int>
    {
        public int DistilleryId { get; set; }
    }
}
