﻿using System.ComponentModel.DataAnnotations;

namespace Traversal.WEB.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen mailinizi giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen resim seçiniz")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lütfen telefon numaranızı giriniz")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password", ErrorMessage="şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen cinsiyetinizi giriniz")]
        public string Gender { get; set; }
    }
}
