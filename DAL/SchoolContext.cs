using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using homework2.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace homework2.DAL
{
    public class SchoolContext : DbContext
    {

        public SchoolContext() : base("SchoolContext")
        {
        }

  ///      public DbSet<Student> Students { get; set; }
     //   public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<homework2.Models.Section> Sections { get; set; }
    }
}