using System;
using System.Threading;

namespace Sayilamaca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Main: " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Uygulamaya hoşgeldiniz..");

            Thread thread = new Thread(IlkDongu);
            thread.Start();

            for (int i = 9000; i < 10000; i++)
            {
                // Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }

        static void IlkDongu()
        {
            //Console.WriteLine("Ilkdongu: " + Thread.CurrentThread.ManagedThreadId);
            // ilk for ayrı bir thread'de çalışsın
            for (int i = 0; i < 1000; i++)
            {
                // Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(i + " ");
            }
        }
    }
}
