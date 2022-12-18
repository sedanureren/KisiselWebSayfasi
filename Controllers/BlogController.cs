using Microsoft.AspNetCore.Mvc;
using KisiselWebSayfasi.Models.Siniflar;

namespace KisiselWebSayfasi.Controllers
{
    public class BlogController : Controller
    {
        Context c=new Context ();
		BlogYorum blogYorum = new BlogYorum();

		public IActionResult Index()
        {
            // var bloglar = c.Bloglars.ToList();
            blogYorum.Deger1 = c.Bloglars.ToList();
			blogYorum.Deger3 = c.Bloglars.OrderByDescending(x => x.Id).Take(3).ToList();

			return View(blogYorum);
        }
		public ActionResult BlogDetay(int id)
        {
            blogYorum.Deger1 = c.Bloglars.Where(x => x.Id == id).ToList();
			blogYorum.Deger2 = c.Yorumlars.Where(x => x.BlogId == id).ToList();
			//   var blogbul=c.Bloglars.Where(x=>x.Id==id).ToList();
			return View(blogYorum);
        }
    }
}
