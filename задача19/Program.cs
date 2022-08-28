using System;

namespace задача19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пятизначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temporary = num;
            int dig = 0;
            int reverse = 0;
            while(num > 0)
            {
                dig = num % 10;
                reverse = reverse * 10 + dig;
                num = num /10;
            }
            if(temporary == reverse)
            {
                Console.WriteLine("Это палиндром!");
            }
            else
            {
                Console.WriteLine("Это не палиндром!");
            }

        }
    }
}
