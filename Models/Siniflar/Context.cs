
using Microsoft.EntityFrameworkCore;//data entity ekliyor videoda

namespace KisiselWebSayfasi.Models.Siniflar
{
    public class Context:DbContext
    { 
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Ikonlar> Ikonlars { get; set; }


    }
}
