using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marriornot
{
    public class Person
    {
        public bool marry_or_not { get; set; }
        public string name { get; set; }
    }

    public class Marriage
    {
        public string Partner1 { get; set; }
        public string Partner2 { get; set; }

        public Marriage(string partner1, string partner2)
        {
            Partner1 = partner1;
            Partner2 = partner2;
        }
    }

    public class MarriageHelper
    {
        public static Marriage CreateMarriage(string partner1, string partner2)
        {
            return new Marriage(partner1, partner2);
        }

        public static Marriage CreateMarriageWithPerson(string partner1, Person person)
        {
            if (person.marry_or_not)
            {
                return new Marriage(partner1, person.name);
            }
            else
            {
                return null;
            }
        }
    }
}
