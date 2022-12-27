using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace KisiselWebSayfasi.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        [EmailAddress]
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
