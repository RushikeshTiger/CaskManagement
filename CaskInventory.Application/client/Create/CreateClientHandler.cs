using CaskInventory.Data.Entities;
using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.client.Create
{
    public sealed class CreateClientHandler : IRequestHandler<CreateClientCommand, Client>
    {
        private readonly IClientRepository _clientRepository;

        public CreateClientHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Client> Handle(CreateClientCommand command, CancellationToken cancellationToken)
        {
            var clientDetails = new Client()
            {
                ClientName = command.ClientName,
                ClientEmail = command.ClientEmail,
                ClientAddress = command.ClientAddress

            };

            return await _clientRepository.AddClient(clientDetails);
        }
    }
}
