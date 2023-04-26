using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.client.Update
{
    public class UpdateClientCommand : IRequest<int>
    {
        public int ClientId { get; set; }
        public string? ClientName { get; set; }

        public string? ClientEmail { get; set; }

        public string? ClientAddress { get; set; }
    }
}
