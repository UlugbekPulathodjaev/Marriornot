using Marriornot;
using System;

namespace Marriorno
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person { name = "John", marry_or_not = false };

            Marriage marriage1 = MarriageHelper.CreateMarriageWithPerson("Jane", person1);

            if (marriage1 == null)
            {
                Console.WriteLine("The person is not married.");
            }
            else
            {
                Console.WriteLine("{0} is married to {1}.", marriage1.Partner1, marriage1.Partner2);
            }
        }
    }
}