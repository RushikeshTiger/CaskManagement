using CaskInventory.Data.Entities;
using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.supplier.Get
{
    public sealed class GetSupplierListHandler : IRequestHandler<GetSupplierListQuery, List<Supplier>>
    {
        private readonly ISupplierRepository _supplierRepository;

        public GetSupplierListHandler(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        public async Task<List<Supplier>> Handle(GetSupplierListQuery request, CancellationToken cancellationToken)
        {
            return (List<Supplier>)await _supplierRepository.GetSuppliers();
        }
    }
}
