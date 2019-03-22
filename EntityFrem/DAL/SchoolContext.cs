using EntityFrem.DAL.Mappings;
using EntityFrem.Domains;
using System.Data.Entity;

namespace EntityFrem.DAL
{
    public class SchoolContext:DbContext
    {
        public SchoolContext() : base("SchoolDb-CodeFirst")
        {
            Database.SetInitializer<SchoolContext>(new SchoolDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations for Student from separate class
            modelBuilder.Configurations.Add(new StudentMapping());

            modelBuilder.Entity<Teacher>()
                .ToTable("TeacherInfo");

            modelBuilder.Entity<Teacher>()
                .MapToStoredProcedures();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
