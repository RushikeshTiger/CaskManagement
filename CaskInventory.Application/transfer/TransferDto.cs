using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.transfer
{
    public class TransferDto
    {
        public int TransferId { get; set; }
        public int? CaskId { get; set; }

        public DateTime? TransferDate { get; set; }

        public int? FromClientId { get; set; }

        public int? ToClientId { get; set; }
    }
}
