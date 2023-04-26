using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using CaskInventory.Data.Interfaces;
using CaskInventory.Data.Entities;
using CaskInventory.Data.Repositories;

namespace CaskInventory.Application.purchase.Update
{
    public sealed class UpdatePurchaseHandler : IRequestHandler<UpdatePurchaseCommand, int>
    {
        private readonly IPurchaseRepository _purchaseRepository;

        public UpdatePurchaseHandler(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }
        public async Task<int> Handle(UpdatePurchaseCommand command, CancellationToken cancellationToken)
        {
            var purchase = await _purchaseRepository.GetPurchase(command.PurchaseId);
            if (purchase == null)
                return default;

            purchase.InvoiceNo = command.InvoiceNo;
            purchase.InvoiceDescription = command.InvoiceDescription;
            purchase.InvoiceDate = command.InvoiceDate;
            purchase.CaskId = command.CaskId;
            purchase.ClientId = command.ClientId;
            purchase.SalesPersonId = command.SalesPersonId;
            purchase.SupplierId = command.SupplierId;
            purchase.InvoiceLocation = command.InvoiceLocation;
            purchase.DoRecorded = command.DoRecorded;
            purchase.DoDate = command.DoDate;
            purchase.DoSignedReturnedDate = command.DoSignedReturnedDate;
            purchase.TransferComplete = command.TransferComplete;
            purchase.AmountPaid = command.AmountPaid;
            purchase.BeingMovedTo = command.BeingMovedTo;
            purchase.DoLocation = command.DoLocation;


            return await _purchaseRepository.UpdatePurchase(purchase);
        }
    }
}
