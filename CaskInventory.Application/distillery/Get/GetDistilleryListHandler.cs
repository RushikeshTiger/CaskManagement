using CaskInventory.Data.Entities;
using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.distillery.Get
{
    public sealed class GetDistilleryListHandler : IRequestHandler<GetDistilleryListQuery, List<Distillery>>
    {
        private readonly IDistilleryRepository _distilleryRepository;

        public GetDistilleryListHandler(IDistilleryRepository distilleryRepository)
        {
            _distilleryRepository = distilleryRepository;
        }
        public async Task<List<Distillery>> Handle(GetDistilleryListQuery request, CancellationToken cancellationToken)
        {
            return (List<Distillery>)await _distilleryRepository.GetDistilleries();
        }
    }
}
