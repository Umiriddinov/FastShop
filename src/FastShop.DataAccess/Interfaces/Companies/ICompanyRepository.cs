using FastShop.DataAccess.Common.Interfaces;
using FastShop.Domain.Entities.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShop.DataAccess.Interfaces.Companies;

public interface ICompanyRepository : IRepository<Company, Company>,
    IGetAll<Company>
{

}
