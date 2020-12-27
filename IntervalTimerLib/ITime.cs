using System;

namespace IntervalTimerLib
{
    public interface ITime
    {
        int Hour { get; }
        int Min { get; }
        int Sec { get; }
        
        [Newtonsoft.Json.JsonIgnore]
        bool IsDone { get; }
        event EventHandler TimerIsDone;
        void Tick();
        void Reset();
    }
}