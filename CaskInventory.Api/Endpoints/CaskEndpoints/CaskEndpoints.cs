using CaskInventory.Application.cask;
using CaskInventory.Application.cask.Create;
using CaskInventory.Application.cask.Delete;
using CaskInventory.Application.cask.Get;
using CaskInventory.Application.cask.Update;
using CaskInventory.Data.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaskInventory.Api.Endpoints.CaskEndpoints
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaskEndpoints : ControllerBase
    {
        private readonly IMediator mediator;

        public CaskEndpoints(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<Cask> AddCaskAsync(CreateCaskCommand cask)
        {
            var casks = await mediator.Send(cask);

            return casks;
        }

        [HttpGet]
        public async Task<List<Cask>> GetCaskListAsync()
        {
            var result = await mediator.Send(new GetCaskListQuery());

            return result;
        }

        //public static async Task<IResult> GetCasks(ISender sender)
        //{
        //    var result = await sender.Send(new GetCaskListQuery { });
        //    return Results.Ok(result);
        //}

        [HttpGet("caskId")]
        public async Task<Cask> GetCaskByIdAsync(int caskId)
        {
            var cask = await mediator.Send(new GetCaskByIdQuery() { CaskId = caskId });

            return cask;
        }

        [HttpGet("caskType")]
        public async Task<Cask> GetCaskByTypeAsync(string caskType)
        {
            var cask = await mediator.Send(new GetCaskByTypeQuery() { CaskType = caskType });

            return cask;
        }


        [HttpPut("{id}")]
        public async Task<int> UpdateCaskAsync(UpdateCaskCommand cask)
        {
            var isCaskUpdated = await mediator.Send(cask);
            return isCaskUpdated;
        }


        [HttpDelete]
        public async Task<int> DeleteCaskAsync(int Id)
        {
            return await mediator.Send(new DeleteCaskCommand() { CaskId = Id });
        }
    }
}
