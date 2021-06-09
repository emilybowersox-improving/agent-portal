using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Agent_Portal.Models;

namespace Agent_Portal.Data
{
    public class Agent_PortalContext : DbContext
    {
        public Agent_PortalContext (DbContextOptions<Agent_PortalContext> options)
            : base(options)
        {
        }

        public DbSet<Agent_Portal.Models.Agent> Agent { get; set; }
    }
}
