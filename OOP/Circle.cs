using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Circle
    {
        //Task Cearte circle class 
        //radius, perimeter, area 
        // two constraucots
        //mathode calculate the area 
        //Diameter of a Circle ⇒ D = 2 × r, where 'r' is the radius; Circumference of a circle ⇒ C = 2 × π × r, where 'r' is the radius; Area of a circle ⇒ A = π × r2
        
        public double Radius { get; set; }
        public double Circumference { get; set; }
        public double Diameter { get; set; }
        public double Area { get; set; }

        public Circle() 
        {
        }

        public Circle(double dblRadius)
        {
            Radius = dblRadius;
        }

        public void AreaCal()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine($"Area: {Area}");
        }

        public void DiameterCal()
        {
            Diameter = Radius * 2;
            Console.WriteLine($"Diameter: {Diameter}");
        }
        public void CircumferenceCal()
        {
            Circumference = Math.PI * Radius * 2;
            Console.WriteLine($"Circumference: {Circumference}");
        }

    }
}
