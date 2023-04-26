using MediatR;
using CaskInventory.Data.Interfaces;
using CaskInventory.Data.Entities;

namespace CaskInventory.Application.purchase.Create
{
    public sealed class CreatePurchaseHandler : IRequestHandler<CreatePurchaseCommand, Purchase>
    {

        private readonly IPurchaseRepository _purchaseRepository;

        public CreatePurchaseHandler(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }

        public async Task<Purchase> Handle(CreatePurchaseCommand command, CancellationToken cancellationToken)
        {
            var purchaseDetails = new Purchase()
            {
                InvoiceNo = command.InvoiceNo,
                InvoiceDescription = command.InvoiceDescription,
                InvoiceDate = command.InvoiceDate,
                CaskId = command.CaskId,
                ClientId = command.ClientId,
                SalesPersonId = command.SalesPersonId,
                SupplierId = command.SupplierId,
                InvoiceLocation = command.InvoiceLocation,
                DoRecorded = command.DoRecorded,
                DoDate = command.DoDate,
                DoSignedReturnedDate = command.DoSignedReturnedDate,
                TransferComplete = command.TransferComplete,
                AmountPaid = command.AmountPaid,
                BeingMovedTo = command.BeingMovedTo,
                DoLocation = command.DoLocation

            };

            return await _purchaseRepository.AddPurchase(purchaseDetails);
        }
    }
}
