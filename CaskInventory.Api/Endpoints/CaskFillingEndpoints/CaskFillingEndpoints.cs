using CaskInventory.Application.caskFilling.Create;
using CaskInventory.Application.caskFilling.Get;
using CaskInventory.Data.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaskInventory.Api.Endpoints.CaskFillingEndpoints
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaskFillingEndpoints : ControllerBase
    {
        private readonly IMediator mediator;

        public CaskFillingEndpoints(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Caskfilling>> GetCaskFillingListAsync()
        {
            var Caskfilling = await mediator.Send(new GetCaskFillingListQuery());

            return Caskfilling;
        }

        [HttpGet("caskId")]
        public async Task<Caskfilling> GetCaskByIdAsync(int cfId)
        {
            var caskfilling = await mediator.Send(new GetCaskFillingByIdQuery() { CfId = cfId });

            return caskfilling;
        }


        [HttpPost]
        public async Task<Caskfilling> AddCaskAsync(CreateCaskFillingCommand caskfilling)
        {
            var caskfillings = await mediator.Send(caskfilling);

            return caskfillings;
        }
    }
}
