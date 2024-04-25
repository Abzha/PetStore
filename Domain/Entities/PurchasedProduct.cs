using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PurchasedProduct
{
    public Guid Id { get; set; }

    public Guid ClientId { get; set; }

    public Guid OrderId { get; set; }

    public Guid ProductId { get; set; }

    public int? ProductCount { get; set; }

    public decimal? ProductPrice { get; set; }

    public int? PriceByLoyaltyPoint { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
