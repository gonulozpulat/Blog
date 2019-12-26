using Blog.Entities.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Blog.Dal.Mappings
{
    public class CategoryMappings : EntityTypeConfiguration<Category>
    {
        public CategoryMappings()
        {
            ToTable("Categories");
            HasKey(i => i.Id);
            Property(i => i.Name).IsRequired().HasMaxLength(100).HasColumnType("varchar");
            Property(i => i.Description).IsOptional().HasMaxLength(400).HasColumnType("varchar");
            Property(i => i.ImagePathUrl).IsRequired().HasMaxLength(50).HasColumnType("varchar");
        }
    }
}
