using AutoMapper;
using OnionArch.APPLICATION.Dtos.AppUsers;
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
    public class AppUserManager : BaseManager<AppUser, AppUserDto>, IAppUserManager
    {
        IAppUserRepository _repository;
        public AppUserManager(IAppUserRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }
    }
}
