using CaskInventory.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.caskFilling.Get
{
    public class GetCaskFillingByIdQuery : IRequest<Caskfilling>
    {
        public int CfId { get; set; }
    }
}
