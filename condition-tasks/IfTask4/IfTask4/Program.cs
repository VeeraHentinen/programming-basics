using System;

namespace IfTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma lajittelee 3 lukua nousevaan järjestykseen");
            Console.Write("Syötä 1. luku: ");
            string userInput = Console.ReadLine();
            int x = int.Parse(userInput);

            Console.Write("Syötä 2. luku: ");
            userInput = Console.ReadLine();
            int y = int.Parse(userInput);

            Console.Write("Syötä 3. luku: ");
            userInput = Console.ReadLine();
            int z = int.Parse(userInput);

            if (x>y)
            {
                if (y > z)
                    Console.WriteLine($"Syötit luvut {z} - {y} - {x}");
                else
                {
                    if (z < x)
                        Console.WriteLine($"Syötit luvut {y} - {z} - {x}");
                    else
                        Console.WriteLine($"Syötit luvut {y} - {x} - {z}");
                }
            }
            else
            {
                if (x > z)
                    Console.WriteLine($"Syötit luvut {z} - {x} - {y}");
                else
                {
                    if (y > z)
                        Console.WriteLine($"Syötit luvut {x} - {z} - {y}");
                    else
                        Console.WriteLine($"Syötit luvut {x} - {y} - {z}");

                }
            }
                

                
               
            

        }
    }
}
