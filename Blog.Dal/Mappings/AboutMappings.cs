using Blog.Entities.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Blog.Dal.Mappings
{
    public class AboutMappings : EntityTypeConfiguration<About>
    {
        public AboutMappings()
        {
            ToTable("About");
            HasKey(i => i.Id);
            Property(i => i.Title).IsRequired().HasMaxLength(100).HasColumnType("varchar");
            Property(i => i.Content).IsRequired().HasMaxLength(3000).HasColumnType("varchar");
            Property(i => i.ImagePathUrl).IsRequired().HasMaxLength(50).HasColumnType("varchar");
        }

    }
}
