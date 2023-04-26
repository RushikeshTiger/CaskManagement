using CaskInventory.Data.Interfaces;
using CaskInventory.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Data.Repositories
{
    public class TransferRepository : ITransferRepository
    {
        private readonly CaskdbContext _dbContext;

        public TransferRepository(CaskdbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Transfer> AddTransfer(Transfer transfer)
        {
            var result = _dbContext.Transfers.Add(transfer);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Transfer> GetTransfer(int TransferId)
        {
            return await _dbContext.Transfers.Where(x => x.TransferId == TransferId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Transfer>> GetTransfers()
        {
            return (IEnumerable<Transfer>)await _dbContext.Transfers.ToListAsync();
        }
    }
}
