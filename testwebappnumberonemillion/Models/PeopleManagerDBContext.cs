using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace testwebappnumberonemillion.Models
{
    public class PeopleManagerDBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PeopleManagerDBContext() : base("name=PeopleManagerDBContext")
        {
        }

        public System.Data.Entity.DbSet<testwebappnumberonemillion.Models.Person> People { get; set; }

        public System.Data.Entity.DbSet<testwebappnumberonemillion.Models.Group> Groups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
                .HasMany(m => m.Members);
            base.OnModelCreating(modelBuilder);
        }
    }
}
