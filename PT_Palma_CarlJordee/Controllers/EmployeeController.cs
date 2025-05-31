using Microsoft.AspNetCore.Mvc;

namespace PT_Palma_CarlJordee.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
