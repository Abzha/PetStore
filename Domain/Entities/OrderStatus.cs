using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrderStatus
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string StatusName { get; set; } = null!;

    public Guid LastUpdatedUserId { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual User LastUpdatedUser { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual User User { get; set; } = null!;
}
