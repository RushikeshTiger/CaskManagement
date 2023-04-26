using CaskInventory.Data.Interfaces;
using CaskInventory.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Nodes;

namespace CaskInventory.Data.Repositories
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly CaskdbContext _dbContext;

        public PurchaseRepository(CaskdbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Purchase> AddPurchase(Purchase purchase)
        {
            var result = _dbContext.Purchases.Add(purchase);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeletePurchase(int PurchaseId)
        {
            var filteredData = _dbContext.Purchases.Where(x => x.PurchaseId == PurchaseId).FirstOrDefault();
            _dbContext.Purchases.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Purchase> GetPurchase(int PurchaseId)
        {
            return await _dbContext.Purchases.Where(x => x.PurchaseId == PurchaseId).FirstOrDefaultAsync();
        }

        public Task<Purchase> GetPurchaseByClientName(string ClientName)
        {
            throw new NotImplementedException();
        }

        //public async Task<Purchase> GetPurchaseByClientName(string ClientName)
        //{
        //    var purchasesbyclientName = _dbContext.Purchases
        //                                           .Join(_dbContext.Clients, p => p.ClientId, c => c.ClientId, 
        //                                           (p, c) => new 
        //                                           { 
        //                                               Purchase = p, Client = c 
        //                                           })
        //                                           .Where(pc => pc.Client.ClientName == ClientName)
        //                                           .Select(pc => new
        //                                           {
        //                                               pc.Purchase.PurchaseId,
        //                                               pc.Purchase.ClientId,
        //                                               pc.Client.ClientName
        //                                           })
        //                                            .FirstOrDefault();

        //    var result = new Purchase();
        //    result.PurchaseId = purchasesbyclientName.PurchaseId;
        //    result.ClientId = purchasesbyclientName.ClientId;
        //    result.Client.ClientName = purchasesbyclientName.ClientName;


        //var query = _dbContext.Purchases
        //            .Join(_dbContext.Clients, p => p.ClientId, c => c.ClientId, (p, c) => new { p, c })                        
        //             .Select(x => new
        //             {                       
        //                 x.p.ClientId,
        //                 x.p.PurchaseId,
        //                 x.c.ClientName
        //             })
        //             .FirstOrDefault();



        //return await Json(purchasesbyclientName.ToList());

        //    return result;


        //}

        public async Task<IEnumerable<Purchase>> GetPurchases()
        {
            return (IEnumerable<Purchase>)await _dbContext.Purchases.ToListAsync();
        }

        public async Task<int> UpdatePurchase(Purchase purchase)
        {
            _dbContext.Purchases.Update(purchase);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
