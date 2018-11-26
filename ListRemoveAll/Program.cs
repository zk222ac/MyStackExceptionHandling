using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRemoveAll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>(){{new Person("1","Henrik")}, {new Person("2", "Poul")}, {new Person("3", "Lars")}, {new Person("2", "Poul")}};

            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }   


            //Notice: Its not allowed to change the size/indexes in a collection under the iteration:

            //foreach (Person person in persons)
            //{
            //    if (person.Id == "2")
            //        persons.Remove(person);
            //}

            // Its ok to update the content of the collection
            foreach (Person person in persons)
            {
                if (person.Id == "3")
                    person.Name="Viggo";
            }

            Person p1 = new Person("1", "Henrik");
            foreach (var p2 in persons)
            {
                Console.WriteLine(p2.Equals(p1));
            }
            
            


            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();

            var p = new Person("2", "Poul");
            persons.RemoveAll(item => item.Equals(p));

            var id = "3";
            var name = "Mr. Bond";

            persons.Find((Person per) => { return per.Id.Equals(id); }).Name = name;
            
            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
