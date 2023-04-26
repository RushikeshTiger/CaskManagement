using CaskInventory.Data.Entities;
using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.cask.Get
{
    public class GetCaskListHandler : IRequestHandler<GetCaskListQuery, List<Cask>>
    {
        private readonly ICaskRepository _caskRepository;

        public GetCaskListHandler(ICaskRepository caskRepository)
        {
            _caskRepository = caskRepository;
        }
        public async Task<List<Cask>> Handle(GetCaskListQuery request, CancellationToken cancellationToken)
        {
            return (List<Cask>)await _caskRepository.GetCasks();
        }
    }
}
