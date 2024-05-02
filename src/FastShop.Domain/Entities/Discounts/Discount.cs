﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShop.Domain.Entities.Discounts;

public class Discount : Auditable
{
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public short Percentage { get; set; }
}