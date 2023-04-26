using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using CaskInventory.Data.Interfaces;
using CaskInventory.Data.Entities;

namespace CaskInventory.Application.purchase.Delete
{
    public sealed class DeletePurchaseHandler : IRequestHandler<DeletePurchaseCommand, int>
    {

        private readonly IPurchaseRepository _purchaseRepository;

        public DeletePurchaseHandler(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }
        public async Task<int> Handle(DeletePurchaseCommand command, CancellationToken cancellationToken)
        {
            var purchase = await _purchaseRepository.GetPurchase(command.PurchaseId);
            if (purchase == null)
                return default;

            return await _purchaseRepository.DeletePurchase(purchase.PurchaseId);
        }
    }
}
