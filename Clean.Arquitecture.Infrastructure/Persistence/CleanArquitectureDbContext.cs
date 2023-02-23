using Clean.Arquitecture.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Arquitecture.Infrastructure.Persistence
{
    public class CleanArquitectureDbContext : DbContext
    {

        public CleanArquitectureDbContext(DbContextOptions<CleanArquitectureDbContext> options) :base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
