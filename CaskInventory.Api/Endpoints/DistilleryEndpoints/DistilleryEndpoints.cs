using CaskInventory.Application.distillery.Create;
using CaskInventory.Application.distillery.Delete;
using CaskInventory.Application.distillery.Get;
using CaskInventory.Application.distillery.Update;
using CaskInventory.Data.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaskInventory.Api.Endpoints.DistilleryEndpoints
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistilleryEndpoints : ControllerBase
    {
        private readonly IMediator mediator;

        public DistilleryEndpoints(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Distillery>> GetDistillerytListAsync()
        {
            var distillery = await mediator.Send(new GetDistilleryListQuery());

            return distillery;
        }

        [HttpGet("distilleryId")]
        public async Task<Distillery> GetDistilleryByIdAsync(int distilleryId)
        {
            var distillery = await mediator.Send(new GetDistilleryByIdQuery() { DistilleryId = distilleryId });

            return distillery;
        }


        [HttpPost]
        public async Task<Distillery> AddCaskAsync(CreateDistilleryCommand distillery)
        {
            var distilleries = await mediator.Send(distillery);

            return distilleries;
        }


        [HttpPut("{id}")]
        public async Task<int> UpdateDistilleryAsync(UpdateDistilleryCommand distillery)
        {
            var isDistilleryUpdated = await mediator.Send(distillery);
            return isDistilleryUpdated;
        }


        [HttpDelete]
        public async Task<int> DeleteDistilleryAsync(int Id)
        {
            return await mediator.Send(new DeleteDistilleryCommand() { DistilleryId = Id });
        }
    }
}
