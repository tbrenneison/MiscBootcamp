using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hopefullyfinaltestapp.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        
        public virtual ICollection<Group> Groups { get; set; }

    }
}