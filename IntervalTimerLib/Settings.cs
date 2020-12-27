using System.Collections.Generic;

namespace IntervalTimerLib
{
    public class Settings
    {
        public List<string> ListSound { get; set; }
        public int CurrentSound { get; set; }
        public List<Time> ListTimers { get; set; }
        public bool IsTransitTimer { get; set; }
        public Time TransitTimer { get; set; }
        
    }
}