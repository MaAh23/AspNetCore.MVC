using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.MVC.Controllers
{
    public class SigninController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
