using HotelProject.BussinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;
        public SubscribeController(ISubscribeService service)
        {
            _subscribeService = service;
        }


        [HttpGet]
        public IActionResult SubscribeceList()
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddSubscribe(Subscribe service)
        {
            _subscribeService.TInsert(service);
            return Ok();
        }


        [HttpDelete]
        public IActionResult DeleteSubscribe(int idservice)
        {
            var id = _subscribeService.TGetById(idservice);

            _subscribeService.TDelete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe service)
        {
            _subscribeService.TUpdate(service);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int idservice)
        {
            var values = _subscribeService.TGetById(idservice);
            return Ok(values);
        }
    }
}
