using MediatR;
using CaskInventory.Data.Entities;

namespace CaskInventory.Application.purchase.Get
{
    public class GetPurchaseByIdQuery : IRequest<Purchase>
    {
        public int PurchaseId { get; set; }
    }
}
