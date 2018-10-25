using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise47
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userContinue = true;
            var list = new List<string>();
            while(userContinue)
            {
                Console.Write("Enter some text: ");
                list.Add(Console.ReadLine());
                Console.Write("You have entered: ");
                foreach (var word in list)
                {
                Console.Write($"{word} ");
                }
                Console.WriteLine();
                Console.Write("Would you like to continue (y/n): ");
                userContinue = Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase);
            }          
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}
