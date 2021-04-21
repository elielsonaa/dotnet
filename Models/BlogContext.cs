using Microsoft.EntityFrameworkCore;

namespace BlogApi.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options){

        }
        public DbSet<BlogPost> BlogPosts {get; set;}
        public DbSet<Comment> Comments { get; set; }
    }
}