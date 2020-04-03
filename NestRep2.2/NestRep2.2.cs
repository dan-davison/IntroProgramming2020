using System;

namespace NestedRepetion2_2_DanDavison
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "X ";
            int counter = 0;
            int number;

            Console.WriteLine("Please enter how many starting X's");
            
            number = int.Parse(Console.ReadLine());

            while (counter <number)
            {
                for(int counter2 = counter; counter2 <number; counter2++)
                {
                System.Console.Write(name);
                }
                System.Console.WriteLine();

                counter++;

            }

            Console.ReadKey();
      }
    }
}1