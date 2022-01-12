using BlogApp.Data.Abstract;
using BlogApp.Entities.Concrete;
using BlogApp.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Reposirories
{
    public class EFRoleRepository:EfEntityRepositoryBase<Role>,IRoleRepository
    {
        public EFRoleRepository(DbContext context):base(context)
        {

        }
    }
}
