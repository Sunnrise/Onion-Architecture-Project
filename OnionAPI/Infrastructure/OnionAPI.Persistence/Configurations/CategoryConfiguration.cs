using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionAPI.Domain.Entities;

namespace OnionAPI.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new() { Name = "Electric", Id=1, Priority=1, ParentId=0, IsDeleted=false, CreatedDate=DateTime.UtcNow};
            Category category2 = new() { Name = "Fashion", Id = 2, Priority = 2, ParentId = 0, IsDeleted = false, CreatedDate = DateTime.UtcNow };

            Category parent1 = new() { Name = "Computer", Id = 3, Priority = 1, ParentId = 1, IsDeleted = false, CreatedDate = DateTime.UtcNow };
            Category parent2 = new() { Name = "Women", Id = 4, Priority = 1, ParentId = 2, IsDeleted = false, CreatedDate = DateTime.UtcNow };
            builder.HasData(category1, category2, parent1, parent2);
        }
    }

}
