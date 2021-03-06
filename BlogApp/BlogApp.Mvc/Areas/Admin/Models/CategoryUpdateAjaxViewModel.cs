using BlogApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Mvc.Areas.Admin.Models
{
    public class CategoryUpdateAjaxViewModel
    {
        public CategoryAddDto CategoryUpdateDto { get; set; }
        public string CategoryUpdatePartial { get; set; }

        public CategoryDto CategoryDto { get; set; }
    }
}
