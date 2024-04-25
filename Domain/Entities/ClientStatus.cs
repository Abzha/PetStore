using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ClientStatus
{
    public Guid Id { get; set; }

    public string StatusName { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
