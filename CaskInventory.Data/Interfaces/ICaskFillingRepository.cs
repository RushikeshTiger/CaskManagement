using CaskInventory.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Data.Interfaces
{
    public interface ICaskFillingRepository
    {
        Task<IEnumerable<Caskfilling>> GetCaskfillings();

        Task<Caskfilling> GetCaskfilling(int CfId);

        Task<Caskfilling> AddCaskfilling(Caskfilling caskfilling);

        
    }
}
