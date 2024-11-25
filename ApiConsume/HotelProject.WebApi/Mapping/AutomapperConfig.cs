using AutoMapper;
using HotelProject.DtoLayer.DTO_s.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutomapperConfig : Profile
    {

        public AutomapperConfig()
        {
            CreateMap<RoomAddDtos, Room>().ReverseMap();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
