using System;
using System.Threading;

namespace CSharp_TP3
{
    public static class Threads
    {
        private static Mutex _mutex = new Mutex();
        private static string print1 = "_";
        private static string print2 = "*";
        private static string print3 = "°";

        public static void Run()
        {

            TimerCallback timerCallback = new TimerCallback(PrintMessage);   

            _mutex.WaitOne(); 
            System.Threading.Timer timer = new Timer(timerCallback, print1, 1000, 50); 
            System.Threading.Timer timer2 = new Timer(timerCallback, print2, 1000, 40); 
            System.Threading.Timer timer3 = new Timer(timerCallback, print3, 1000, 20); 
            Console.ReadLine(); 
            _mutex.ReleaseMutex();
        }

        public static void PrintMessage(object msg)
        {
            Console.WriteLine(msg);
        }
    }
}
