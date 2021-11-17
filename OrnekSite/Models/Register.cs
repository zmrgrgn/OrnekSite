using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrnekSite.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Soyadınız")]
        public string Surname { get; set; }

        [Required]
        [DisplayName("Kullacını adı")]

        public string Username { get; set; }

        [Required]
        [DisplayName("Mail")]
        [EmailAddress(ErrorMessage ="Geçersiz mail adresi")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Şifreler aynı değil.")]
        [DisplayName("Şifre Tekrar")]
        public string Repassword { get; set; }
    }
}