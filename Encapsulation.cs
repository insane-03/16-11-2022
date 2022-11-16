using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP
{
    internal class Encapsulation
    {
        public Encapsulation() {}

        private string _authToken;

        public string PAuthToken
        {
            /*get{
                return _authToken;
            }
            set{
                _authToken = PAuthToken;
            }*/
            get => _authToken;
            set => _authToken = value;
        }
    }

    class App
    {
        public App() {
            Console.WriteLine("\n HEYY THIS IS ENCAPSULATION\n");
        }
        static void Main(string[] args) {
            App app = new App();
            
            Encapsulation EncapObj = new Encapsulation();
            do
            {
                Console.Write("\nDO YOU WHAT TO ADD THE AUTHTOKEN PRESS \"1\"(OR) TO VIEW AUTHTOKEN  PRESS \"2\" (OR) TO EXIT PRESS  \"0\": ");
                string Check = Console.ReadLine();
                if (Check == "0")
                {
                    break;
                }
                else if (Check == "2")
                {
                    Console.Clear();
                    Console.Write("\nHERE YOUR AUTHTOKEN:"+ EncapObj.PAuthToken);

                }else if (Check == "1")
                {
                    Console.Clear();
                    Console.Write("\nENTER YOUT AUTHTOKEN:");
                    EncapObj.PAuthToken = Console.ReadLine();
                    Console.WriteLine("\nWE UPDATED YOUR AUTHTOKEN YOU ENTERED:"+ EncapObj.PAuthToken);
                }else
                {
                    Console.WriteLine("YOU ENTERED THE WRONG OPTION");
                }

            }while(true);
            
            Console.ReadKey();
        }
    }
}
