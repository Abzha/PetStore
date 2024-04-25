using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Animal
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string AnimalName { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<ClientAnimal> ClientAnimals { get; set; } = new List<ClientAnimal>();

    public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual User User { get; set; } = null!;
}
