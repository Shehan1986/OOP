using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Person
    {
        //fields
        int _age;
        //proerty
        public string FirstName { get; set; }//gte is "to read"  // set is "To write"
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PNumber { get; private set; }
        public string Gender { get; set; }

        //constructor
        public Person()
        { 
        
        }
        public Person(string fName, string lName)
        {
                FirstName = fName;
                LastName = lName;
        }

        public Person(string FirstName, string lName, int age)
        {
            this.FirstName = FirstName;
            LastName = lName;
            Age = age;
        }

        public Person(string fName, string lName, int age, string gender)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            Gender = gender;
        }
        //method
        public void Introduce()
        {
            Console.WriteLine($"Hello! I am {FirstName} {LastName}");
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";//{FirstName} + " " + {LastName}
        }
        //destructor
    }
}
 