using MediatR;
using CaskInventory.Data.Entities;

namespace CaskInventory.Application.purchase.Get
{
    public class GetPurchaseListQuery : IRequest<List<Purchase>>
    {
    }
}
