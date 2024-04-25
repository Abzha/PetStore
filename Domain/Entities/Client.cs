using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Client
{
    public Guid Id { get; set; }

    public Guid StatusId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? Phone { get; set; }

    public string? Address { get; set; }

    public decimal LoyaltyPoints { get; set; }

    public DateTime? UpadteAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<ClientAnimal> ClientAnimals { get; set; } = new List<ClientAnimal>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<PurchasedProduct> PurchasedProducts { get; set; } = new List<PurchasedProduct>();

    public virtual ClientStatus Status { get; set; } = null!;
}
