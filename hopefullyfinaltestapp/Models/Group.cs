using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hopefullyfinaltestapp.Models
{
    public class Group
    {
        public Group()
        {
            this.Members = new HashSet<Person>();
        }

        public int GroupId { get; set; }
        public virtual string GroupName { get; set; }

        public virtual ICollection<Person> Members { get; set; }

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }
    }
}