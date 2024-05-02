﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShop.Domain.Entities;

public abstract class Auditable
{
    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set;}
}
