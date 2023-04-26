using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using CaskInventory.Data.Interfaces;
using CaskInventory.Data.Entities;


namespace CaskInventory.Application.purchase.Get
{
    public sealed class GetPurchaseByIdHandler : IRequestHandler<GetPurchaseByIdQuery, Purchase>
    {

        private readonly IPurchaseRepository _purchaseRepository;

        public GetPurchaseByIdHandler(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }
        public async Task<Purchase> Handle(GetPurchaseByIdQuery query, CancellationToken cancellationToken)
        {
            return await _purchaseRepository.GetPurchase(query.PurchaseId);
        }
    }
}
