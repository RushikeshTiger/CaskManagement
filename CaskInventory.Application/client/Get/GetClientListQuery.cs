using CaskInventory.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.client.Get
{
    public class GetClientListQuery : IRequest<List<Client>>
    {
    }
}
