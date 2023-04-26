using CaskInventory.Data.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.cask.Delete
{
    public class DeleteCaskHandler : IRequestHandler<DeleteCaskCommand, int>
    {
        private readonly ICaskRepository _caskRepository;

        public DeleteCaskHandler(ICaskRepository caskRepository)
        {
            _caskRepository = caskRepository;
        }
        public async Task<int> Handle(DeleteCaskCommand command, CancellationToken cancellationToken)
        {
            var student = await _caskRepository.GetCask(command.CaskId);
            if (student == null)
                return default;

            return await _caskRepository.DeleteCask(student.CaskId);
        }
    }
}
