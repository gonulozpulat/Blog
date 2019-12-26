using Blog.Dal.Database;
using Blog.Entities.Entities;
using System.Data.Entity;
using System.Linq;

namespace Blog.Dal.Repository
{
    public class AboutRepository
    {
        public About GetAbout()
        {
            About about;
            using (var database = new ProjectContext())
            {
                about = database.About.SingleOrDefault();
            }
            return about;
        }

        public bool EditAbout(About about)
        {
            using(var database = new ProjectContext())
            {
                database.Entry(about).State = EntityState.Modified;
                return database.SaveChanges() > 0;
            }
        }
    }
}
