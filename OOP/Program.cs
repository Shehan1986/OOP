using static System.Console;
namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Person p1 = new Person();

            p1.FirstName = "Shehan";
            p1.LastName = "Perera";


            WriteLine(p1.LastName);
            WriteLine(p1.PNumber);

            Person p2 = new Person("Jhone", "Perera");
            Person p3 = new Person("Saman", "Silva");

            Person p4 = new Person();
            p4.Gender = "Male";

            p1.Introduce();
            p2.Introduce();
            p3.Introduce();

            WriteLine(p1);
            WriteLine(p2);
            WriteLine(p3);



            //person.pNumber = "33333333"; can not set becouse set is privet  -- { get; private set; }

            Circle cl1 = new Circle();
            cl1.Radius = 30;
            cl1.AreaCal();
            cl1.DiameterCal();
            cl1.CircumferenceCal();

            Circle cl2 = new Circle(30);
            cl2.AreaCal();
            cl2.DiameterCal();
            cl2.CircumferenceCal();

            ReadKey();
        }
    }
}
