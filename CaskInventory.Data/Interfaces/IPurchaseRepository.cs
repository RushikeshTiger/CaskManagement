using CaskInventory.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Data.Interfaces
{
    public interface IPurchaseRepository
    {
        Task<IEnumerable<Purchase>> GetPurchases();

        Task<Purchase> GetPurchase(int PurchaseId); 

        Task<Purchase> GetPurchaseByClientName(string ClientName);

        Task<Purchase> AddPurchase(Purchase purchase);

        Task<int> UpdatePurchase(Purchase purchase);

        Task<int> DeletePurchase(int PurchaseId);

    }
}
