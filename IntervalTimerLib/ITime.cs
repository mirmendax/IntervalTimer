using System;

namespace IntervalTimerLib
{
    public interface ITime
    {
        int Hour { get; }
        int Min { get; }
        int Sec { get; }
        bool IsDone { get; }
        event EventHandler TimerIsDone;
        void Tick();
        void Reset();
    }
}