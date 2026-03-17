using AutoMapper;
using OnionArch.APPLICATION.Dtos.OrderDetails;
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
    public class OrderDetailManager : BaseManager<OrderDetail, OrderDetailDto>, IOrderDetailManager
    {
        IOrderDetailRepository _repository;

        public OrderDetailManager(IOrderDetailRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;

        }
    }
}