using System.ComponentModel.DataAnnotations;

namespace KisiselWebSayfasi.Models.Siniflar
{
    public class Sehrim
    {
        [Key]
        public int Id { get; set; }
        public string  FotoUrl { get; set; }
        public string Aciklama { get; set; }
    }
}
