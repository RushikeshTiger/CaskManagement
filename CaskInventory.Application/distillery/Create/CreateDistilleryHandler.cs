using CaskInventory.Data.Entities;
using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.distillery.Create
{
    public sealed class CreateDistilleryHandler : IRequestHandler<CreateDistilleryCommand, Distillery>
    {
        private readonly IDistilleryRepository _distilleryRepository;

        public CreateDistilleryHandler(IDistilleryRepository distilleryRepository)
        {
            _distilleryRepository = distilleryRepository;
        }

        public async Task<Distillery> Handle(CreateDistilleryCommand command, CancellationToken cancellationToken)
        {
            var distilleryDetails = new Distillery()
            {
                DistilleryName = command.DistilleryName,
                DistilleryIlocation = command.DistilleryIlocation

            };

            return await _distilleryRepository.AddDistillery(distilleryDetails);
        }
    }
}
