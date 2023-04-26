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
    public sealed class GetClientListHandler : IRequestHandler<GetClientListQuery, List<Client>>
    {
        private readonly IClientRepository _clientRepository;

        public GetClientListHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<List<Client>> Handle(GetClientListQuery request, CancellationToken cancellationToken)
        {
            return (List<Client>)await _clientRepository.GetClients();
        }
    }
}
