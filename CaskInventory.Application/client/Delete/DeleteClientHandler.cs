using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.client.Delete
{
    public sealed class DeleteClientHandler : IRequestHandler<DeleteClientCommand, int>
    {
        private readonly IClientRepository _clientRepository;

        public DeleteClientHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<int> Handle(DeleteClientCommand command, CancellationToken cancellationToken)
        {
            var student = await _clientRepository.GetClient(command.ClientId);
            if (student == null)
                return default;

            return await _clientRepository.DeleteClient(student.ClientId);
        }
    }
}
