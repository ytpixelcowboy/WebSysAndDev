using Microsoft.AspNetCore.Mvc;

namespace PT_Palma_CarlJordee.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
