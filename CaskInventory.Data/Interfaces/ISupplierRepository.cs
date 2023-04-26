using CaskInventory.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Data.Interfaces
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetSuppliers();

        Task<Supplier> GetSupplier(int SupplierId);

        Task<Supplier> AddSupplier(Supplier supplier);
    }
}
