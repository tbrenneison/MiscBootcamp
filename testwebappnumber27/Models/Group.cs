using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testwebappnumber27.Models
{
    public class Group
    {
        public virtual int GroupId { get; set; }
        public virtual string Name { get; set;  }
        public virtual IList<Person> Members { get; set; }

    }
}