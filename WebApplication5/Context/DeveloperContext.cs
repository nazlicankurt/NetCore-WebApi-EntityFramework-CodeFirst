using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Context
{
    public class DeveloperContext : DbContext
    {

        public DeveloperContext(DbContextOptions<DeveloperContext> options) : base(options)
        {
        }
        public DbSet<Model.Developer> Developer { get; set; }
        public DbSet<Model.Department> Department { get; set; }


    }

}
