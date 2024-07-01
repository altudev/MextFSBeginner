using ECommerceApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceApp.EntityFramework.Configurations
{
    public class CategoryConfiguration:IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // ID
            builder.HasKey(c => c.Id);

            // Name
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(150);

            // Description
            builder.Property(c => c.Description)
                .IsRequired(false)
                .HasMaxLength(500);

            // CreatedOn
            builder.Property(c => c.CreatedOn)
                .IsRequired();

            // ModifiedOn
            builder.Property(c => c.ModifiedOn)
                .IsRequired(false);

            // Relationships
            builder.HasMany<Product>(c=>c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            // Table name
            builder.ToTable("Categories");
        }
    }
}
