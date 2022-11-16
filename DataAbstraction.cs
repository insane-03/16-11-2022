using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP
{
    public abstract class DataAbstraction
    {
        public abstract void Entry();
        public abstract void Exit();
    }

    class Office : DataAbstraction
    {   
        public Office()
        {
            Console.WriteLine("\nHEY THIS IS DATA_ABSTRACTION");
        }
        public override void Entry()
        {
            Console.WriteLine("\nNOTED ! YOUR ENTERY");
        }
        public override void Exit()
        {
            Console.WriteLine("\nNOTED ! YOUR EXIT");
        }

        static void Main(string[] args)
        {
            Office OfficeObj = new Office();
            OfficeObj.Entry();
            Console.WriteLine(".\n.\n.\n.\n.\n.\n");
            OfficeObj.Exit();
            
            Console.ReadKey();
        }


    }
}
