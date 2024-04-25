using System;
using System.Collections.Generic;

namespace Domain.Entities;

/// <summary>
/// User in our case means employee of Pet Store and nothing else.
/// </summary>
public partial class User
{
    public Guid Id { get; set; }

    public Guid RoleId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? Phone { get; set; }

    public string? Address { get; set; }

    public Guid? CreatedUserId { get; set; }

    public Guid? LastUpdateUserId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public TimeOnly CreatedAt { get; set; }

    public virtual ICollection<AboutU> AboutULastUpdateUsers { get; set; } = new List<AboutU>();

    public virtual ICollection<AboutU> AboutUUsers { get; set; } = new List<AboutU>();

    public virtual ICollection<AboutUsImg> AboutUsImgLastUpdateUsers { get; set; } = new List<AboutUsImg>();

    public virtual ICollection<AboutUsImg> AboutUsImgUsers { get; set; } = new List<AboutUsImg>();

    public virtual ICollection<Accessory> Accessories { get; set; } = new List<Accessory>();

    public virtual ICollection<Animal> Animals { get; set; } = new List<Animal>();

    public virtual ICollection<BranchEmail> BranchEmailLastUpdateUsers { get; set; } = new List<BranchEmail>();

    public virtual ICollection<BranchEmail> BranchEmailUsers { get; set; } = new List<BranchEmail>();

    public virtual ICollection<Branch> BranchLastUpdateUsers { get; set; } = new List<Branch>();

    public virtual ICollection<BranchPhone> BranchPhoneLastUpdateUsers { get; set; } = new List<BranchPhone>();

    public virtual ICollection<BranchPhone> BranchPhoneUsers { get; set; } = new List<BranchPhone>();

    public virtual ICollection<Branch> BranchUsers { get; set; } = new List<Branch>();

    public virtual ICollection<Contact> ContactLastUpdateUsers { get; set; } = new List<Contact>();

    public virtual ICollection<Contact> ContactUsers { get; set; } = new List<Contact>();

    public virtual User? CreatedUser { get; set; }

    public virtual ICollection<FoodCategory> FoodCategories { get; set; } = new List<FoodCategory>();

    public virtual ICollection<Food> Foods { get; set; } = new List<Food>();

    public virtual ICollection<InformationPage> InformationPageLastUpdateUsers { get; set; } = new List<InformationPage>();

    public virtual ICollection<InformationPage> InformationPageUsers { get; set; } = new List<InformationPage>();

    public virtual ICollection<User> InverseCreatedUser { get; set; } = new List<User>();

    public virtual ICollection<User> InverseLastUpdateUser { get; set; } = new List<User>();

    public virtual User? LastUpdateUser { get; set; }

    public virtual ICollection<MapCoordinate> MapCoordinateLastUpdateUsers { get; set; } = new List<MapCoordinate>();

    public virtual ICollection<MapCoordinate> MapCoordinateUsers { get; set; } = new List<MapCoordinate>();

    public virtual ICollection<Menu> MenuLastUpdatedUsers { get; set; } = new List<Menu>();

    public virtual ICollection<Menu> MenuUsers { get; set; } = new List<Menu>();

    public virtual ICollection<NewsImg> NewsImgLastUpdateUsers { get; set; } = new List<NewsImg>();

    public virtual ICollection<NewsImg> NewsImgUsers { get; set; } = new List<NewsImg>();

    public virtual ICollection<News> NewsLastUpdateUsers { get; set; } = new List<News>();

    public virtual ICollection<News> NewsUsers { get; set; } = new List<News>();

    public virtual ICollection<Order> OrderLastUpdateUsers { get; set; } = new List<Order>();

    public virtual ICollection<OrderStatus> OrderStatusLastUpdatedUsers { get; set; } = new List<OrderStatus>();

    public virtual ICollection<OrderStatus> OrderStatusUsers { get; set; } = new List<OrderStatus>();

    public virtual ICollection<Order> OrderUsers { get; set; } = new List<Order>();

    public virtual ICollection<Pharmacy> Pharmacies { get; set; } = new List<Pharmacy>();

    public virtual ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();

    public virtual ICollection<ProductImg> ProductImgs { get; set; } = new List<ProductImg>();

    public virtual ICollection<Product> ProductLastUpdateUsers { get; set; } = new List<Product>();

    public virtual ICollection<Product> ProductUsers { get; set; } = new List<Product>();

    public virtual UserRole Role { get; set; } = null!;
}
