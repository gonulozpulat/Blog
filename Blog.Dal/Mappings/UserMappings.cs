using Blog.Entities.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Blog.Dal.Mappings
{
    public class UserMappings : EntityTypeConfiguration<User>
    {
        public UserMappings()
        {
            ToTable("User");
            HasKey(i => i.Id);
            Property(i => i.Name).HasMaxLength(50).IsRequired().HasColumnType("varchar");
            Property(i => i.Surname).HasMaxLength(50).IsRequired().HasColumnType("varchar");
            Property(i => i.Password).HasMaxLength(16).IsRequired().HasColumnType("varchar");
            Property(i => i.Email).HasMaxLength(60).IsRequired().HasColumnType("varchar");
        }
    }
}
