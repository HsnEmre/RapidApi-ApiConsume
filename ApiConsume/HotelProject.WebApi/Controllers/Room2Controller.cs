using AutoMapper;
using HotelProject.BussinessLayer.Abstract;
using HotelProject.DtoLayer.DTO_s.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomsService;
        private readonly IMapper _mapper;
        public Room2Controller(IRoomService roomservice, IMapper mapper)
        {
            _mapper = mapper;
            _roomsService = roomservice;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = _roomsService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(RoomAddDtos dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(dto);
            _roomsService.TInsert(values);


            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto updateRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(updateRoomDto);
            _roomsService.TUpdate(values);
            return Ok("Sistem başarıyla güncellendi");
        }

    }
}
