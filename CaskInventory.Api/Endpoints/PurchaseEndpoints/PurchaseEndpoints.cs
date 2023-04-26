using CaskInventory.Application.purchase.Create;
using CaskInventory.Application.purchase.Get;
using CaskInventory.Application.purchase.Update;
using CaskInventory.Data.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaskInventory.Api.Endpoints.PurchaseEndpoints
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseEndpoints : ControllerBase
    {
        private readonly IMediator mediator;



        public PurchaseEndpoints(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet]
        public async Task<List<Purchase>> GetPurchaseListAsync()
        {
            var purchase = await mediator.Send(new GetPurchaseListQuery());

            return purchase;
        }

        [HttpGet("purchaseId")]
        public async Task<Purchase> GetPurchaseByIdAsync(int purchaseId)
        {
            var purchase = await mediator.Send(new GetPurchaseByIdQuery() { PurchaseId = purchaseId });

            return purchase;
        }

        [HttpPost]
        public async Task<Purchase> AddCaskAsync(CreatePurchaseCommand purchase)
        {
            var purchases = await mediator.Send(purchase);

            return purchases;
        }

        [HttpPut("{id}")]
        public async Task<int> UpdatePurchaseAsync(UpdatePurchaseCommand purchase)
        {
            var isPurchaseUpdated = await mediator.Send(purchase);
            return isPurchaseUpdated;
        }

        [HttpGet("clientName")]
        public async Task<Purchase> GetpurchaseByclientNameAsync(string clientName)
        {
            var purchase = await mediator.Send(new GetPurchaseByClientNameQuery() { clientName = clientName });

            return purchase;
        }
    }
}
