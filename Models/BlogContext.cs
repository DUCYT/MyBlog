using Microsoft.EntityFrameworkCore;

namespace MyBlog.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ContactModel> Contacts { get; set; }
    }
}
 