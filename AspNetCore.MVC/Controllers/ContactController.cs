using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.MVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
