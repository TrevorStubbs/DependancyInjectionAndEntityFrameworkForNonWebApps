using AddingEFToANonASPProgram.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddingEFToANonASPProgram.Data
{
    class HostDbContext : DbContext
    {

        public HostDbContext(DbContextOptions<HostDbContext> options) : base(options)
        {
        }

        public DbSet<Greeting> Greetings { get; set; }

    }
}
