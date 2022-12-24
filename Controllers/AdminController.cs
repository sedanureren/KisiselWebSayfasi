using Microsoft.AspNetCore.Mvc;
using KisiselWebSayfasi.Models.Siniflar;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace KisiselWebSayfasi.Controllers
{
    public class AdminController : Controller
    {
        Context c=new Context();
        public IActionResult Index()
        {
            var degerler = c.Bloglars.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Bloglars.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b=c.Bloglars.Find(id);
            c.Bloglars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var blog = c.Bloglars.Find(id);
            return View("BlogGetir", blog);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blog = c.Bloglars.Find(b.Id);
            blog.Aciklama = b.Aciklama;
            blog.Baslik = b.Baslik;
            blog.Tarih = b.Tarih;
            blog.BlogImage = b.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AdminLogin(Admin admin)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.KullaniciAdi == admin.KullaniciAdi && x.Sifre == admin.Sifre);
            if (bilgiler != null)
            {
                
            }
            return View();
        }
    }
}
    
