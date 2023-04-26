using CaskInventory.Data.Entities;
using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CaskInventory.Application.cask.Create
{
    public sealed class CreateCaskHandler : IRequestHandler<CreateCaskCommand, Cask>
    {
        private readonly ICaskRepository _caskRepository;

        public CreateCaskHandler(ICaskRepository caskRepository)
        {
            _caskRepository = caskRepository;
        }

        public async Task<Cask> Handle(CreateCaskCommand command, CancellationToken cancellationToken)
        {
            var caskDetails = new Cask()
            {
                CaskType = command.CaskType,
                CaskDescription = command.CaskDescription,

            };

            return await _caskRepository.AddCask(caskDetails);
        }
    }
}
