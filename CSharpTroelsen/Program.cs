using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTroelsen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            string input = Console.ReadLine();
            if (input == "123")
            {
                Console.WriteLine("Пароль верен!");

            }
            else if (input == "321")
            {
                Console.WriteLine("Наоборот!");
            }
            else
            {
                Console.WriteLine("Пароль не верен!");
            }
            Console.WriteLine("Новаястрока");

            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(num1) + Convert.ToInt32(num2));
        }
        
        
    }


   
}
