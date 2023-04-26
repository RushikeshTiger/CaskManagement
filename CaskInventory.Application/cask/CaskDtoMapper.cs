using CaskInventory.Data;
using CaskInventory.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CaskInventory.Application.cask
{
    public class CaskDtoMapper
    {
        public static CaskDto MapToDto(CaskInventory.Data.Entities.Cask cask)
        {
            return new CaskDto()
            {
                //CaskId = cask.CaskId,
                //CaskType = cask.CaskType,
                //CaskDescription = cask.CaskDescription

            };

        }
    }
}
