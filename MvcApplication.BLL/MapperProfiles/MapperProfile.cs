using AutoMapper;
using MvcApplication.DAL.Models;
using MvcApplication.DTO.MvcModule;
using MvcApplication.DTO.SchemeModule;

namespace MvcApplication.BLL.MapperProfiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<SchemeDTO, Scheme>().ReverseMap();

            CreateMap<MvcDTO, MvcGeneration>().ReverseMap();
  
        }
    }
}
