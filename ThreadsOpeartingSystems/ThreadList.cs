using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadsOpeartingSystems
{
    class ThreadList
    {
        int en = 0;
        List<SpecifiedThread> batch= new List<SpecifiedThread>();
        public int max = 0;
        public ThreadList()
        {
            for (int i = 0; i < 5; i++)
            {
                var th = new SpecifiedThread(i);
                batch.Add(th);
                if (th.duration > max) max = th.duration;
            
            }

        }
        public void start()
        {
            Console.WriteLine("All threads started");
            foreach (var thread in batch)
            {
                
                Console.WriteLine($"Thread {thread.cnt} STARTED for {thread.duration}ms");
                thread.Thread.Start();
                
            }

        }

    }
    class SpecifiedThread
    {
        public Thread Thread;
        public int duration;
        public int cnt;
        public SpecifiedThread(int i) { 
            duration = new Random().Next(1, 5000);
            cnt = i;
            Thread = new Thread(() => DoMethod(duration, i));
        }
        void DoMethod(int duration, int cnt) {
                
                Thread.Sleep(duration);                
                Console.WriteLine($"Thread {cnt} DONE in {duration}ms"); 
                while (Console.KeyAvailable) Console.ReadKey(true);
        }
    }


}
