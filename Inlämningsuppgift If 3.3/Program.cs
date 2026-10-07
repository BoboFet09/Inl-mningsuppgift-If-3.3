using System;
namespace Inlämning_3_3
{
    class program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int timmar = int.Parse(Console.ReadLine());
            if (timmar * 80 <= 950)
            {
                Console.WriteLine("Du får hyra bilen i " + timmar + " timmar för " + timmar * 80 + "kr");

            }
            else if (timmar * 80 > 950)
            {
                Console.WriteLine("Du får inte hyra bilen så länge");
            }
            else
            {
                Console.WriteLine("Något gick fel, försök igen.");
            }

            



        }

    }
}
