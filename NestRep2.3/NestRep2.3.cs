using System;

namespace NestedRepetion2_3_DanDavison
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "X ";
            int counter = 5;

            while (counter >=1)
            {
                for(int counter2 = counter; counter2 <=5; counter2++)
                {
                System.Console.Write(name);
                }
                System.Console.WriteLine();

                counter--;

            }
            Console.ReadKey();
      }
    }
}