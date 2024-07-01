using ECommerceApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceApp.EntityFramework.Configurations
{
    public class ProductConfiguration:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
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

            // Price
            builder.Property(c => c.Price)
                .IsRequired();

            // Stock
            builder.Property(c => c.Stock)
                .IsRequired();

            // CreatedOn
            builder.Property(c => c.CreatedOn)
                .IsRequired();

            // ModifiedOn
            builder.Property(c => c.ModifiedOn)
                .IsRequired(false);

            // Relationships
           //builder.HasOne<Category>(p => p.Category)
           //    .WithMany(c => c.Products)
           //    .HasForeignKey(p => p.CategoryId);

            // Table name
            builder.ToTable("Products");
        }
    }
}
