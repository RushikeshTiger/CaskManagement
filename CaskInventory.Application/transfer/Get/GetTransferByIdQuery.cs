using MediatR;
using CaskInventory.Data.Entities;

namespace CaskInventory.Application.transfer.Get
{
    public class GetTransferByIdQuery : IRequest<Transfer>
    {
        public int TransferId { get; set; }
    }
}
