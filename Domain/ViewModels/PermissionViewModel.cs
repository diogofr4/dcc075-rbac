using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class PermissionViewModel
    {
        public ActionViewModel ActionViewModel { get; set; }
        public RoleViewModel RoleViewModel { get; set; }
        public bool HasPermission { get; set; }
    }
}
