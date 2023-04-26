//using CaskInventory.Application.User.CreateUser;

using CaskInventory.Application.user.Create;
using CaskInventory.Application.user.Login;
using CaskInventory.Application.User;
//using CaskInventory.Common.Security.Identity;
using CaskInventory.Data.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CaskInventory.Api.Endpoints.UserEndpoints
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Register(CreateUserCommand request)
        {
            var result = await mediator.Send(request);
            return new JsonResult(result);
        }

        //[HttpPost]
        //public async Task<IResult> Login(CreateLoginCommand request, ISender sender)
        //{
        //    var result = await sender.Send(request);
        //    return Results.Ok(result);
        //}

    }
}
