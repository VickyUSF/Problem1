using System;

namespace Stuck_In_A_Time_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int count = 1;

            if (N >= 1 && N <= 100)
            {
                while (count <= N)
                {
                    Console.Write(count + " Abracadabra");
                    Console.WriteLine();
                    count = count + 1;
                }
            }
            else
            {
                Console.Write("Please use integar between 1 and 100!!!!");
            
            }

        }
    }
}
