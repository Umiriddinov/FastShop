using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShop.Domain.Exceptions.Categories;

public class CategoryNotFoundException : NotFoundException
{
    public CategoryNotFoundException()
    {
        this.TitleMessage = "Category not found!";
    }
}
