using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.client.Delete
{
    public class DeleteClientCommand : IRequest<int>
    {
        public int ClientId { get; set; }
    }
}
