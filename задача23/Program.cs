using System;

namespace задача23
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.Write("Введите число: ");
                int cube = Convert.ToInt32(Console.ReadLine());
                int counter = 0;
                int result = 0;

                while(counter<=cube)
                {
                    Console.Write(result+", ");
                    result =counter*counter*counter;
                    counter++;
                }
            Console.WriteLine(result);
        }
    }
}
