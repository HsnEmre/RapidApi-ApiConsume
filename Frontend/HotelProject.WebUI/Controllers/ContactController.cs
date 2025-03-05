using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;
        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async IActionResult Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:35160/api/MessageCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultroomDto>>(jsondata);
                return View(values);
            }

            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateContactDto createContactDto)
        {
            createContactDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:35160/api/Contact", stringContent);
            return RedirectToAction("Index", "Default");

        }
    }
}
