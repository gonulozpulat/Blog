using Blog.Entities.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Blog.Dal.Mappings
{
    public class CommentMappings : EntityTypeConfiguration<Comment>
    {
        public CommentMappings()
        {
            ToTable("Comments");
            HasKey(i => i.Id);
            Property(i => i.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(i => i.Surname).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(i => i.Email).IsOptional().HasMaxLength(60).HasColumnType("varchar");
            Property(i => i.Message).IsRequired().HasMaxLength(500).HasColumnType("varchar");
            Property(i => i.ArticleId).IsRequired();
        }

    }
}
