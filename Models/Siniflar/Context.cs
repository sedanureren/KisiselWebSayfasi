using Microsoft.EntityFrameworkCore;//data entity ekliyor videoda
namespace KisiselWebSayfasi.Models.Siniflar
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CK4MQ1B\\SQLEXPRESS;database=KisiselWebSayfasiDb; integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Ikonlar> Ikonlars { get; set; }
        public DbSet<KullaniciGiris> KullaniciGiris { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<Sehrim> Sehrims { get; set; }
        public DbSet<Blog> Bloglars { get; set; }




    }
}
