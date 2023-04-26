using CaskInventory.Application.client.Create;
using CaskInventory.Application.client.Delete;
using CaskInventory.Application.client.Get;
using CaskInventory.Application.client.Update;
using CaskInventory.Data.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaskInventory.Api.Endpoints.ClientEndpoints
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientEndpoints : ControllerBase
    {
        private readonly IMediator mediator;

        public ClientEndpoints(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet]
        public async Task<List<Client>> GetClientListAsync()
        {
            var client = await mediator.Send(new GetClientListQuery());

            return client;
        }

        [HttpGet("clientId")]
        public async Task<Client> GetClientByIdAsync(int clientId)
        {
            var client = await mediator.Send(new GetClientByIdQuery() { ClientId = clientId });

            return client;
        }

        [HttpPost]
        public async Task<Client> AddCaskAsync(CreateClientCommand client)
        {            
            var clients = await mediator.Send(client);

            return clients;
        }


        [HttpPut("{id}")]
        public async Task<int> UpdateClientAsync(UpdateClientCommand client)
        {
            var isClientUpdated = await mediator.Send(client);
            return isClientUpdated;
        }

        [HttpDelete]
        public async Task<int> DeleteClientAsync(int Id)
        {
            return await mediator.Send(new DeleteClientCommand() { ClientId = Id });
        }
    }
}
