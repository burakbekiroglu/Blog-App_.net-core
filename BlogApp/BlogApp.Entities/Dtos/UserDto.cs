using BlogApp.Entities.Concrete;
using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Dtos
{
    public class UserDto:DtoGetBase
    {
        public User User { get; set; }
    }
}
