using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OneToMany.Models;

namespace OneToMany.Models
{
    public class OneToManyContext : DbContext
    {
        public OneToManyContext(DbContextOptions<OneToManyContext> options)
            : base(options)
        {
        }

        public DbSet<OneToMany.Models.Grade> Grade { get; set; }

        public DbSet<OneToMany.Models.Student> Student { get; set; }



    }
}


