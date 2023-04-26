using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.client.Update
{
    public sealed class UpdateClientHandler : IRequestHandler<UpdateClientCommand, int>
    {
        private readonly IClientRepository _clientRepository;

        public UpdateClientHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<int> Handle(UpdateClientCommand command, CancellationToken cancellationToken)
        {
            var client = await _clientRepository.GetClient(command.ClientId);
            if (client == null)
                return default;

            client.ClientName = command.ClientName;
            client.ClientEmail = command.ClientEmail;
            client.ClientAddress = command.ClientAddress;


            return await _clientRepository.UpdateClient(client);
        }
    }
}
