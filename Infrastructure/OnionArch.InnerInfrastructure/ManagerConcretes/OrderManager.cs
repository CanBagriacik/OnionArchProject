using AutoMapper;
using OnionArch.APPLICATION.Dtos.Orders;
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
    public class OrderManager : BaseManager<Order, OrderDto>, IOrderManager
    {
        IOrderRepository _repository;
        public OrderManager(IOrderRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }
    }
}
