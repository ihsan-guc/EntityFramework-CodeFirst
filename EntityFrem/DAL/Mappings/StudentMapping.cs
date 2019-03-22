using EntityFrem.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrem.DAL.Mappings
{
    public class StudentMapping : EntityTypeConfiguration<Student>
    {
        public StudentMapping()
        {
            this.Property(s => s.StudentName)
               .IsRequired()
               .HasMaxLength(50);

            this.Property(s => s.StudentName)
                .IsConcurrencyToken();
        }
    }
}
