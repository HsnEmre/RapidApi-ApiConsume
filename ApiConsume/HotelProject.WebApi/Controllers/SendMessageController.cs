using HotelProject.BussinessLayer.Abstract;
using HotelProject.DataAccessLayer.Migrations;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMesageService;

        public SendMessageController(ISendMessageService service)
        {
                _sendMesageService = service;
        }



        [HttpGet]
        public IActionResult SendMessageList()
        {
             var values=_sendMesageService.TGetList();
            return Ok(values);
        }


        [HttpPost]
        public IActionResult AddSendMessage(SendMessage sendMessage)
        {
            _sendMesageService.TInsert(sendMessage);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSendMessage(int id)
        {
            var values=_sendMesageService.TGetById(id);
            _sendMesageService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage sendMessage)
        {
            _sendMesageService.TUpdate(sendMessage);
            return Ok();
        }

        [HttpGet("id")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _sendMesageService.TGetById(id);
            return Ok(values);
        }

    }
}
