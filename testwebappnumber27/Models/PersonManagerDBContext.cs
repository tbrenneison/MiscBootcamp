using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace testwebappnumber27.Models
{
    public class PersonManagerDBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PersonManagerDBContext() : base("name=PersonManagerDBContext")
        {
        }

        public System.Data.Entity.DbSet<testwebappnumber27.Models.Person> People { get; set; }
        public System.Data.Entity.DbSet<testwebappnumber27.Models.Group> Groups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Group>()
                .HasMany(m => m.Members).WithMany(p => p.Groups)
                .Map(t => t.MapLeftKey("GroupId")
               .MapRightKey("PersonId")
               .ToTable("GroupPerson"));
            base.OnModelCreating(modelBuilder); 
            

        }
    }
}
