using System.Text;

namespace PasswordManagerEnc
{
    internal class Program
    {
        


        static void view(string objName)
        {
            Console.Clear();
            Console.WriteLine("\n<<<<<<<<<<<<<p -----PASSWORD MANAGER [ENCODING] $ Welcome," + objName + "------ >>>>>>>>>>>>>>");
            Console.Write("\n\nEnter the password to encode:");
            string password = Console.ReadLine();
            Hash objen = new Hash();
            objen.enCode(password);
        }

        public void Nuser(string objName)
        {
            
        }
        static int Ccheck()
        {   
            Console.Clear();
            Console.Write("\nTo continue press 1 or press 2 :");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {   
            Console.WriteLine("\n<<<<<<<<<<<<< -----PASSWORD MANAGER [ENCODING]------ >>>>>>>>>>>>>>\n\n\n");
            do
            {
                Console.Write("\nEnter the UserName:");
                string objName = Console.ReadLine();
                string[] userarray = {"gowtham"};
                //Console.WriteLine("Hello" + objName);

                foreach (string str in userarray)
                {
                    if (str == objName)
                    {
                        view(objName);
                    }
                    else
                    {
                        Console.WriteLine("\nNeed to create new account ! Try again later ");
                        Console.WriteLine("\nCome agin:");
                        Console.ReadLine();
                    }
                }

                
                
                
                
            }while (Ccheck() == 1);
            Console.WriteLine("ok bye bye");
            Console.ReadKey();
        }
    }
}