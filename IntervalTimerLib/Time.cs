using System;
using System.Runtime.InteropServices;

namespace IntervalTimerLib
{
    public class Time 
    {
        private DateTime _timer;
        private DateTime _startTimer;

        public int Hour => _timer.Hour;
        public int Min => _timer.Minute;
        public int Sec => _timer.Second;

        public event EventHandler TimerIsDone;
        [Newtonsoft.Json.JsonIgnore]
        public bool IsDone { get; private set; } = false;

        public Time()
        {
            _timer = DateTime.Today;
        }
        [Newtonsoft.Json.JsonConstructor]
        public Time(int hour, int min, int sec) : base()
        {
            _timer = _timer.AddHours(hour).AddMinutes(min).AddSeconds(sec);
            _startTimer = _timer;
            
        }

        public void Tick()
        {
            if (_timer.Hour == 0 && _timer.Minute == 0 && _timer.Second == 0)
            {
                IsDone = true;
                TimerIsDone?.Invoke(this, EventArgs.Empty);
            }
            else
               _timer = _timer.AddSeconds(-1);

            Console.WriteLine(this.ToString());
        }

        public void Reset()
        {
            _timer = _startTimer;
            IsDone = false;
        }

        public override string ToString()
        {
            var h = (Hour < 10) ? $"0{Hour}" : Hour.ToString();
            var m = (Min < 10) ? $"0{Min}" : Min.ToString();
            var s = (Sec < 10) ? $"0{Sec}" : Sec.ToString();
            return $"{h}:{m}:{s}";
        }
    }
}