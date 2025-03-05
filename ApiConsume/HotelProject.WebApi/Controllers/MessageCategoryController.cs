using HotelProject.BussinessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageCategoryController : ControllerBase
    {
        private readonly IMessageCategoryService _messageCategoryService;

        public MessageCategoryController(IMessageCategoryService service)
        {
            _messageCategoryService = service;
        }


        [HttpGet]
        public IActionResult MessageCategoryList()
        {
            var values = _messageCategoryService.TGetList();
            return Ok(values);
        }


        [HttpPost]
        public IActionResult AddMessageCategory(MessageCategory category)
        {
            _messageCategoryService.TInsert(category);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessageCategory(int id)
        {
            var values = _messageCategoryService.TGetById(id);
            _messageCategoryService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateMessageCategory(MessageCategory category)
        {
            _messageCategoryService.TUpdate(category);
            return Ok();

        }


        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var values = _messageCategoryService.TGetById(id);
            return Ok(values);
        }



    }
}
