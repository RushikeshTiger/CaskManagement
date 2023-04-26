using MediatR;
using CaskInventory.Data.Entities;

namespace CaskInventory.Application.transfer.Create
{
    public class CreateTransferCommand : IRequest<Transfer>
    {
        public int? CaskId { get; set; }

        public DateTime? TransferDate { get; set; }

        public int? FromClientId { get; set; }

        public int? ToClientId { get; set; }

        
    }
}
