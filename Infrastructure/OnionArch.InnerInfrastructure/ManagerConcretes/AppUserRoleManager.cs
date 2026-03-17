using AutoMapper;
using OnionArch.APPLICATION.Dtos.AppUserRoles;
using OnionArch.APPLICATION.Managers;
using OnionArch.CONTRACT.Repositories;
using OnionArch.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.InnerInfrastructure.ManagerConcretes
{
    public class AppUserRoleManager : BaseManager<AppUserRole, AppUserRoleDto>, IAppUserRoleManager
    {
        IAppUserRoleRepository _repository;
        public AppUserRoleManager(IAppUserRoleRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }
    }
}
