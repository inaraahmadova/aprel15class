using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel15class
{
    internal class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (CheckName(value))
                {
                    _name = value;
                }
            }
        }
        public Person(string name)
        {
            Name = name;
        }
        static bool CheckName(string name)
        {
            if (name.Length < 3 || name.Length > 25)
            {
                throw new Exception("Wrong size");
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    throw new Exception("Wrong type of characters");
                }
            }
            return true;
        }
        public static Person CreatePerson()
        {
            Console.WriteLine("Please enter Name:");
            string name = Console.ReadLine();
            try
            {
                Person person = new Person(name);
                return person;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return CreatePerson();
            }
        }
    }
}
