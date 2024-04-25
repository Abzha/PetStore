using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Product
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public int ProductCode { get; set; }

    public Guid? ProductCategoryId { get; set; }

    public Guid? FoodId { get; set; }

    public Guid? PharmacyId { get; set; }

    public Guid? AccessoryId { get; set; }

    public Guid AnimalId { get; set; }

    public DateTime? AnimalAge { get; set; }

    public int? AnimalWeight { get; set; }

    public int? FoodWeight { get; set; }

    public int RecievedCount { get; set; }

    public decimal RegularPrice { get; set; }

    public decimal? DiscountPrice { get; set; }

    public int? PriceByLoyaltyPoint { get; set; }

    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;

    public Guid ProductStatusId { get; set; }

    public Guid? LastUpdateUserId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Accessory? Accessory { get; set; }

    public virtual Animal Animal { get; set; } = null!;

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Food? Food { get; set; }

    public virtual User? LastUpdateUser { get; set; }

    public virtual Pharmacy? Pharmacy { get; set; }

    public virtual ProductCategory? ProductCategory { get; set; }

    public virtual ICollection<ProductImg> ProductImgs { get; set; } = new List<ProductImg>();

    public virtual ProductStatus ProductStatus { get; set; } = null!;

    public virtual ICollection<PurchasedProduct> PurchasedProducts { get; set; } = new List<PurchasedProduct>();

    public virtual User User { get; set; } = null!;
}
