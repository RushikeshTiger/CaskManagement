using MediatR;
using CaskInventory.Data.Entities;

namespace CaskInventory.Application.purchase.Update
{
    public class UpdatePurchaseCommand : IRequest<int>
    {
        public int PurchaseId { get; set; }
        public int? InvoiceNo { get; set; }

        public string? InvoiceDescription { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public int? CaskId { get; set; }

        public int? ClientId { get; set; }

        public int? SalesPersonId { get; set; }

        public int? SupplierId { get; set; }

        public string? InvoiceLocation { get; set; }

        public string? DoRecorded { get; set; }

        public DateTime? DoDate { get; set; }

        public string? DoLocation { get; set; }

        public DateTime? DoSignedReturnedDate { get; set; }

        public string? TransferComplete { get; set; }

        public decimal? AmountPaid { get; set; }

        public string? BeingMovedTo { get; set; }

        

       
    }
}
