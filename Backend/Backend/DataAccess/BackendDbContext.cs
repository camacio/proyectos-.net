using Microsoft.EntityFrameworkCore;
using System.Data;
using Backend.Models.DataModels;

namespace Backend.DataAccess
{
    public class BackendDbContext : DbContext
    {
        public BackendDbContext(DbContextOptions<BackendDbContext> options) : base(options) {
        
        }

        public DbSet<User> Users { get; set; }
    }
}
