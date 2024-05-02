using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShop.Domain.Exceptions.Deliveries;

public class DeliveryNotFoundException : NotFoundException
{
    public DeliveryNotFoundException()
    {
        this.TitleMessage = "Delivery not found!";
    }
}
