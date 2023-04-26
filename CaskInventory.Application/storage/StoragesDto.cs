using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Application.storage
{
    public class StoragesDto
    {
        public int StorageId { get; set; }
        public int? CaskId { get; set; }

        public string? StorageAnniversary { get; set; }

        public string? StorageInventorySent { get; set; }

        public string? StorageReminder { get; set; }
    }
}
