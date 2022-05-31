using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace PartyInvites.Models
{
    public class GuestContext : DbContext
    {
        public DbSet<GuestResponse> GuestResponse { get; set; }
    }

    public class GuestResponse
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите свое имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите свой адресс")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Вы ввели некорректный адресс")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите телефон")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Пожалуйста, укажите, примите ли участие в вечеринке")]
        public string Attend { get; set; }
    }
}