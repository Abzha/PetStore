using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

public partial class PetStoreDbContext : DbContext
{
    public PetStoreDbContext()
    {
    }

    public PetStoreDbContext(DbContextOptions<PetStoreDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AboutU> AboutUs { get; set; }

    public virtual DbSet<AboutUsImg> AboutUsImgs { get; set; }

    public virtual DbSet<Accessory> Accessories { get; set; }

    public virtual DbSet<Animal> Animals { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<BranchEmail> BranchEmails { get; set; }

    public virtual DbSet<BranchPhone> BranchPhones { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<ClientAnimal> ClientAnimals { get; set; }

    public virtual DbSet<ClientStatus> ClientStatuses { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Food> Foods { get; set; }

    public virtual DbSet<FoodCategory> FoodCategories { get; set; }

    public virtual DbSet<InformationPage> InformationPages { get; set; }

    public virtual DbSet<MapCoordinate> MapCoordinates { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<NewsImg> NewsImgs { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<Pharmacy> Pharmacies { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<ProductImg> ProductImgs { get; set; }

    public virtual DbSet<ProductStatus> ProductStatuses { get; set; }

    public virtual DbSet<PurchasedProduct> PurchasedProducts { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=localhost;Database=pet_store_db;Port=5432;User Id=postgres;Password=706267;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AboutU>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("about_us_pkey");

            entity.ToTable("about_us");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.LastUpdateUserId).HasColumnName("last_update_user_id");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.LastUpdateUser).WithMany(p => p.AboutULastUpdateUsers)
                .HasForeignKey(d => d.LastUpdateUserId)
                .HasConstraintName("last_update_user_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.AboutUUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<AboutUsImg>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.CreatedAt }).HasName("about_us_img_pkey");

            entity.ToTable("about_us_img");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.AboutUsId).HasColumnName("about_us_id");
            entity.Property(e => e.ImgUrl).HasColumnName("img_url");
            entity.Property(e => e.LastUpdateUserId).HasColumnName("last_update_user_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.AboutUs).WithMany(p => p.AboutUsImgs)
                .HasForeignKey(d => d.AboutUsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("about_us_id_fk");

            entity.HasOne(d => d.LastUpdateUser).WithMany(p => p.AboutUsImgLastUpdateUsers)
                .HasForeignKey(d => d.LastUpdateUserId)
                .HasConstraintName("last_update_user_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.AboutUsImgUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<Accessory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accessory_pkey");

            entity.ToTable("accessory");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AccessoryName).HasColumnName("accessory_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Accessories)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id");
        });

        modelBuilder.Entity<Animal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("animal_pkey");

            entity.ToTable("animal");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AnimalName).HasColumnName("animal_name");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Animals)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("branch_pkey");

            entity.ToTable("branch");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.LastUpdateUserId).HasColumnName("last_update_user_id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.LastUpdateUser).WithMany(p => p.BranchLastUpdateUsers)
                .HasForeignKey(d => d.LastUpdateUserId)
                .HasConstraintName("last_update_user_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.BranchUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<BranchEmail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("branch_email_pkey");

            entity.ToTable("branch_email");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BranchId).HasColumnName("branch_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.LastUpdateUserId).HasColumnName("last_update_user_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Branch).WithMany(p => p.BranchEmails)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("branch_id_fk");

            entity.HasOne(d => d.LastUpdateUser).WithMany(p => p.BranchEmailLastUpdateUsers)
                .HasForeignKey(d => d.LastUpdateUserId)
                .HasConstraintName("last_update_user_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.BranchEmailUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<BranchPhone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("branch_phone_pkey");

            entity.ToTable("branch_phone");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BranchId).HasColumnName("branch_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.LastUpdateUserId).HasColumnName("last_update_user_id");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Branch).WithMany(p => p.BranchPhones)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("branch_id_fk");

            entity.HasOne(d => d.LastUpdateUser).WithMany(p => p.BranchPhoneLastUpdateUsers)
                .HasForeignKey(d => d.LastUpdateUserId)
                .HasConstraintName("last_update_user_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.BranchPhoneUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cart_pkey");

            entity.ToTable("cart");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Client).WithMany(p => p.Carts)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("client_id_fk");

            entity.HasOne(d => d.Product).WithMany(p => p.Carts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("product_id_fk");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("client_pkey");

            entity.ToTable("client");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.LoyaltyPoints).HasColumnName("loyalty_points");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.Surname).HasColumnName("surname");
            entity.Property(e => e.UpadteAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("upadte_at");

            entity.HasOne(d => d.Status).WithMany(p => p.Clients)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("status_id_fk");
        });

        modelBuilder.Entity<ClientAnimal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("client_animal_pkey");

            entity.ToTable("client_animal");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Age)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("age");
            entity.Property(e => e.AnimalId).HasColumnName("animal_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.Animal).WithMany(p => p.ClientAnimals)
                .HasForeignKey(d => d.AnimalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("animal_id_fk");

            entity.HasOne(d => d.Client).WithMany(p => p.ClientAnimals)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("client_id_fk");
        });

        modelBuilder.Entity<ClientStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("client_status_pkey");

            entity.ToTable("client_status");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("contact_pkey");

            entity.ToTable("contact");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BranchId).HasColumnName("branch_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.LastUpdateUserId).HasColumnName("last_update_user_id");
            entity.Property(e => e.PageTitle).HasColumnName("page_title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Branch).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("branch_id_fk");

            entity.HasOne(d => d.LastUpdateUser).WithMany(p => p.ContactLastUpdateUsers)
                .HasForeignKey(d => d.LastUpdateUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("last_update_user_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.ContactUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<Food>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("food_pkey");

            entity.ToTable("food");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FoodCategoryId).HasColumnName("food_category_id");
            entity.Property(e => e.FoodName).HasColumnName("food_name");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.FoodCategory).WithMany(p => p.Foods)
                .HasForeignKey(d => d.FoodCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("food_category_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.Foods)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<FoodCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("food_category_pkey");

            entity.ToTable("food_category");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FoodCategoryName).HasColumnName("food_category_name");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.FoodCategories)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<InformationPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("information_page_pkey");

            entity.ToTable("information_page");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.LastUpdateUserId).HasColumnName("last_update_user_id");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.LastUpdateUser).WithMany(p => p.InformationPageLastUpdateUsers)
                .HasForeignKey(d => d.LastUpdateUserId)
                .HasConstraintName("last_update_user_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.InformationPageUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<MapCoordinate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("map_coordinates_pkey");

            entity.ToTable("map_coordinates");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BranchId).HasColumnName("branch_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.LastUpdateUserId).HasColumnName("last_update_user_id");
            entity.Property(e => e.Lat).HasColumnName("lat");
            entity.Property(e => e.Lon).HasColumnName("lon");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Branch).WithMany(p => p.MapCoordinates)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("branch_id_fk");

            entity.HasOne(d => d.LastUpdateUser).WithMany(p => p.MapCoordinateLastUpdateUsers)
                .HasForeignKey(d => d.LastUpdateUserId)
                .HasConstraintName("last_update_user_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.MapCoordinateUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("menu_pkey");

            entity.ToTable("menu");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AccessoryId).HasColumnName("accessory_id");
            entity.Property(e => e.AnimalId).HasColumnName("animal_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FoodCategoryId).HasColumnName("food_category_id");
            entity.Property(e => e.FoodId).HasColumnName("food_id");
            entity.Property(e => e.LastUpdatedUserId).HasColumnName("last_updated_user_id");
            entity.Property(e => e.MenuButtonName).HasColumnName("menu_button_name");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.PharmacyId).HasColumnName("pharmacy_id");
            entity.Property(e => e.ProductCategoryId).HasColumnName("product_category_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Accessory).WithMany(p => p.Menus)
                .HasForeignKey(d => d.AccessoryId)
                .HasConstraintName("accessory_id_fk");

            entity.HasOne(d => d.Animal).WithMany(p => p.Menus)
                .HasForeignKey(d => d.AnimalId)
                .HasConstraintName("animal_id_fk");

            entity.HasOne(d => d.FoodCategory).WithMany(p => p.Menus)
                .HasForeignKey(d => d.FoodCategoryId)
                .HasConstraintName("food_category_id_fk");

            entity.HasOne(d => d.Food).WithMany(p => p.Menus)
                .HasForeignKey(d => d.FoodId)
                .HasConstraintName("food_id_fk");

            entity.HasOne(d => d.LastUpdatedUser).WithMany(p => p.MenuLastUpdatedUsers)
                .HasForeignKey(d => d.LastUpdatedUserId)
                .HasConstraintName("last_updated_user_id_fk");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("parent_id_fk");

            entity.HasOne(d => d.Pharmacy).WithMany(p => p.Menus)
                .HasForeignKey(d => d.PharmacyId)
                .HasConstraintName("pharmacy_id_fk");

            entity.HasOne(d => d.ProductCategory).WithMany(p => p.Menus)
                .HasForeignKey(d => d.ProductCategoryId)
                .HasConstraintName("product_category_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.MenuUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("news_pkey");

            entity.ToTable("news");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.LastUpdateUserId).HasColumnName("last_update_user_id");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.LastUpdateUser).WithMany(p => p.NewsLastUpdateUsers)
                .HasForeignKey(d => d.LastUpdateUserId)
                .HasConstraintName("last_update_user_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.NewsUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<NewsImg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("news_img_pkey");

            entity.ToTable("news_img");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.ImgUrl).HasColumnName("img_url");
            entity.Property(e => e.LastUpdateUserId).HasColumnName("last_update_user_id");
            entity.Property(e => e.NewsId).HasColumnName("news_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.LastUpdateUser).WithMany(p => p.NewsImgLastUpdateUsers)
                .HasForeignKey(d => d.LastUpdateUserId)
                .HasConstraintName("last_update_user_id_fk");

            entity.HasOne(d => d.News).WithMany(p => p.NewsImgs)
                .HasForeignKey(d => d.NewsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("news_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.NewsImgUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_pkey");

            entity.ToTable("order");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.LastUpdateUserId).HasColumnName("last_update_user_id");
            entity.Property(e => e.OrderStatusId).HasColumnName("order_status_id");
            entity.Property(e => e.SummedPrice)
                .HasDefaultValueSql("0.0")
                .HasColumnType("money")
                .HasColumnName("summed_price");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Client).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("client_id_fk");

            entity.HasOne(d => d.LastUpdateUser).WithMany(p => p.OrderLastUpdateUsers)
                .HasForeignKey(d => d.LastUpdateUserId)
                .HasConstraintName("last_update_user_id_fk");

            entity.HasOne(d => d.OrderStatus).WithMany(p => p.Orders)
                .HasForeignKey(d => d.OrderStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_status_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.OrderUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_status_pkey");

            entity.ToTable("order_status");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.LastUpdatedUserId).HasColumnName("last_updated_user_id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.LastUpdatedUser).WithMany(p => p.OrderStatusLastUpdatedUsers)
                .HasForeignKey(d => d.LastUpdatedUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("last_update_user_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.OrderStatusUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<Pharmacy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pharmacy_pkey");

            entity.ToTable("pharmacy");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.PharmacyName).HasColumnName("pharmacy_name");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Pharmacies)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_pkey");

            entity.ToTable("product");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AccessoryId).HasColumnName("accessory_id");
            entity.Property(e => e.AnimalAge)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("animal_age");
            entity.Property(e => e.AnimalId).HasColumnName("animal_id");
            entity.Property(e => e.AnimalWeight).HasColumnName("animal_weight");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.DiscountPrice)
                .HasColumnType("money")
                .HasColumnName("discount_price");
            entity.Property(e => e.FoodId).HasColumnName("food_id");
            entity.Property(e => e.FoodWeight).HasColumnName("food_weight");
            entity.Property(e => e.LastUpdateUserId).HasColumnName("last_update_user_id");
            entity.Property(e => e.PharmacyId).HasColumnName("pharmacy_id");
            entity.Property(e => e.PriceByLoyaltyPoint).HasColumnName("price_by_loyalty_point");
            entity.Property(e => e.ProductCategoryId).HasColumnName("product_category_id");
            entity.Property(e => e.ProductCode).HasColumnName("product_code");
            entity.Property(e => e.ProductDescription).HasColumnName("product_description");
            entity.Property(e => e.ProductName).HasColumnName("product_name");
            entity.Property(e => e.ProductStatusId).HasColumnName("product_status_id");
            entity.Property(e => e.RecievedCount).HasColumnName("recieved_count");
            entity.Property(e => e.RegularPrice)
                .HasColumnType("money")
                .HasColumnName("regular_price");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Accessory).WithMany(p => p.Products)
                .HasForeignKey(d => d.AccessoryId)
                .HasConstraintName("accessory_id_fk");

            entity.HasOne(d => d.Animal).WithMany(p => p.Products)
                .HasForeignKey(d => d.AnimalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("animal_id_fk");

            entity.HasOne(d => d.Food).WithMany(p => p.Products)
                .HasForeignKey(d => d.FoodId)
                .HasConstraintName("food_id_fk");

            entity.HasOne(d => d.LastUpdateUser).WithMany(p => p.ProductLastUpdateUsers)
                .HasForeignKey(d => d.LastUpdateUserId)
                .HasConstraintName("last_update_user_id_fk");

            entity.HasOne(d => d.Pharmacy).WithMany(p => p.Products)
                .HasForeignKey(d => d.PharmacyId)
                .HasConstraintName("pharmacy_id_fk");

            entity.HasOne(d => d.ProductCategory).WithMany(p => p.Products)
                .HasForeignKey(d => d.ProductCategoryId)
                .HasConstraintName("product_category_id_fk");

            entity.HasOne(d => d.ProductStatus).WithMany(p => p.Products)
                .HasForeignKey(d => d.ProductStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("product_status_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.ProductUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_category_pkey");

            entity.ToTable("product_category");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.ProductCategoryName).HasColumnName("product_category_name");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.ProductCategories)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<ProductImg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_img_pkey");

            entity.ToTable("product_img");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.ImgUrl).HasColumnName("img_url");
            entity.Property(e => e.LastUpdatedUserId).HasColumnName("last_updated_user_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.LastUpdatedUser).WithMany(p => p.ProductImgs)
                .HasForeignKey(d => d.LastUpdatedUserId)
                .HasConstraintName("last_updated_user_id_fk");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductImgs)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("product_id_fk");
        });

        modelBuilder.Entity<ProductStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_status_pkey");

            entity.ToTable("product_status");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<PurchasedProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("purchased_product_pkey");

            entity.ToTable("purchased_product");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.PriceByLoyaltyPoint).HasColumnName("price_by_loyalty_point");
            entity.Property(e => e.ProductCount).HasColumnName("product_count");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.ProductPrice)
                .HasColumnType("money")
                .HasColumnName("product_price");

            entity.HasOne(d => d.Client).WithMany(p => p.PurchasedProducts)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("client_id_fk");

            entity.HasOne(d => d.Order).WithMany(p => p.PurchasedProducts)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_id_fk");

            entity.HasOne(d => d.Product).WithMany(p => p.PurchasedProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("product_id_fk");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_pkey");

            entity.ToTable("user", tb => tb.HasComment("User in our case means employee of Pet Store and nothing else."));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.CreatedUserId).HasColumnName("created_user_id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.LastUpdateUserId).HasColumnName("last_update_user_id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Surname).HasColumnName("surname");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.CreatedUser).WithMany(p => p.InverseCreatedUser)
                .HasForeignKey(d => d.CreatedUserId)
                .HasConstraintName("created_user_id_fk");

            entity.HasOne(d => d.LastUpdateUser).WithMany(p => p.InverseLastUpdateUser)
                .HasForeignKey(d => d.LastUpdateUserId)
                .HasConstraintName("last_update_user_id_fk");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("role_fk");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_role_pkey");

            entity.ToTable("user_role", tb => tb.HasComment("User Role refers to a set of permissions or privileges assigned to a user or a group of users. User roles help manage access control and security within a database system. Each user role is associated with specific permissions that determine what actions or operations the users assigned to."));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
