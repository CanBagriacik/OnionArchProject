using AutoMapper;
using Microsoft.EntityFrameworkCore.Query;
using OnionArch.APPLICATION.Dtos;
using OnionArch.APPLICATION.Dtos.AppUserProfiles;
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
    public class AppUserProfileManager : BaseManager<AppUserProfile, AppUserProfileDto>, IAppUserProfileManager
    {
        IAppUserProfileRepository _repository;

        public AppUserProfileManager(IAppUserProfileRepository repository, IMapper mapper): base(repository, mapper)
        {
            _repository = repository;
        }
    }
}
