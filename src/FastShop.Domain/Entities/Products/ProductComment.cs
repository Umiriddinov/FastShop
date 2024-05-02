using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShop.Domain.Entities.Products;

public class ProductComment : Auditable
{
    public long ProductId { get; set; }

    public long UserId { get; set; }

    public string Comment { get; set; } = string.Empty;

    public bool IsEdited { get; set; }
}
