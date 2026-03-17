using AutoMapper;
using OnionArch.APPLICATION.Dtos.AppRoles;
using OnionArch.APPLICATION.Dtos.AppUserProfiles;
using OnionArch.APPLICATION.Dtos.AppUserRoles;
using OnionArch.APPLICATION.Dtos.AppUsers;
using OnionArch.APPLICATION.Dtos.Categories;
using OnionArch.APPLICATION.Dtos.OrderDetails;
using OnionArch.APPLICATION.Dtos.Orders;
using OnionArch.APPLICATION.Dtos.Products;
using OnionArch.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.APPLICATION.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            #region ProductMapping
            CreateMap<Product, ProductDto>().ReverseMap();
            #endregion

            #region CategoryMapping
            CreateMap<Category, CategoryDto>().ReverseMap();
            #endregion

            #region OrderMapping
            CreateMap<Order, OrderDto>().ReverseMap();
            #endregion 

            #region OrderDetailMapping
            CreateMap<OrderDetail, OrderDetailDto>().ReverseMap();
            #endregion

            #region AppRoleMapping
            CreateMap<AppRole, AppRoleDto>().ReverseMap();
            #endregion

            #region AppUserMapping
            CreateMap<AppUser, AppUserDto>().ReverseMap();
            #endregion

            #region AppUserRoleMapping
            CreateMap<AppUserRole, AppUserRoleDto>().ReverseMap();
            #endregion

            #region AppUserProfileMapping
            CreateMap<AppUserProfile, AppUserProfileDto>().ReverseMap();
            #endregion 
        }

    }
}
