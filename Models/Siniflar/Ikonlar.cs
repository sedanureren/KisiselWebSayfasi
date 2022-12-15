﻿using System.ComponentModel.DataAnnotations;

namespace KisiselWebSayfasi.Models.Siniflar
{
    public class Ikonlar
    {
        [Key]
        public int Id { get; set; }
        public string Ikon { get; set; }
        public string Link { get; set; }
    }
}
