using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);

            Faker faker = new Faker();

            Brand brand1 = new() { Name = faker.Commerce.Department(), CreatedDate = DateTime.UtcNow, Id = 1, IsDeleted= false};
            Brand brand2 = new() { Name = faker.Commerce.Department(), CreatedDate = DateTime.UtcNow, Id = 2, IsDeleted = false };
            Brand brand3 = new() { Name = faker.Commerce.Department(), CreatedDate = DateTime.UtcNow, Id = 3, IsDeleted = true };
            builder.HasData(brand1, brand2, brand3);

        }
    }

}
