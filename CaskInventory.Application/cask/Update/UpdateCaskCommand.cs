using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.cask.Update
{
    public class UpdateCaskCommand : IRequest<int>
    {
        public int CaskId { get; set; }
        public string CaskType { get; set; }
        public string CaskDescription { get; set; }
    }
}
