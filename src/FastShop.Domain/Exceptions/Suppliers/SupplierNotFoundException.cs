﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShop.Domain.Exceptions.Suppliers;

public class SupplierNotFoundException : NotFoundException
{
    public SupplierNotFoundException()
    {
        this.TitleMessage = "Supplier not found!";
    }
}
