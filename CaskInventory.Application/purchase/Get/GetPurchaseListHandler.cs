using MediatR;
using CaskInventory.Data.Interfaces;
using CaskInventory.Data.Entities;


namespace CaskInventory.Application.purchase.Get
{
    public sealed class GetPurchaseListHandler : IRequestHandler<GetPurchaseListQuery, List<Purchase>>
    {

        private readonly IPurchaseRepository _purchaseRepository;

        public GetPurchaseListHandler(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }
        public async Task<List<Purchase>> Handle(GetPurchaseListQuery request, CancellationToken cancellationToken)
        {
            return (List<Purchase>)await _purchaseRepository.GetPurchases();
        }
    }
}
