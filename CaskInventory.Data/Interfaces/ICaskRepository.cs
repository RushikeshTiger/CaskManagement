using CaskInventory.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Data.Interfaces
{
    public interface ICaskRepository
    {
        Task<IEnumerable<Cask>> GetCasks();

        Task<Cask> GetCask(int CaskId);

        Task<Cask> GetCask(string CaskType);

        Task<Cask> AddCask(Cask cask);

        Task<int> UpdateCask(Cask cask);

        Task<int> DeleteCask(int CaskId);
    }
}
