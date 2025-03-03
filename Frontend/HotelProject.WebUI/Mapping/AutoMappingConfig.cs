﻿using AutoMapper;
using HotelProject.EntityLayer;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDtos;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.SubscribeDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMappingConfig : Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
            CreateMap<ResultAboutdto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<ResultStaffDto, Staff>().ReverseMap();
            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto,Booking>().ReverseMap();
            CreateMap<CreateGuestDto,Guest>().ReverseMap();
            CreateMap<UpdateGuestDto,Guest>().ReverseMap();
        }
    }
}
