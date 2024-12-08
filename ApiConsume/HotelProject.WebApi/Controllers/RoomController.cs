using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {

        private readonly IRoomService _roomservice;

        public RoomController(IRoomService roomService)
        {
            _roomservice = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomservice.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomservice.TInsert(room);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomservice.TGetById(id);
            _roomservice.TInsert(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _roomservice.TUpdate(room);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var values = _roomservice.TGetById(id);
            return Ok(values);
        }
    }
}
