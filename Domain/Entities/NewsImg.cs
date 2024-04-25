using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class NewsImg
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid NewsId { get; set; }

    public string? ImgUrl { get; set; }

    public Guid? LastUpdateUserId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual User? LastUpdateUser { get; set; }

    public virtual News News { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
