using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchOOP
{
    internal class StopWatch
    {
        
        private DateTime startTime;
        private DateTime endTime;

        
        public DateTime StartTime => startTime;
        public DateTime EndTime => endTime;

        
        public StopWatch()
        {
            
            startTime = DateTime.Now;
        }

        
        public void Start()
        {
            startTime = DateTime.Now;
        }

        
        public void Stop()
        {
            endTime = DateTime.Now;
        }

        
        public double GetElapsedTime()
        {
            return (endTime - startTime).TotalMilliseconds;
        }
    }
}
