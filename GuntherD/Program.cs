using System;

namespace GuntherD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you work often? False for no, True for yes");
            bool answer = Convert.ToBoolean(Console.ReadLine());
            if (!answer)
            {
                Console.WriteLine("Do you like quinoa? False for no, True for yes");
                answer = Convert.ToBoolean(Console.ReadLine());

                if (answer)
                {
                    Console.WriteLine("You should vote for 'Groen'");
                }
                else
                {
                    Console.WriteLine("Is everything your fault? False for no, True for yes");
                    answer = Convert.ToBoolean(Console.ReadLine());

                    if (answer)
                    {
                        Console.WriteLine("You should vote for SP.A");
                    }
                    else
                    {
                        Console.WriteLine("You should vote for PVDA");
                    }

                }

            }
            else
            {
                Console.WriteLine("Have you ever bought brown bread? False for no, True for yes");
                answer = Convert.ToBoolean(Console.ReadLine());

                if (answer)
                {
                    Console.WriteLine("Are you a nerd? False for no, True for yes");
                    answer = Convert.ToBoolean(Console.ReadLine());

                    if (answer)
                    {
                        Console.WriteLine("You should vote for CD&V");
                    }
                    else
                    {
                        Console.WriteLine("You should vote for NVA");
                    }
                }
                else 
                {
                    Console.WriteLine("You should vote for Vlaams Belang");
                }
            }
        }
    }
}
