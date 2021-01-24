using System;
using System.Threading;

namespace HarflerVeSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Harfler);
            t1.Start();
            //t1.Join(); // t1 thread'i kapanmadan Main threadine devam etme
            new Thread(Sayilar).Start();
            Console.WriteLine("Merhaba");

            Console.ReadKey();
        }

        private static void Harfler()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Thread.Sleep(500);
                Console.Write(c + " ");
            }
        }

        private static void Sayilar()
        {
            for (int i = 1; i <= 26; i++)
            {
                Thread.Sleep(500);
                Console.Write(i + " ");
            }
        }
    }
}
