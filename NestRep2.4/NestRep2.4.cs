using System;

namespace NestedRepetion2_4_DanDavison
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Please enter how many lines!");
            
            int number = int.Parse(Console.ReadLine());

            string name = "X ";
            int counter = number;


            while (counter  >0)
            {
                for(int counter2 = counter; counter2 <number; counter2++)
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