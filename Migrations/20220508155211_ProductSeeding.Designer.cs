// <auto-generated />
using FurnitureShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FurnitureShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220508155211_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FurnitureShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description1",
                            ImageUrl = "#",
                            Price = 9.99m,
                            Title = "Title1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description2",
                            ImageUrl = "#",
                            Price = 7.99m,
                            Title = "Title2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "#",
                            ImageUrl = "Description3",
                            Price = 6.99m,
                            Title = "Title3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Description4",
                            ImageUrl = "#",
                            Price = 5.99m,
                            Title = "Title4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
