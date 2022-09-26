using Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace RBAC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : ControllerBase
    {
        [HttpGet]
        public PermissionViewModel HasPermission(int roleId, int actionId)
        {
            return View();
        }
    }
}
