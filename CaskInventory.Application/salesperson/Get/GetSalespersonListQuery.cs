using CaskInventory.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.salesperson.Get
{
    public class GetSalespersonListQuery : IRequest<List<Salesperson>>
    {
    }
}
