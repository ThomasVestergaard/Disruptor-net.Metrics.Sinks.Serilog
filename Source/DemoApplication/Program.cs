using System;
using DisruptorMetricsDemo;

namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            



            var queue = new Queue();
            queue.Start();

            Console.WriteLine("Hit any to start.");
            Console.ReadKey();

            string key = "";

            var qItem1 = new QueueItem { IntValue = 10, StringValue = "Blarh" };
            while (key != "a")
            {
                queue.Enqueue(qItem1);
            }


            queue.Stop();
        }
    }
}
