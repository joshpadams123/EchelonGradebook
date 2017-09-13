using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EchelonGradebook.Models
{
    public class EfLoginRepository : ILoginRepository
    {
        private GradeBookDbContext context;
        public EfLoginRepository(GradeBookDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Login> Login => context.Login;
    }
}
