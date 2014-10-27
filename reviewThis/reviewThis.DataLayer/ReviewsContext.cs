using reviewThis.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewThis.DataLayer
{


      public class ReviewsContext : DbContext
      {
          public ReviewsContext()
              : base("ReviewConnectionString")
          {

          }

          public DbSet<ToReviewEntity> ReviewEntity { get; set; }


          protected override void OnModelCreating(DbModelBuilder modelBuilder)
          {
              modelBuilder.Configurations.Add(new ToReviewEntityConfiguration());
          }

      }

    
}
