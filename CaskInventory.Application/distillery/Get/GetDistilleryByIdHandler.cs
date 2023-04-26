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
    public sealed class GetDistilleryByIdHandler : IRequestHandler<GetDistilleryByIdQuery, Distillery>
    {
        private readonly IDistilleryRepository _distilleryRepository;

        public GetDistilleryByIdHandler(IDistilleryRepository distilleryRepository)
        {
            _distilleryRepository = distilleryRepository;
        }
        public async Task<Distillery> Handle(GetDistilleryByIdQuery query, CancellationToken cancellationToken)
        {
            return await _distilleryRepository.GetDistillery(query.DistilleryId);
        }
    }
}
