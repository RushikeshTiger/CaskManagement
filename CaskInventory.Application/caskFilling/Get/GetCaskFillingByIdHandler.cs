using CaskInventory.Data.Entities;
using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.caskFilling.Get
{
    public sealed class GetCaskFillingByIdHandler : IRequestHandler<GetCaskFillingByIdQuery, Caskfilling>
    {
        private readonly ICaskFillingRepository _caskFillingRepository;

        public GetCaskFillingByIdHandler(ICaskFillingRepository caskFillingRepository)
        {
            _caskFillingRepository = caskFillingRepository;
        }
        public async Task<Caskfilling> Handle(GetCaskFillingByIdQuery query, CancellationToken cancellationToken)
        {
            return await _caskFillingRepository.GetCaskfilling(query.CfId);
        }
    }
}
