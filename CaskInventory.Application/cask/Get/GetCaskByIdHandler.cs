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
    public class GetCaskByIdHandler : IRequestHandler<GetCaskByIdQuery, Cask>
    {
        private readonly ICaskRepository _caskRepository;

        public GetCaskByIdHandler(ICaskRepository caskRepository)
        {
            _caskRepository = caskRepository;
        }
        public async Task<Cask> Handle(GetCaskByIdQuery query, CancellationToken cancellationToken)
        {
            return await _caskRepository.GetCask(query.CaskId);
        }
    }
}
