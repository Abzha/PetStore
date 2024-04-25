using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ProductImg
{
    public Guid Id { get; set; }

    public Guid ProductId { get; set; }

    public string? ImgUrl { get; set; }

    public Guid? LastUpdatedUserId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual User? LastUpdatedUser { get; set; }

    public virtual Product Product { get; set; } = null!;
}
