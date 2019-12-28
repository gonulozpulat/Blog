using Blog.Dal.Database;
using Blog.Entities.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Blog.Dal.Repository
{
    public class CategoryRepository
    {
        public List<Category> GetAllCategories()
        {
            List<Category> categories;
            using(var database = new ProjectContext())
            {
                categories = database.Categories.ToList();
            }
            return categories;
        }

        public Category GetCategory(int Id)
        {
            Category category;
            using(var database = new ProjectContext())
            {
                category = database.Categories.FirstOrDefault(i => i.Id.Equals(Id));
            }
            return category;
        }

        //Admin Panel Edit Category
        public bool EditCategory(Category category)
        {
            using(var database = new ProjectContext())
            {
                database.Entry(category).State = EntityState.Modified;
                return database.SaveChanges() > 0;
            }
        }

        //Admin Panel Add Category
        public Category AddCategory(Category category)
        {
            using(var database= new ProjectContext())
            {
                category = database.Categories.Add(category);
                database.SaveChanges();
            }
            return category;
        }
    }
}
