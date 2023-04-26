using CaskInventory.Application.supplier.Get;
using CaskInventory.Data.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaskInventory.Api.Endpoints.SupplierEndpoints
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierEndpoints : ControllerBase
    {
        private readonly IMediator mediator;

        public SupplierEndpoints(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet]
        public async Task<List<Supplier>> GetSupplierListAsync()
        {
            var supplier = await mediator.Send(new GetSupplierListQuery());

            return supplier;
        }
    }
}
