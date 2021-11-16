using Microsoft.AspNetCore.Mvc;

namespace Trial_1.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
