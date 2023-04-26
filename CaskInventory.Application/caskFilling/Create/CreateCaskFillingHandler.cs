using CaskInventory.Data.Entities;
using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.caskFilling.Create
{
    public sealed class CreateCaskFillingHandler : IRequestHandler<CreateCaskFillingCommand, Caskfilling>
    {
        private readonly ICaskFillingRepository _caskFillingRepository;

        public CreateCaskFillingHandler(ICaskFillingRepository caskFillingRepository)
        {
            _caskFillingRepository = caskFillingRepository;
        }

        public async Task<Caskfilling> Handle(CreateCaskFillingCommand command, CancellationToken cancellationToken)
        {
            var caskFillingDetails = new Caskfilling()
            {
                DistilleryId = command.DistilleryId,
                CaskId = command.CaskId,
                Rlaola = command.Rlaola,
                Abv = command.Abv,
                CaskPrice = command.CaskPrice,
                BulkLiture = command.BulkLiture,
                Region = command.Region,
                FillingDate = command.FillingDate

            };

            return await _caskFillingRepository.AddCaskfilling(caskFillingDetails);


        }
    }
}
