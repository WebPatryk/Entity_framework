using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entity_framework.Models;

namespace Entity_framework.Data
{
    public class Entity_frameworkContext : DbContext
    {
        public Entity_frameworkContext (DbContextOptions<Entity_frameworkContext> options)
            : base(options)
        {
        }

        public DbSet<Entity_framework.Models.Games> Games { get; set; }
    }
}
