using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Model;

namespace TravelApp.DataAccess
{
   public class TravelDbContext : DbContext
    {
        public TravelDbContext() : base("name=TravelDb")
        {
            //base("Server=.;Database=StatDb;Trusted_Connection=True;")
        }

        public DbSet<User> Users { get; set; }
    }
}
