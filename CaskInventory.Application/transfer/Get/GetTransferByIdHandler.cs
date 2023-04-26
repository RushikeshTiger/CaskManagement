using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using CaskInventory.Data.Interfaces;
using CaskInventory.Data.Entities;

namespace CaskInventory.Application.transfer.Get
{
    public class GetTransferByIdHandler : IRequestHandler<GetTransferByIdQuery, Transfer>
    {

        private readonly ITransferRepository _transferRepository;

        public GetTransferByIdHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }
        public async Task<Transfer> Handle(GetTransferByIdQuery query, CancellationToken cancellationToken)
        {
            return await _transferRepository.GetTransfer(query.TransferId);
        }
    }
}
