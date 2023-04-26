using CaskInventory.Data.Entities;
using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.salesperson.Get
{
    public sealed class GetSalespersonListHandler : IRequestHandler<GetSalespersonListQuery, List<Salesperson>>
    {

        private readonly ISalespersonRepository _salespersonRepository;

        public GetSalespersonListHandler(ISalespersonRepository salespersonRepository)
        {
            _salespersonRepository = salespersonRepository;
        }
        public async Task<List<Salesperson>> Handle(GetSalespersonListQuery request, CancellationToken cancellationToken)
        {
            return (List<Salesperson>)await _salespersonRepository.GetSalespersons();
        }
    }
}
