using Blog.Dal.Mappings;
using Blog.Entities.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Blog.Dal.Database
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Database.Connection.ConnectionString = @"Server=CASPERNIRVANA\SQLEXPRESS;Database=BlogDb;User Id=gonul; Password = 123;";
            var value = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<About> About { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new AboutMappings());
            modelBuilder.Configurations.Add(new ArticleMappings());
            modelBuilder.Configurations.Add(new CategoryMappings());
            modelBuilder.Configurations.Add(new CommentMappings());
            modelBuilder.Configurations.Add(new ContactMappings());
            modelBuilder.Configurations.Add(new TagMappings());
            modelBuilder.Configurations.Add(new UserMappings());
        }
    }
}
