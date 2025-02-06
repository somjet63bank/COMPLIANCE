using Microsoft.AspNetCore.Mvc;

namespace COMPLIANCE.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
