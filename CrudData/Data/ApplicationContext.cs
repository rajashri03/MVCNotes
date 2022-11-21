using CrudData.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudData.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
