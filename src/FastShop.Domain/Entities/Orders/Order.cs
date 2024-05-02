using FastShop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShop.Domain.Entities.Orders;

public class Order : Auditable
{
    public long UserId { get; set; }

    public long DeliverId { get; set; }

    public OrderStatus Status { get; set; }

    public double ProductsPrice { get; set; }

    public double DeliveryPrice { get; set;}

    public double ResultPrice { get; set; }

    public double Latitude { get; set; } 
    
    public double Longitude { get; set; }

    public PaymentType Payment { get; set; }

    public bool IsPaid { get; set; }

    public bool IsContracted { get; set; }

    public string Description { get; set; } = string.Empty;

}
