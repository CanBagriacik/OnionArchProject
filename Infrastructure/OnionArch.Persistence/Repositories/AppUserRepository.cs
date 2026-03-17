using OnionArch.CONTRACT.Repositories;
using OnionArch.DOMAIN.Entities.Concretes;
using OnionArch.Persistence.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Persistence.Repositories
{
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository
    {
        public AppUserRepository(MyContext context) : base(context)
        {

        }
    }
}
