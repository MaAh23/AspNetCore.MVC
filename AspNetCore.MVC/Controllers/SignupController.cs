using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.MVC.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
