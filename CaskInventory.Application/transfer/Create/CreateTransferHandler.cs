using MediatR;
using CaskInventory.Data.Interfaces;
using CaskInventory.Data.Entities;

namespace CaskInventory.Application.transfer.Create
{
    public sealed class CreateTransferHandler : IRequestHandler<CreateTransferCommand, Transfer>
    {

        private readonly ITransferRepository _transferRepository;

        public CreateTransferHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public async Task<Transfer> Handle(CreateTransferCommand command, CancellationToken cancellationToken)
        {
            var transferDetails = new Transfer()
            {
                CaskId = command.CaskId,
                TransferDate = command.TransferDate,
                FromClientId = command.FromClientId,
                ToClientId = command.ToClientId

            };

            return await _transferRepository.AddTransfer(transferDetails);
        }
    }
}
