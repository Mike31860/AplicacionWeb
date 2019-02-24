using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MiguelRomeroWeb.Models
{
    public class MiguelRomeroWebContext : DbContext
    {
        public MiguelRomeroWebContext (DbContextOptions<MiguelRomeroWebContext> options)
            : base(options)
        {
        }

        public DbSet<MiguelRomeroWeb.Models.ClienteInfo> ClienteInfo { get; set; }
    }
}
