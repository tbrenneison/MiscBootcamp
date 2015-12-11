using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testwebappnumberonemillion.Models
{
    public class Person
    {
        public virtual int PersonId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string Lastname { get; set; }
    }
}