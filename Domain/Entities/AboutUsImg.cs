using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AboutUsImg
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid AboutUsId { get; set; }

    public string? ImgUrl { get; set; }

    public Guid? LastUpdateUserId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual AboutU AboutUs { get; set; } = null!;

    public virtual User? LastUpdateUser { get; set; }

    public virtual User User { get; set; } = null!;
}
