using System;

namespace задача21
{
    class Program
    {
        static void Main(string[] args)
        {
            string getDistance()
            {
                Console.Write("Введите X координату первой точки ");
                int firstX = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Y координату первой точки ");
                int firstY = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Z координату первой точки ");
                int firstZ = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите X координату второй точки ");
                int secondX = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Y координату второй точки ");
                int secondY = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Z координату второй точки ");
                int secondZ = Convert.ToInt32(Console.ReadLine());

                double distance = Math.Round(Math.Sqrt(Math.Pow(secondX-firstX, 2)+Math.Pow(secondY-firstY, 2)+ Math.Pow(secondZ-firstZ, 2)), 2);
                return $"расстояние между двумя точками в 3D пространстве {distance}";
            }
            try
            {
            Console.WriteLine(getDistance());
            }
            catch
            {
                Console.WriteLine("Необходимо вводить коортинаты целыми числами");    
            }
        }
    }
}
