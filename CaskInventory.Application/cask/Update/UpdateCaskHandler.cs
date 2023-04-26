using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.cask.Update
{
    public class UpdateCaskHandler : IRequestHandler<UpdateCaskCommand, int>
    {
        private readonly ICaskRepository _caskRepository;

        public UpdateCaskHandler(ICaskRepository caskRepository)
        {
            _caskRepository = caskRepository;
        }
        public async Task<int> Handle(UpdateCaskCommand command, CancellationToken cancellationToken)
        {
            var cask = await _caskRepository.GetCask(command.CaskId);
            if (cask == null)
                return default;

            cask.CaskType = command.CaskType;
            cask.CaskDescription = command.CaskDescription;


            return await _caskRepository.UpdateCask(cask);
        }
    }
}
