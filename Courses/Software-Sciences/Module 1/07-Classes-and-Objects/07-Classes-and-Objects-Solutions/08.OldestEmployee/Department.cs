using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldestEmployee
{
    public class Department
    {
        private List<Employee> members;

        public Department()
        {
            this.members = new List<Employee>();
        }

        public void AddMember(Employee member)
        {
            this.members.Add(member);
        }

        public Employee GetOldestMember()
        {
            return this.members
                .OrderByDescending(p => p.Age)
                .First();
        }
    }
}
