using CaskInventory.Data.Interfaces;
using CaskInventory.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CaskInventory.Data.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {

        private readonly CaskdbContext _dbContext;

        public SupplierRepository(CaskdbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Supplier> AddSupplier(Supplier supplier)
        {
            var result = _dbContext.Suppliers.Add(supplier);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Supplier> GetSupplier(int SupplierId)
        {
            return await _dbContext.Suppliers.Where(x => x.SupplierId == SupplierId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Supplier>> GetSuppliers()
        {
            return (IEnumerable<Supplier>)await _dbContext.Suppliers.ToListAsync();
        }
    }
}
