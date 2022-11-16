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
    interface  Signup{
        void Signup();
        }
    interface DeleteAccount
    {
        void Delete();
    }
    internal class Inheritance
    {
        public Inheritance() { }
        public void Login()
        {
            Console.WriteLine("\nHEY THIS IS LOGIN FOR COMMON\n");
        }
        public void Logout() 
        { 
            Console.WriteLine("\nHEY THIS IS LOGOUT FOR COMMON\n");
        }
    }

internal class HomeScreen : Inheritance,Signup,DeleteAccount
    {
        public HomeScreen() {
        Console.WriteLine("\n>>>>>>---APP---<<<<<<");
        }
        public void ScreenWindow()
        {
        Console.WriteLine("\nHEY THIS IS MAIN SCREEN WINDOW\n");
        }

        public void Signup()
        {
            Console.WriteLine("\nHEY THIS IS SIGNUP");
        }
        public void Delete() 
        {
            Console.WriteLine("\nHEY SORRY COME BACK SOON");
        }
        static void Main(string[] args)
        {
            var obj = new HomeScreen();
            obj.ScreenWindow();
            obj.Login();
            obj.Logout();

            obj.Signup();
            obj.Delete();
            Console.WriteLine("\nI HAVE A SEALED CLASS THAT YOU CAN'T ACCESS, ONLY FOR ADMIN");

            Console.ReadKey();
        }

            
        
    }
    
}
