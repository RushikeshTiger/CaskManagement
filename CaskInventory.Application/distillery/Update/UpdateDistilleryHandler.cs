using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.distillery.Update
{
    public class UpdateDistilleryHandler : IRequestHandler<UpdateDistilleryCommand, int>
    {
        private readonly IDistilleryRepository _distilleryRepository;

        public UpdateDistilleryHandler(IDistilleryRepository distilleryRepository)
        {
            _distilleryRepository = distilleryRepository;
        }
        public async Task<int> Handle(UpdateDistilleryCommand command, CancellationToken cancellationToken)
        {
            var distillery = await _distilleryRepository.GetDistillery(command.DistilleryId);
            if (distillery == null)
                return default;

            distillery.DistilleryName = command.DistilleryName;
            distillery.DistilleryIlocation = command.DistilleryIlocation;


            return await _distilleryRepository.UpdateDistillery(distillery);
        }
    }
}
