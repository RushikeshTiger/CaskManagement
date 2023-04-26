using CaskInventory.Application.transfer.Create;
using CaskInventory.Application.transfer.Get;
using CaskInventory.Data.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaskInventory.Api.Endpoints.TransferEndpoints
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferEndpoints : ControllerBase
    {
        private readonly IMediator mediator;
        public TransferEndpoints(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet("transferId")]
        public async Task<Transfer> GetTransferByIdAsync(int transferId)
        {
            var transfer = await mediator.Send(new GetTransferByIdQuery() { TransferId = transferId });

            return transfer;
        }

        [HttpPost]
        public async Task<Transfer> AddTransferAsync(CreateTransferCommand transfer)
        {
            var transfers = await mediator.Send(transfer);

            return transfers;
        }
    }
}
