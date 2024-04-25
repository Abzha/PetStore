using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ProductStatus
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string StatusName { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
