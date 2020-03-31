﻿using AutoMapper;

using Convience.Entity.Data;
using Convience.Entity.Entity;
using Convience.Model.Models.SaasManage;
using Convience.Model.Models.SystemManage;

namespace Convience.Model
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<RoleViewModel, SystemRole>();
            CreateMap<SystemRole, RoleResult>();

            CreateMap<UserViewModel, SystemUser>();
            CreateMap<SystemUser, UserResult>().ForMember(user => user.Sex,
                ex => ex.MapFrom(result => (int)result.Sex));

            CreateMap<MenuViewModel, Menu>();
            CreateMap<Menu, MenuResult>().ForMember(menu => menu.Type,
                ex => ex.MapFrom(result => (int)result.Type));

            CreateMap<TenantViewModel, Tenant>();
            CreateMap<Tenant, TenantResult>();
        }
    }
}