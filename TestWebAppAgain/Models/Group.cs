using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebAppAgain.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<Person> Members { get; set; }

        public Group()
        {
            this.Members = new HashSet<Person>(); 
        }
    }
}