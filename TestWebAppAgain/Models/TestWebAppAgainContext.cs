using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestWebAppAgain.Models
{
    public class TestWebAppAgainContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TestWebAppAgainContext() : base("name=TestWebAppAgainContext")
        {
        }

        public System.Data.Entity.DbSet<TestWebAppAgain.Models.Person> People { get; set; }

        public System.Data.Entity.DbSet<TestWebAppAgain.Models.Group> Groups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Person>()
                        .HasMany<Group>(s => s.Groups)
                        .WithMany(c => c.Members)
                        .Map(cs =>
                        {
                            cs.MapLeftKey("PersonId");
                            cs.MapRightKey("GroupId");
                            cs.ToTable("PersonGroups");
                        });

        }
    }
}
