using MediatR;
using CaskInventory.Data.Entities;

namespace CaskInventory.Application.purchase.Delete
{
    public class DeletePurchaseCommand : IRequest<int>
    {
        public int PurchaseId { get; set; }
    }
}
