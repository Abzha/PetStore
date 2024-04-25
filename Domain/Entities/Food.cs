using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Food
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid FoodCategoryId { get; set; }

    public string FoodName { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual FoodCategory FoodCategory { get; set; } = null!;

    public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual User User { get; set; } = null!;
}
