using CaskInventory.Application.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.user.Login
{
    public class CreateLoginCommand : IRequest<UserDto>
    {
        public string Email { get; init; }
        public string Password { get; init; }
    }
}
