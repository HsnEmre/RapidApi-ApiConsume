﻿using HotelProject.WebUI.Dtos.AboutDtos;
using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _AboutPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _AboutPartial( IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory=httpClientFactory;
        }



        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:35160/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ResultAboutdto>>(jsondata);
                return View(values);
            }
            return View();
        }
    }
}
