using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EchelonGradebook.Models
{
    public interface ILoginRepository
    {
        IEnumerable<Login> Login { get; }
    }
}
