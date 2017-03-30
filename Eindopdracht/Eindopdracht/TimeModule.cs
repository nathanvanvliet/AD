using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Eindopdracht
{
    class TimeModule
    {
        private TimeSpan time;
        private Stopwatch stopwatch = new Stopwatch();
        private Boolean isRunning = false;

        public TimeModule()
        {

        }

        /// <summary>
        ///     Start the time module
        /// </summary>
        public void start()
        {
            try
            {
                if (!isRunning)         //if the stopwatch is already running you can't start an other one.
                {
                    Debug.WriteLine("Time measurement started.");
                    stopwatch.Start();
                    isRunning = true;
                }
                else
                {                       // if there is one running send a message to the debugger but send it to the user
                    Debug.WriteLine("There is already a measurment ongoing.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///     stop the time module and save the total time elapsed.
        /// </summary>
        public void stop()
        {
            try
            {
                if (isRunning)
                {
                    stopwatch.Stop();
                    time = stopwatch.Elapsed;

                    Debug.WriteLine("Time measurement Stopped.");
                    Debug.WriteLine("Elapsed Ticks: " + elapseTime());
                    Debug.WriteLine("=====================");
                }
                else
                {
                    Debug.WriteLine("There is already a measurment ongoing.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///     calculated the amount of ticks from the time elapsed
        /// </summary>
        /// <returns>amount of ticks</returns>
        public long elapseTime()
        {
            return time.Ticks;
        }
    }
}
