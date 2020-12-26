using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using IntervalTimerLib;

namespace TestTimer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var time = new Time(0, 0, 10);
            var time2 = new Time(0, 0, 17);
            var time3 = new Time(0, 0, 8);
            var list = new List<ITime>();
            list.Add(time);
            list.Add(time2);
            list.Add(time3);
            var interval = new IntervalTimer(list);
            interval.IsTransitTime = true;
            interval.TransitTime = new Time(0, 0, 5);
            interval.IntervalTimerIsDone += (sender, eventArgs) => 
                Console.WriteLine("End all timers"); 
            interval.Start();
            Console.ReadLine();
        }
    }
}