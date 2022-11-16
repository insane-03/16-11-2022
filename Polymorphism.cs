using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP
{
    internal class Polymorphism
    {

        public Polymorphism() {
            Console.WriteLine("HI THIS IS POLYMORPHISM");
        }

        static void DisplayName(string Name) {
            Console.WriteLine("HEY"+" " + Name+"\n");
        }
        static void DisplayName(int Age) {
            Console.WriteLine("we added your age in our database: "+Age);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            var Input1 = Console.ReadLine();
            Console.Write("Enter your Age:");
            var Input2 = Convert.ToInt32(Console.ReadLine());
            DisplayName(Input1);
            DisplayName(Input2);

            Console.ReadKey();
        }
    }
}
