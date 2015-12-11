using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testwebappnumber27.Models
{
    public class Person
    {

        public virtual int PersonId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual IList<Group> Groups { get; set; }

    }
}