using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeSchool
{
    class School
    {
        public IDictionary<int, List<string>> Roster { get; set; }

        public School()
        {
            this.Roster = new Dictionary<int, List<string>>();
        }

        internal void Add(string name, int grade)
        {
            if (!this.Roster.ContainsKey(grade))
            {
                this.Roster.Add(grade, new List<string>());
            }

            if (!this.Roster[grade].Contains(name))
            {
                this.Roster[grade].Add(name);
            }

            this.Roster[grade].Sort();
        }

        internal List<string> Grade(int grade)
        {
            if (!this.Roster.ContainsKey(grade))
            {
                this.Roster.Add(grade, new List<string>());
            }

            return this.Roster[grade];
        }
    }


}
