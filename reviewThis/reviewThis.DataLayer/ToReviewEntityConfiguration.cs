using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using reviewThis.Model;
namespace reviewThis.DataLayer
{
    public class ToReviewEntityConfiguration : EntityTypeConfiguration<ToReviewEntity>
    {

        public ToReviewEntityConfiguration()
        {
            Property(tr=>tr.Name).HasMaxLength(30).IsRequired();
            Property(tr => tr.Description).HasMaxLength(700).IsOptional();
            Property(tr => tr.Link).HasMaxLength(100).IsOptional();
        }

    }
}
