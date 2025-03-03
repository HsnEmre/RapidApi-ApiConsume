﻿using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.SendMessageDto;
using HotelProject.WebUI.Models.StaffModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminContactController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:35160/api/Contact");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> SendBox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:35160/api/SendMessage");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSendBoxDto>>(jsonData);
                return View(values);
            }
            return View();

            
        }


        [HttpGet]
        public IActionResult AddSendMessage()
        {
            return View();

        }


        [HttpPost]
        public async Task<IActionResult> AddSendMessage(CreateSendMessage model)
        {
            model.SenderMail = "admin@gmail.com";
            model.SenderName = "admin";
            model.Date = DateTime.Parse(DateTime.Now.ToShortDateString());


            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:35160/api/SendMessage", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }



        public PartialViewResult SideBarAdmibContactPartial()
        {
            return PartialView();
        }
        public PartialViewResult SideBarAdmibContactCategoryPartial()
        {
            return PartialView();
        }


        public async Task<IActionResult> MesssageDetailsBySendBox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:35160/api/SendMessage/id?/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetMessageByIdDto>(jsonData);
                return View(values);
            }


            return View();
        }

        public async Task<IActionResult> MesssageDetailsByInbox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:35160/api/Contact/id?/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<InboxContactDto>(jsonData);
                return View(values);
            }


            return View();
        }
    }
}
