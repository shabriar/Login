using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoginPortal.Models
{
    public class LogInDbContext : DbContext
    {
        public LogInDbContext()
            : base("LoginConnString")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Bikes> Bikes { get; set; }
    }
}