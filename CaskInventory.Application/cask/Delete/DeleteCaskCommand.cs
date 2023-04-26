using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.cask.Delete
{
    public class DeleteCaskCommand : IRequest<int>
    {
        public int CaskId { get; set; }
    }
}
