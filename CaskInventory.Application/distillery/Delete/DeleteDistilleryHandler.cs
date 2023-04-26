using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.distillery.Delete
{
    public sealed class DeleteDistilleryHandler : IRequestHandler<DeleteDistilleryCommand, int>
    {
        private readonly IDistilleryRepository _distilleryRepository;

        public DeleteDistilleryHandler(IDistilleryRepository distilleryRepository)
        {
            _distilleryRepository = distilleryRepository;
        }
        public async Task<int> Handle(DeleteDistilleryCommand command, CancellationToken cancellationToken)
        {
            var distillery = await _distilleryRepository.GetDistillery(command.DistilleryId);
            if (distillery == null)
                return default;

            return await _distilleryRepository.DeleteDistillery(distillery.DistilleryId);
        }
    }
}
