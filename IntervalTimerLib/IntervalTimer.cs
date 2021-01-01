using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;


namespace IntervalTimerLib
{
    public class IntervalTimer
    {
        public static bool Cancel = false;
        
        private List<Time> _timers = new List<Time>();


        public int MaxCount => _timers.Count;

        private int count = 0;

        public int Count
        {
            get { return count; }
        }

        public bool isDone = false;

        public event EventHandler IntervalTimerIsDone;
        public event EventHandler TimerIsDone;
        

        public bool IsTransitTime { get; set; }
        
        public Time TransitTime;

        public IntervalTimer(List<Time> timers, bool isTransitTime = false, Time transitTime = null)
        {
            
            foreach (var timer in timers)
            {
                timer.TimerIsDone += (o, e) => { TimerIsDone?.Invoke(o,e); };
                _timers.Add(timer);
            }
            IsTransitTime = isTransitTime;
            TransitTime = transitTime;
        }
        
        
        private Task PlaySound()
        {
            var set = SettingsContext.GetSettings();
            var soundFile = set.Settings.ListSound?[set.Settings.CurrentSound];
            try
            {
                SoundPlayer sp = new SoundPlayer(soundFile);
                sp.Play();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return Task.CompletedTask;
        }
        
        public async Task Start()
        {
            while (!(count == MaxCount) && !Cancel)
            {
               
                
                await PlaySound();
                while (!_timers[count].IsDone && !Cancel)
                {
                    await Task.Delay(1000);
                    _timers[count].Tick();
                }
                await PlaySound();
                if (IsTransitTime)
                {
                    //Console.WriteLine("Transit Timer");
                    while (!TransitTime.IsDone && !Cancel)
                    {
                        
                        await Task.Delay(1000);
                        TransitTime.Tick();
                    }
                    

                    if ((count + 1) != MaxCount)
                        TransitTime.Reset();
                }
                
                
                count++;

            }

            count = MaxCount - 1;
            IntervalTimerIsDone?.Invoke(this, EventArgs.Empty);
        }

        public void Reset()
        {
            count = MaxCount;
            foreach (var timer in _timers)
            {
                timer.Reset();
            }

            count = 0;
            TransitTime.Reset();
            Cancel = false;
        }

        public Time CurrentTimer => _timers?[count];

        public override string ToString()
        {
            return $"{count}/{MaxCount}";
        }
    }
}