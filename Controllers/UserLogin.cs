using Microsoft.AspNetCore.Mvc;

namespace KisiselWebSayfasi.Controllers
{
    public class UserLogin : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
