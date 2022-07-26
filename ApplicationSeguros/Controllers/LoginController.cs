using Microsoft.AspNetCore.Mvc;

namespace ApplicationSeguros.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
