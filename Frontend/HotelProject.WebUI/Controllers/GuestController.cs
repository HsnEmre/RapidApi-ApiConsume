﻿using HotelProject.WebUI.Dtos.GuestDto;
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
    public class GuestController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;
        public GuestController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync("http://localhost:35160/api/Guest");
            if (responsemessage.IsSuccessStatusCode)
            {
                var jsondata = await responsemessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultGuestDto>>(jsondata);
                return View(values);
            }

            return View();
        }

        [HttpGet]
        public IActionResult AddGuest()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGuest(CreateGuestDto model)
        {
            if (ModelState.IsValid)
            {


                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("http://localhost:35160/api/Guest", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            else
            {
                return View();
            }

        }


        public async Task<IActionResult> DeleteGuest(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:35160/api/Guest/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> UpdateGuest(int id)
        {


            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:35160/api/Guest/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateGuestDto>(jsonData);
                return View(values);
            }
            return View();


        }


        [HttpPost]
        public async Task<IActionResult> UpdatGuest(UpdateGuestDto guestDto)
        {

            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsondata = JsonConvert.SerializeObject(guestDto);
                StringContent stringContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync("http://localhost:35160/api/Guest", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            return View();

        }






    }
}
