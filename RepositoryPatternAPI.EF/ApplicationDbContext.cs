using Microsoft.EntityFrameworkCore;
using RepositoryPatternAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternAPI.EF
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) {

        }

    }
}
