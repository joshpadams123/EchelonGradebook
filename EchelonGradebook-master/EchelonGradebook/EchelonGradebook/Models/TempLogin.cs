using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EchelonGradebook.Models
{
    public class TempLogin : ILoginRepository
    {
        public IEnumerable<Login> Login => new List<Login>
        {
            new Login {username="JoshAdams", password="a,plain3"}
        };
    }
}
