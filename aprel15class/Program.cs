using System;

namespace aprel15class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test test = new Test();
            //test.Arr[0] = 1;
            //for (int i = 0; i < test.Arr.Length; i++)
            //{
            //    Console.WriteLine(test.Arr[i]);
            //}


            //foreach (var item in typeof(Test).GetProperties())
            //{
            //    Console.WriteLine(item.Name);
            //}



            //Person person = CreatePerson();

            //Console.WriteLine(person.Name);


            do
            {
                Console.WriteLine("Please enter Name:");
                string name = Console.ReadLine();
                try
                {
                    Person person = new Person(name);
                    Console.WriteLine(person.Name);
                    break;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);

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
