using CaskInventory.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Data.Interfaces
{
    public interface IDistilleryRepository
    {
        Task<IEnumerable<Distillery>> GetDistilleries();

        Task<Distillery> GetDistillery(int DistilleryId);

        Task<Distillery> AddDistillery(Distillery distillery);

        Task<int> UpdateDistillery(Distillery distillery);

        Task<int> DeleteDistillery(int DistilleryId);
    }
}
