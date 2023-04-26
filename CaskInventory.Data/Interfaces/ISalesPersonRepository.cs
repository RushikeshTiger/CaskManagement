using CaskInventory.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Data.Interfaces
{
    public interface ISalespersonRepository
    {
        Task<IEnumerable<Salesperson>> GetSalespersons();

        Task<Salesperson> GetSalesperson(int SalespersonId);

        Task<Salesperson> AddSalesperson(Salesperson salesperson);

    }  
}
