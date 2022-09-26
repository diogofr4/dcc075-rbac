using Microsoft.AspNetCore.Mvc;

namespace RBAC.Controllers
{
    public class PermissionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
