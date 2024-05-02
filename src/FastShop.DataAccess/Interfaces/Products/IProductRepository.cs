using FastShop.DataAccess.Common.Interfaces;
using FastShop.DataAccess.ViewModels.Products;
using FastShop.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShop.DataAccess.Interfaces.Products;

public interface IProductRepository : IRepository<Product,ProductViewModel>,
    IGetAll<ProductViewModel>, ISearchable<ProductViewModel>
{

}
