using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcApplication4.Models
{
    public class AyanaContext:DbContext
    {
    public AyanaContext():base("mynew")
        {
            DropCreateDatabaseIfModelChanges<AyanaContext> d = new DropCreateDatabaseIfModelChanges<AyanaContext>();
            Database.SetInitializer<AyanaContext>(d);

       }

    public DbSet<UserDemo> UserDemos { get; set; }

    public DbSet<Stud> Studs { get; set; }
    }
    }