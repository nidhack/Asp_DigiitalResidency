using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Mvcp.Models
{
    public class Pk : DbContext
    {
        public Pk()
            : base("usercon")
        {
        DropCreateDatabaseIfModelChanges<Pk> p= new DropCreateDatabaseIfModelChanges<Pk>();
        Database.SetInitializer<Pk>(p);
    }
        public DbSet<UserDemo> UserDemos { get; set; }
    }
}