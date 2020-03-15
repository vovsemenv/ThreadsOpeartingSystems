using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace ThreadsOpeartingSystems
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            MainMenu();
            do {
                Console.ReadKey();
                Console.Clear();
                Thread.Sleep(Demon());
                Console.WriteLine("Press enter to run again of any other key to close program");
                key = Console.ReadKey();
            } while (key.Key == ConsoleKey.Enter);



        }
        public static int Demon()
        {
            var threads = new ThreadList();
            threads.start();
            return threads.max+100;
        }

        public static void MainMenu()
        {
            Console.WriteLine("Threads demonstration created by Vladimir Semenov");
            Console.WriteLine("For start demonstraion with random times press any key");
        }

            public static void Call()
        {
            var threads = new List<Thread>();

            for (int i = 0; i < 5; i++)
            {
                var thread = new Thread(new ThreadStart(() =>
                {
                    var rnd = new Random().Next(1000, 5000);
                    Console.WriteLine($"{rnd} started");
                    Thread.Sleep(rnd);
                    Console.WriteLine($"{rnd} done");
                }
                ));
                threads.Add(thread);
            }
            foreach (var thread in threads)
            {
                thread.Start();
            }
        }
    }
}
