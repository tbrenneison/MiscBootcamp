using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectPractice
{ 
    
    class Program
    {
        static void Main(string[] args)
        {
            Dog thisDog = new Dog(); //calling default constructor in class Dog  
            Console.WriteLine("This dog's name is " + thisDog.Name + "."); //Phydeaux (default)
            Console.WriteLine("The dog is " + thisDog.Color + "."); //black (default)

            Console.WriteLine(); 

            Dog sparky = new Dog("Sparky", "sable"); //makes a sable dog named Sparky
            Console.WriteLine(sparky.Name + " is a " + sparky.Color + " dog.");

            Dog klaus = new Dog("Kluas", "blonde"); //klaus is a blonde dog 
            //klaus is misspelled
            klaus.Name = "Klaus"; //rename klaus 

            Console.WriteLine(); 

            sparky.Woof(); //make sparky say woof 
            thisDog.Woof(); //make thisDog say woof
            klaus.Woof(); //make klaus say woof 

            Console.WriteLine();

            sparky.Wag(); //make sparky wag his tail 

        }//end of Main method

    }//end of class Program

    class Dog
    {
        //fields (private access modifier, only available to this class)
        private string name;
        private string color;

        public string Name //property "Name"
        {
            get
            {
                return this.name; //explicitly 'this' 
            }
            set
            {
                this.name = value; 
            }
        }

        public string Color //property "Color"
        {
            get
            {
                return color;  //you can do it without 'this' since 'this' is implied 
            }
            set
            {
                color = value; 
            }
        }

        //constructors, same as name of class *** 

        public Dog() //default constructor, all default dogs will be black and named Phydeaux 
        {
            this.Color = "black";
            this.Name = "Phydeaux";
        }
        
        public Dog(string name, string color)
        {
            this.name = name; //this name (for the object) is string "name" passed in from elsewhere
            this.color = color;
        }

        //methods 

        public void Woof()
        {
            System.Console.WriteLine("{0} the {1} dog says \"woof\".", name, color);
        }

        public void Wag()
        {
            System.Console.WriteLine("{0} is wagging their tail.", name); 
        }

    }//end of class Dog 
}
