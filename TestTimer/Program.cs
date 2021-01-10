using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using IntervalTimerLib;
using static IntervalTimerLib.SettingsContext;

namespace TestTimer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var time = new Time(0, 0, 10);
            var time2 = new Time(0, 0, 07);
            var time3 = new Time(0, 0, 8);
           
            var list = new List<Time> {time, time2, time3};
            
            var interval = new IntervalTimer(list);
            
            interval.IsTransitTime = true;
            interval.TransitTime = new Time(0, 0, 5);
            interval.OnIntervalTimersIsDone += (sender, eventArgs) => 
                Console.WriteLine("End all timers"); 
            interval.Start();
            //var set = GetSettings();
            //set.Settings.CurrentSound = 0;
            //set.Settings.ListSound = new List<string> {"1.mp3", "2.mp3"};
            //set.Settings.IsTransitTimer = true;
            //set.Settings.TransitTimer = new Time(0, 0, 5);
            //set.Settings.ListTimers = list;
            //set.Save();
            
            Console.ReadLine();
        }
    }
}