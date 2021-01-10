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

        private int _count = 0;

        public int Count
        {
            get { return _count; }
        }

/*
        public bool IsDone = false;
*/

        public event EventHandler OnIntervalTimersIsDone;
        public event EventHandler OnCurrentTimerIsDone;
        

        public bool IsTransitTime { get; set; }
        
        public Time TransitTime;

        public IntervalTimer(List<Time> timers, bool isTransitTime = false, Time transitTime = null)
        {
            
            foreach (var timer in timers)
            {
                timer.TimerIsDone += (o, e) => { OnCurrentTimerIsDone?.Invoke(o,e); };
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
            while (!(_count == MaxCount) && !Cancel)
            {
               
                
                await PlaySound();
                while (!_timers[_count].IsDone && !Cancel)
                {
                    await Task.Delay(1000);
                    _timers[_count].Tick();
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
                    

                    if ((_count + 1) != MaxCount)
                        TransitTime.Reset();
                }

                if ((_count + 1) < MaxCount)
                    _count++;
                else break;

            }

            _count = MaxCount - 1;
            OnIntervalTimersIsDone?.Invoke(this, EventArgs.Empty);
        }

        public void Reset()
        {
            _count = MaxCount;
            foreach (var timer in _timers)
            {
                timer.Reset();
            }

            _count = 0;
            TransitTime.Reset();
            Cancel = false;
        }

        public Time CurrentTimer
        {
            get
            {
                if (_timers != null && _count < MaxCount && _count >= 0)
                    return _timers?[_count];
                return null;
            }
        }

        public override string ToString()
        {
            return $"{_count}/{MaxCount}";
        }
    }
}