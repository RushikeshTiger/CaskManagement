using CaskInventory.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.client.Create
{
    public class CreateClientCommand : IRequest<Client>
    {
        public string? ClientName { get; set; }

        public string? ClientEmail { get; set; }

        public string? ClientAddress { get; set; }

        
    }
}
