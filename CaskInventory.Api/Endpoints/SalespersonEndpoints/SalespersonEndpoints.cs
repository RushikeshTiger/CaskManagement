using CaskInventory.Application.salesperson.Get;
using CaskInventory.Data.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaskInventory.Api.Endpoints.SalespersonEndpoints
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalespersonEndpoints : ControllerBase
    {
        private readonly IMediator mediator;

        public SalespersonEndpoints(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet]
        public async Task<List<Salesperson>> GetSalespersonListAsync()
        {
            var salesperson = await mediator.Send(new GetSalespersonListQuery());

            return salesperson;
        }
    }
}
