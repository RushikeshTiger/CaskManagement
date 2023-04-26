using CaskInventory.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Data.Interfaces
{
    public interface ITransferRepository
    {
        Task<Transfer> GetTransfer(int TransferId);

        Task<IEnumerable<Transfer>> GetTransfers();

        Task<Transfer> AddTransfer(Transfer transfer);
    }
}
