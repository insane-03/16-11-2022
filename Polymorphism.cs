using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP
{   public class PolymorphismBase
    {
        public virtual void Display()
        {
            Console.WriteLine("HEY THIS IS BASE CLASS DISPLAY");
        }
    }
    public class Polymorphism : PolymorphismBase
    {   
        public override void Display()
        {
            Console.WriteLine("HEY THIS IS DERVIED CLASS DISPLAY");
        }
        public Polymorphism() {
            Console.WriteLine("HI THIS IS POLYMORPHISM");
        }

        public void DisplayName(string Name) {
            Console.WriteLine("HEY"+" " + Name+"\n");
        }
        public void DisplayName(int Age) {
            Console.WriteLine("we added your age in our database: "+Age);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            var Input1 = Console.ReadLine();
            Console.Write("Enter your Age:");
            var Input2 = Convert.ToInt32(Console.ReadLine());

            Polymorphism obj = new Polymorphism();
            PolymorphismBase obj1 = new PolymorphismBase();
            Console.WriteLine("-------------------");
            obj.DisplayName(Input1);
            obj.DisplayName(Input2);
            obj.Display();
            obj1.Display();


            Console.ReadKey();
        }
    }
}
