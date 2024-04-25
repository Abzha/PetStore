using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Cart
{
    public Guid Id { get; set; }

    public Guid ClientId { get; set; }

    public Guid ProductId { get; set; }

    public string? Status { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
