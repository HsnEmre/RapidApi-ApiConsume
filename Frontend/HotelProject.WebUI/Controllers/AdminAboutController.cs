﻿using HotelProject.WebUI.Dtos.AboutDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminAboutController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public AdminAboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task< IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:35160/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutdto>>(jsondata);
                return View(values);
            }
            return View();    
        
        }


        [HttpGet]
        public async Task<IActionResult> UpdateAbout(int id)
        {
            var client= _httpClientFactory.CreateClient();
            var responsemessage = await client
                 .GetAsync($"http://localhost:35160/api/About/{id}");
            if (responsemessage.IsSuccessStatusCode)
            {
                var jsondata = await responsemessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateAboutDto>(jsondata);
                return View(values);
            }
            return View();
        }


        //[HttpPost]
        //public async Task<IActionResult> UpdateAbout(UpdateAboutDto 
        //    model)
        //{
        //    var client=_httpClientFactory.CreateClient();
        //    var jsondata = JsonConvert.SerializeObject(model);
        //    StringContent stringcontent = new StringContent(jsondata, Encoding.UTF8, "application/json");

        //}


    }
}
