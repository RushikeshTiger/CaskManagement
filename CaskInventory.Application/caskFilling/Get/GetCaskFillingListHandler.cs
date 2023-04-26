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
    public sealed class GetCaskFillingListHandler : IRequestHandler<GetCaskFillingListQuery, List<Caskfilling>>
    {
        private readonly ICaskFillingRepository _caskFillingRepository;

        public GetCaskFillingListHandler(ICaskFillingRepository caskFillingRepository)
        {
            _caskFillingRepository = caskFillingRepository;
        }
        public async Task<List<Caskfilling>> Handle(GetCaskFillingListQuery request, CancellationToken cancellationToken)
        {
            return (List<Caskfilling>)await _caskFillingRepository.GetCaskfillings();
        }
    }
}
