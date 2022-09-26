using Microsoft.AspNetCore.Mvc;

namespace RBAC.Controllers
{
    public class ActionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
