using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ScaffoldingTests.Models
{
    public class ScaffoldingTestsContext : DbContext
    {
        public ScaffoldingTestsContext (DbContextOptions<ScaffoldingTestsContext> options)
            : base(options)
        {
        }

        public DbSet<ScaffoldingTests.Models.Person> Person { get; set; }
    }
}
