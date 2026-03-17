using AutoMapper;
using OnionArch.APPLICATION.Dtos.Categories;
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
    public class CategoryManager : BaseManager<Category, CategoryDto>, ICategoryManager
    {
        ICategoryRepository _repository;
        public CategoryManager(ICategoryRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;

        }

    }
}
