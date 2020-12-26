using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace IntervalTimerLib
{
    public class IntervalTimer
    {
        private List<ITime> _timers = new List<ITime>();

        private int MaxCount => _timers.Count;

        private int count = 0;

        public bool isDone = false;

        public event EventHandler IntervalTimerIsDone;
        

        public bool IsTransitTime { get; set; }
        
        public ITime TransitTime;

        public IntervalTimer(List<ITime> timers, bool isTransitTime = false, ITime transitTime = null)
        {
            foreach (var timer in timers)
            {
                timer.TimerIsDone += (o, e) =>
                {
                    
                };
                _timers.Add(timer);
            }
            IsTransitTime = isTransitTime;
            TransitTime = transitTime;
        }

        private Task PlaySoundAsync(string soundFile)
        {
            Console.WriteLine($"Play sound in file: {soundFile}");
            SoundPlayer sp = new SoundPlayer(@"C:\Windows\Media\Alarm01.wav");
            sp.Play();
            return Task.CompletedTask;
        }
        
        public async void Start()
        {
            while (!(count == MaxCount))
            {
                await PlaySoundAsync($"begin Timer {count + 1}/{MaxCount}");
                while (!_timers[count].IsDone)
                {
                    Thread.Sleep(1000);
                    _timers[count].Tick();
                }
                await PlaySoundAsync($"end Timer {count + 1}/{MaxCount}");
                if (IsTransitTime)
                {
                    Console.WriteLine("Transit Timer");
                    while (!TransitTime.IsDone)
                    {
                        Thread.Sleep(1000);
                        TransitTime.Tick();
                    }

                    if ((count + 1) != MaxCount)
                        TransitTime.Reset();
                }
                
                
                count++;

            }
            IntervalTimerIsDone?.Invoke(this, EventArgs.Empty);
        }

        public ITime CurrentTimer => _timers[count];

        public override string ToString()
        {
            return $"{count}/{MaxCount}";
        }
    }
}