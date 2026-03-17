using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.APPLICATION.Dtos.AppUserRoles
{
    public class AppUserRoleDto : BaseDto
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

    }
}
