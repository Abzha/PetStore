using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Branch
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public Guid? LastUpdateUserId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<BranchEmail> BranchEmails { get; set; } = new List<BranchEmail>();

    public virtual ICollection<BranchPhone> BranchPhones { get; set; } = new List<BranchPhone>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual User? LastUpdateUser { get; set; }

    public virtual ICollection<MapCoordinate> MapCoordinates { get; set; } = new List<MapCoordinate>();

    public virtual User User { get; set; } = null!;
}
