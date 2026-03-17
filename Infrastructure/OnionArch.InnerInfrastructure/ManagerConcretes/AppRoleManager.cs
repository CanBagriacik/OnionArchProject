using AutoMapper;
using OnionArch.APPLICATION.Dtos.AppRoles;
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
    public class AppRoleManager : BaseManager<AppRole, AppRoleDto>, IAppRoleManager
    {
        IAppRoleRepository _repository;
        public AppRoleManager(IAppRoleRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }
    }
}
