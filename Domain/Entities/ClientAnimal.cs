using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ClientAnimal
{
    public Guid Id { get; set; }

    public Guid ClientId { get; set; }

    public Guid AnimalId { get; set; }

    public DateTime? Age { get; set; }

    public decimal? Weight { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Name { get; set; }

    public virtual Animal Animal { get; set; } = null!;

    public virtual Client Client { get; set; } = null!;
}
