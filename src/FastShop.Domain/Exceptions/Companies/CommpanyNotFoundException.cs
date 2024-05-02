using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShop.Domain.Exceptions.Companies;

public class CommpanyNotFoundException : NotFoundException
{
    public CommpanyNotFoundException()
    {
        this.TitleMessage = "Compant not found!";
    }
}
