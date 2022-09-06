namespace FurnitureShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
                .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });

            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductTypeId });

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1, Name = "Living Room" },
                new ProductType { Id = 2, Name = "Bedroom" },
                new ProductType { Id = 3, Name = "Kitchen" },
                new ProductType { Id = 4, Name = "Office" },
                new ProductType { Id = 5, Name = "Bathroom" },
                new ProductType { Id = 6, Name = "Kids room" },
                new ProductType { Id = 7, Name = "Game room" },
                new ProductType { Id = 8, Name = "Garden" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Living Room Furniture",
                    Url = "living_room_furniture"
                },
                 new Category
                 {
                     Id = 2,
                     Name = "Bedroom Furniture",
                     Url = "bedroom_furniture"
                 },
                  new Category
                  {
                      Id = 3,
                      Name = "Kitchen & Dinning Furniture",
                      Url = "kitchen_&_dinning_furniture"
                  },
                  new Category
                  {
                      Id = 4,
                      Name = "Office Furniture",
                      Url = "office_furniture"
                  },
                  new Category
                  {
                      Id = 5,
                      Name = "Bathroom Furniture",
                      Url = "bathroom_furniture"
                  },
                   new Category
                   {
                       Id = 6,
                       Name = "Kids Furniture",
                       Url = "kids_furniture"
                   },
                    new Category
                    {
                        Id = 7,
                        Name = "Game Room Furniture",
                        Url = "game_room_furniture"
                    }

                );
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "Title1",
                     Description = "Description1",
                     ImageUrl = "#",
                     CategoryId = 1,
                     Featured = true
                 },
                new Product
                {
                    Id = 2,
                    Title = "Title2",
                    Description = "Description2",
                    ImageUrl = "#",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 3,
                    Title = "Title3",
                    Description = "Description3",
                    ImageUrl = "#",
                    CategoryId = 3,
                    Featured = true
                },
                new Product
                {
                    Id = 4,
                    Title = "Title4",
                    Description = "Description4",
                    ImageUrl = "#",
                    CategoryId = 4
                }
             );
            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId =1,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                 new ProductVariant
                 {
                     ProductId = 2,
                     ProductTypeId =2,
                     Price = 9.99m,
                     OriginalPrice = 19.99m
                 },
                  new ProductVariant
                  {
                      ProductId = 3,
                      ProductTypeId =3,
                      Price = 9.99m,
                      OriginalPrice = 19.99m
                  },
                   new ProductVariant
                   {
                       ProductId = 4,
                       ProductTypeId =4,
                       Price = 9.99m,
                       OriginalPrice = 19.99m
                   },
                    new ProductVariant
                    {
                        ProductId = 1,
                        ProductTypeId =5,
                        Price = 9.99m,
                        OriginalPrice = 19.99m
                    },
                     new ProductVariant
                     {
                         ProductId = 2,
                         ProductTypeId =6,
                         Price = 9.99m,
                         OriginalPrice = 19.99m
                     }
            );


        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Image> Images { get; set; }
       
       
    }
}
