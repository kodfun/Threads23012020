using System;
using System.Threading;
using System.Threading.Tasks;

namespace HarfliSayili
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Main(" + Thread.CurrentThread.ManagedThreadId + ")");
            Harfler();
            Sayilar();
            Console.WriteLine("Merhaba");

            Console.ReadKey();
        }

        async static Task Sayilar()
        {
            //Console.WriteLine("sayilar(" + Thread.CurrentThread.ManagedThreadId + ")");
            for (int i = 1; i <= 26; i++)
            {
                await Task.Delay(100);
                Console.Write(i + " ");
            }
        }

        async static Task Harfler()
        {
            //Console.WriteLine("harfler(" + Thread.CurrentThread.ManagedThreadId + ")");
            for (char c = 'A'; c <= 'Z'; c++)
            {
                await Task.Delay(100);
                Console.Write(c + " ");
            }
        }
    }
}
