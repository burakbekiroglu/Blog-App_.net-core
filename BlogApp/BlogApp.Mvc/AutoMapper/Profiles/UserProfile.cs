using AutoMapper;
using BlogApp.Entities.Concrete;
using BlogApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Mvc.AutoMapper.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<UserAddDto, User>();

            CreateMap<UserUpdateDto, User>();
            CreateMap<User, UserUpdateDto>();

        }

    }
}
