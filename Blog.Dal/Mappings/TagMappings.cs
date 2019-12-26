using Blog.Entities.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Blog.Dal.Mappings
{
    public class TagMappings : EntityTypeConfiguration<Tag>
    {
        public TagMappings()
        {
            ToTable("Tags");
            HasKey(i => i.Id);
            Property(i => i.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar");

            //CompozitKey many-many table
            HasMany(x => x.Articles).WithMany(y => y.Tags).Map(t =>
            {
                t.ToTable("ArticleTag");
                t.MapLeftKey("TagId");
                t.MapRightKey("ArticleId");
            });
        }
    }
}
