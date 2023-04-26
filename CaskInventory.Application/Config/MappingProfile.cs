using AutoMapper;
using CaskInventory.Application.cask;
using CaskInventory.Data.Entities;
using Mapster;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities = CaskInventory.Data.Entities;

namespace CaskInventory.Application.Config
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Cask, CaskDto>()
                .ForMember(c => c.CaskDescript, opt => opt.MapFrom(x => x.CaskDescription))
                .ForMember(c => c.CaskType, opt => opt.MapFrom(x => x.CaskType));

        }




        //public static void UseMapperConfig(this IApplicationBuilder builder, TypeAdapterConfig config)
        //{
        //    if (builder == null) throw new ArgumentNullException(nameof(builder));


        //    //config.NewConfig<entities.Item, ItemsDto>();

        //    config.NewConfig<entities.Cask, CaskDto>();
        //}
    }
}
