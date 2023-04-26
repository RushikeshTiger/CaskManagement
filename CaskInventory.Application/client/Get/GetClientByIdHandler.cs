using CaskInventory.Data.Entities;
using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.client.Get
{
    public sealed class GetClientByIdHandler : IRequestHandler<GetClientByIdQuery, Client>
    {
        private readonly IClientRepository _clientRepository;

        public GetClientByIdHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<Client> Handle(GetClientByIdQuery query, CancellationToken cancellationToken)
        {
            return await _clientRepository.GetClient(query.ClientId);
        }
    }
}
