using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Order
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid ClientId { get; set; }

    public Guid OrderStatusId { get; set; }

    public decimal? SummedPrice { get; set; }

    public Guid? LastUpdateUserId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual User? LastUpdateUser { get; set; }

    public virtual OrderStatus OrderStatus { get; set; } = null!;

    public virtual ICollection<PurchasedProduct> PurchasedProducts { get; set; } = new List<PurchasedProduct>();

    public virtual User User { get; set; } = null!;
}
