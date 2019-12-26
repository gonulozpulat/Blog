using Blog.Entities.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Blog.Dal.Mappings
{
    public class ContactMappings : EntityTypeConfiguration<Contact>
    {
        public ContactMappings()
        {
            ToTable("Contacts");
            HasKey(i => i.Id);
            Property(i => i.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(i => i.Surname).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(i => i.Email).IsRequired().HasMaxLength(60).HasColumnType("varchar");
            Property(i => i.Message).IsRequired().HasMaxLength(500).HasColumnType("varchar");
        }
    }
}
