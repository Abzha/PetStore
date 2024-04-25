using System;
using System.Collections.Generic;

namespace Domain.Entities;

/// <summary>
/// User Role refers to a set of permissions or privileges assigned to a user or a group of users. User roles help manage access control and security within a database system. Each user role is associated with specific permissions that determine what actions or operations the users assigned to.
/// </summary>
public partial class UserRole
{
    public Guid Id { get; set; }

    public string RoleName { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
