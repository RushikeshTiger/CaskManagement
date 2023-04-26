using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.User
{
    public readonly record struct UserDto(string Username, string Token);
}
