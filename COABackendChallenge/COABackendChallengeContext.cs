using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using COABackendChallenge.Models;

namespace COABackendChallenge
{
    public class COABackendChallengeContext : DbContext
    {
        public COABackendChallengeContext (DbContextOptions<COABackendChallengeContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
