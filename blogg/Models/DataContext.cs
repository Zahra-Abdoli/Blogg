using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogg.Models
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> option) : base(option)

        {

            }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
