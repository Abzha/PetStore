using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FoodCategory
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string FoodCategoryName { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Food> Foods { get; set; } = new List<Food>();

    public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>();

    public virtual User User { get; set; } = null!;
}
