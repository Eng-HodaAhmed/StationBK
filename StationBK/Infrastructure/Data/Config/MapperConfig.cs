using AutoMapper;
using StationBK.Core.Entities.company;
using StationBK.Core.Entities.Station;
using StationBK.Core.Models;
using StationBK.Core.Models.Station;

namespace StationBK.Infrastructure.Data.Config
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Purchace, PurchaceModel>().ReverseMap();
            CreateMap<Price, PriceModel>().ReverseMap();
            CreateMap<Deposit, DepositModel>().ReverseMap();
            CreateMap<OilPrice, OilPriceModel>().ReverseMap();
        }
    }
}
