using CaskInventory.Application.User;
using CaskInventory.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.user.Create
{
    public record CreateUserCommand(string username, string password) : IRequest<UserDto>;
}
