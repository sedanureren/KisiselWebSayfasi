﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace KisiselWebSayfasi.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
