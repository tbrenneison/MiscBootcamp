using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testwebappnumberonemillion.Models
{
    public class Group
    {
        public virtual int GroupId { get; set; }
        public virtual string GroupName { get; set; }
        public virtual List<Person> Members { get; set; }

    }
}