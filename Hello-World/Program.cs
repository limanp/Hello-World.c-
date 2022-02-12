using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет Мир!");
            Console.WriteLine("Это моя первая программа на языке [c# за решеткой]");
            Console.WriteLine("version <0.00000000001>");
            int num = 19;
            Console.WriteLine("Мой возраст: " + num + " лет");
            if (num < 21)
            {
                Console.WriteLine("Еще не дорос");
            }
            else
            {
                Console.WriteLine("Ля, ты взрослый");
            }

        }
    }
}
