using OnionArch.APPLICATION.Dtos.AppUsers;
using OnionArch.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.APPLICATION.Managers
{
    public interface IAppUserManager:IManager<AppUser,AppUserDto>
    {

    }
}
