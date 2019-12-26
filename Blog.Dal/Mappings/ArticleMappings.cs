using Blog.Entities.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Blog.Dal.Mappings
{
    public class ArticleMappings : EntityTypeConfiguration<Article>
    {
        public ArticleMappings()
        {
            ToTable("Articles");
            HasKey(i => i.Id);
            Property(i => i.Title).IsRequired().HasMaxLength(100).HasColumnType("varchar");
            Property(i => i.Content).IsRequired().HasMaxLength(4000).HasColumnType("varchar");
            Property(i => i.ImagePathUrl).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(i => i.CreatedDate).IsRequired();
            Property(i => i.CategoryId).IsRequired();
        }
    }
}
