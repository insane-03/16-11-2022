using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerEnc
{
    public class Hash
    {
        public void enCode(string password)
        {
          
          byte[] passascii = Encoding.ASCII.GetBytes(password);
          string[] hash = new string[passascii.Length];

            try
            {
                for (int i = 0; i < (passascii.Length); i++)
                {
                    string result1 = Char.ToString(Convert.ToChar(passascii[i] + 3));
                    //Console.WriteLine(result1);
                    hash[i] = result1;
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString()+ " check the for loop");
            }
            
            //Console.WriteLine(hash.Length);
            Console.Clear();
            Console.Write("\nYOUR HASH CODE FOR YOUR PASSWORD: "+ string.Join("", hash));
            
            Console.ReadKey();
            
        }
    }
}
