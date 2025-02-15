using Microsoft.AspNetCore.Mvc;

namespace COMPLIANCE.Controllers
{
    public class LawController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit()
        {
            return View();
        }

    }
}
