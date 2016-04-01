using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Serializer.Logic;

namespace Serializer.Tests
{
    public class Kitten
    {
        public string Name;
        [XmlName("Owner")]
        public Person Master;
        public bool Hunger;

        public Kitten(string name, Person master, bool hunger)
        {
            this.Name = name;
            this.Master = master;
            this.Hunger = hunger;
        }
    };

    public class Person
    {
        public int Age;
        public string Name;

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }



    };
}
