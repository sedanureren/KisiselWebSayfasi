using KisiselWebSayfasi.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;

namespace KisiselWebSayfasi.Controllers
{
    public class AnaSayfaController : Controller
    {
        //get:Anasayfa
        Context c=new Context();
        public IActionResult Index()
        {
            //var deger=c.AnaSayfas.ToList();

            return View();
        }
    }
}
