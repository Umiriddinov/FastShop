﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShop.Domain.Entities.Products;

public class ProductDiscount : Auditable
{
    public long ProductId { get; set; }

    public long DiscountId { get; set;}

    public string Description { get; set; } = string.Empty;

    public DateTime StartAt { get; set; }

    public DateTime EndAt { get; set; }

    public short Percentage { get; set; }
}
