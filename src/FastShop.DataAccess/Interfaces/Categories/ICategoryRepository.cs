using FastShop.DataAccess.Common.Interfaces;
using FastShop.Domain.Entities.Categories;

namespace FastShop.DataAccess.Interfaces.Categories;

public interface ICategoryRepository : IRepository<Category, Category>,
    IGetAll<Category>
{

}
