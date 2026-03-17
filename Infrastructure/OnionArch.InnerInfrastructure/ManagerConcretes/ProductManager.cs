using AutoMapper;
using OnionArch.DOMAIN.Entities.Concretes;
using OnionArch.APPLICATION.Dtos.Products;
using OnionArch.APPLICATION.Managers;
using OnionArch.CONTRACT.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.InnerInfrastructure.ManagerConcretes
{
    public class ProductManager : BaseManager<Product,ProductDto>, IProductManager
    {
        IProductRepository _repository;
        public ProductManager(IProductRepository repository,IMapper mapper) : base(repository, mapper)
        {
           _repository = repository;
        }

    }
}
