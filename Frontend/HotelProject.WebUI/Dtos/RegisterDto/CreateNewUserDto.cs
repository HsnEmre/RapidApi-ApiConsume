﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad Alanı gereklidir")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Soyad alanı gerekli")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Kullanıcı adı gereklidir")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Mail alanı gereklidir")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Şifre alanı gereklidir")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrar alanı gereklidir")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }

    }
}
