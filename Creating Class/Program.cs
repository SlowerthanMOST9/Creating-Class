using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Class
{

    public class Person
    {
        public string CharName;
        public int CharAge;
        public string CharWeapon;

        public void Greeting()
        {
            Console.WriteLine("You have gone on a journey, " + CharName + ". You are only " + CharAge + " and your only friend is a " + CharWeapon);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.CharName = "SlowerthanMOST99";
            person.CharAge = 17;
            person.CharWeapon = "Mace";

            person.Greeting();
            Console.ReadKey();
        }
    }
}
