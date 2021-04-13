using System;

namespace Schoenverkoper
{
    class Program
    {
        static void Main(string[] args)
        {
            HowManyShoes();
        }
        static void HowManyShoes()
        {
            int totalprice;
            Console.WriteLine("After how many shoes do we give a discount?");
            int discountAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many shoes would you like to buy?");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount >= discountAmount)
            {
                totalprice = (amount- discountAmount) * 10 + discountAmount * 20;
                Console.WriteLine($"{amount} shoes will cost you {totalprice} euro");
            }
            else
            {
                totalprice = amount * 20;
                Console.WriteLine($"{amount} shoes will cost you {totalprice} euro");
            }
        }
    }
}
