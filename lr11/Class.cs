using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lr11
{
    class Person
    {
        public String ID { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String email { get; set; }
        public float salary { get; set; }
        public String Skill { get; set; }
        public float Tax { get; set; }

        public static Person Load(String s)
        {
            while (s.IndexOf(",,") > 0)
            {
                s = s.Insert((s.IndexOf(",,") + 1), "None");
            }
            Person p = new Person();
            string[] elem = s.Split(',');
            p.ID = elem[0].Trim();
            p.LastName = elem[1].Trim();
            p.FirstName = elem[2].Trim();
            p.email = elem[3].Trim();
            p.salary = Convert.ToSingle(elem[4].TrimStart('$').Replace('.', ','));
            p.Skill = elem[5].Trim();
            p.Tax = Convert.ToSingle(elem[6].TrimStart('$').Replace('.', ','));
            return p;
        }

        public override string ToString()
        {
            String y = string.Format
                (
                "*******************\n" +
                "ID: {0}, Lastname: {1}, Name: {2}\n" +
                "E-mail: {3}, Salary: {4}, Skill: {5}, Tax: {6}",
                ID, LastName, FirstName, email, salary, Skill, Tax
                );
            return y;
        }

    }
}
