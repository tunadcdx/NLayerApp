using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product()
            {
                Id = 1,
                CategoryId = 1,
                Name = "Zigon Sehpa1",
                Image = "resim1",
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "Orta Sehpa1",
                Image = "resim2",
                Price = 200,
                Stock = 30,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "Zigon Sehpa2",
                Image = "resim3",
                Price = 600,
                Stock = 50,
                CreatedDate = DateTime.Now
            },
            new Product
            {
                Id = 4,
                CategoryId = 2,
                Name = "Köşe Koltuk1",
                Image = "resim4",
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now
            },
            new Product()
            {
                Id = 5,
                CategoryId = 2,
                Name = "Köşe Koltuk2",
                Image = "resim5",
                Price = 150,
                Stock = 25,
                CreatedDate = DateTime.Now
            });


        }
    }
}
