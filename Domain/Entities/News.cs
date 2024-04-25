using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class News
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string? Title { get; set; }

    public string? Body { get; set; }

    public Guid? LastUpdateUserId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual User? LastUpdateUser { get; set; }

    public virtual ICollection<NewsImg> NewsImgs { get; set; } = new List<NewsImg>();

    public virtual User User { get; set; } = null!;
}
