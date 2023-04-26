using CaskInventory.Data.Entities;
using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CaskInventory.Application.cask.Get
{
    public class GetCaskByTypeHandler : IRequestHandler<GetCaskByTypeQuery, Cask>
    {
        private readonly ICaskRepository _caskRepository;

        public GetCaskByTypeHandler(ICaskRepository caskRepository)
        {
            _caskRepository = caskRepository;
        }

        public async Task<Cask> Handle(GetCaskByTypeQuery request, CancellationToken cancellationToken)
        {
            return await _caskRepository.GetCask(request.CaskType);
        }
    }
}
