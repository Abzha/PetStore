using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MapCoordinate
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid BranchId { get; set; }

    public string? Lon { get; set; }

    public string? Lat { get; set; }

    public Guid? LastUpdateUserId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual User? LastUpdateUser { get; set; }

    public virtual User User { get; set; } = null!;
}
