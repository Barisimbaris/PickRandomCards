using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
         {
            Console.Write("Enter the number of cards to pick: ");
            string line= Console.ReadLine();    
           
            if (int.TryParse(line, out int numberOfCards))
            {
                foreach(string card in CardPickers.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }

            }
            else
            {
                Console.WriteLine("please enter a valid number");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


        }
    }
}
