using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Menu
{
    public Guid Id { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? PharmacyId { get; set; }

    public Guid? AnimalId { get; set; }

    public Guid? AccessoryId { get; set; }

    public Guid? FoodId { get; set; }

    public Guid? FoodCategoryId { get; set; }

    public Guid? ProductCategoryId { get; set; }

    public string MenuButtonName { get; set; } = null!;

    public Guid? LastUpdatedUserId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Accessory? Accessory { get; set; }

    public virtual Animal? Animal { get; set; }

    public virtual Food? Food { get; set; }

    public virtual FoodCategory? FoodCategory { get; set; }

    public virtual ICollection<Menu> InverseParent { get; set; } = new List<Menu>();

    public virtual User? LastUpdatedUser { get; set; }

    public virtual Menu? Parent { get; set; }

    public virtual Pharmacy? Pharmacy { get; set; }

    public virtual ProductCategory? ProductCategory { get; set; }

    public virtual User? User { get; set; }
}
