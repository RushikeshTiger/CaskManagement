using CaskInventory.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.supplier.Get
{
    public class GetSupplierListQuery : IRequest<List<Supplier>>
    {
    }
}
