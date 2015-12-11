using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebAppAgain.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Group> Groups { get; set; }


        public Person()
        {
            this.Groups = new HashSet<Group>(); 
        }

    }
}