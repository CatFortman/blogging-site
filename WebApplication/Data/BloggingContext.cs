using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebApplication.Models
{
    public class BloggingContext : DbContext
    {

        public BloggingContext(DbContextOptions<BloggingContext> options)
            :  base(options)
        {
        }

        public virtual DbSet<BlogPost> BlogPost { get; set; }
    }
}
