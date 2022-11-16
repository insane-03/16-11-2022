using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP
{ 
    sealed class AdminWork
{
    public void Accesscard()
    {

    }
}
    internal class Inheritance
    {
        public Inheritance() { }
        public void Login()
        {
            Console.WriteLine("HEY THIS IS LOGIN FOR COMMON\n");
        }
        public void Logout() 
        { 
            Console.WriteLine("HEY THIS IS LOGOUT FOR COMMON\n");
        }
    }

internal class HomeScreen : Inheritance
    {
        public HomeScreen() {
        Console.WriteLine(">>>>>>---APP---<<<<<<");
        }
        public void ScreenWindow()
        {
        Console.WriteLine("HEY THIS IS MAIN SCREEN WINDOW\n");
        }
        static void Main(string[] args)
        {
            var obj = new HomeScreen();
            obj.ScreenWindow();
            obj.Login();
            obj.Logout();

            Console.WriteLine("I HAVE A SEALED CLASS THAT YOU CAN'T ACCESS, ONLY FOR ADMIN");

            Console.ReadKey();
        }

            
        
    }
    
}
