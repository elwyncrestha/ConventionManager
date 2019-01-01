using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ConventionManager.Model
{
    public class ConventionManagerDbContext:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Attendee> Attendees { get; set; }

        public DbSet<Stall> Stalls { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Event> Events { get; set; }
    }
}
