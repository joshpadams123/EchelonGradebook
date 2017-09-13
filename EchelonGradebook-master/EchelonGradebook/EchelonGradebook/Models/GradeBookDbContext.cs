using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EchelonGradebook.Models
{
    public class GradeBookDbContext : DbContext
    {
        public GradeBookDbContext(DbContextOptions<GradeBookDbContext> options) : base(options) { }
        public DbSet<Login> Login { get; set; }
    }
}
