using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testwebappnumber27.Models
{
    public class PeopleManagerDBInitializer : System.Data.Entity.DropCreateDatabaseAlways<PersonManagerDBContext>
    {
        protected override void Seed(PersonManagerDBContext context)
        {
            //people
            context.Groups.Add(new Group
            {
                Name = "Humans",
                Members = new List<Person>() 
            });

            //dogs
            context.Groups.Add(new Group
            {
                Name = "Dogs",
                Members = new List<Person>()
            });

            context.SaveChanges();

            context.People.Add(new Person { FirstName = "Tori", LastName = "Brenneison" });
            context.People.Add(new Person { FirstName = "Angua", LastName = "Brenneison" });
            context.People.Add(new Person { FirstName = "Torrey", LastName = "Pines" });

            context.SaveChanges();

            
            

            base.Seed(context);
        }

        void AddToGroupMemberList(PersonManagerDBContext context, string PersonFirstName, string GroupName)
        {
            var grp = context.Groups.SingleOrDefault(g => g.Name == GroupName);
            var pers = context.People.SingleOrDefault(p => p.FirstName == PersonFirstName);

            if (pers == null)
            {
                grp.Members.Add(context.People.Single(p => p.FirstName == PersonFirstName)); //add person to group members 
            }

        }   
    }
}