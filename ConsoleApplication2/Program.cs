using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Collar
    {
        private int size;

        public Collar()
        { }
    }

    public class Dog
    {
        int age = 2;
        string name;
        string owner; 

        public Dog()
        {
            age = 3; 
        }

        public Dog(int age, string name, string owner)
        {
            this.age = age;
            this.name = name;
            this.owner = owner; 
        }

        public int GetAge()
        {
            return this.age; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Dog's age is " + dog.GetAge()); 
        }
    }
}
