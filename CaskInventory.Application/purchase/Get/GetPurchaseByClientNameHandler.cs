using CaskInventory.Data.Entities;
using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CaskInventory.Application.purchase.Get
{
    public class GetPurchaseByClientNameHandler : IRequestHandler<GetPurchaseByClientNameQuery, Purchase>
    {
        private readonly IPurchaseRepository _purchaseRepository;

        public GetPurchaseByClientNameHandler(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }

        public Task<Purchase> Handle(GetPurchaseByClientNameQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        //public async Task<Purchase> Handle(GetPurchaseByClientNameQuery request, CancellationToken cancellationToken)
        //{
        //    return await _purchaseRepository.GetPurchase(request.clientName);
        //}
    }
}
