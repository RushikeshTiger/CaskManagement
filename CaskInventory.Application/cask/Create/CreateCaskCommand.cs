using CaskInventory.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.cask.Create
{
    public class CreateCaskCommand : IRequest<Cask>
    {
        public string CaskType { get; set; }

        public string CaskDescription { get; set; }
    }
}
