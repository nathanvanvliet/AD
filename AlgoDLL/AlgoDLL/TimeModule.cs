/*
 * 
 * 
 * AUTEUR: Nathan van Vliet
 * Source: https://www.codeproject.com/Articles/2635/High-Performance-Timer-in-C
 * 
 * 
 * We switched to performance counter because stopwatch isn't thread safe
 * source: https://stackoverflow.com/questions/6664538/is-stopwatch-elapsedticks-threadsafe
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlgoDLL
{
   
    public class TimeModule
    {
        // import DLL 
        [DllImport("Kernel32.dll")]
        // create performance counter
        private static extern bool QueryPerformanceCounter(
          out long lpPerformanceCount);

        // import DLL
        [DllImport("Kernel32.dll")]
        // create performance frequency
        private static extern bool QueryPerformanceFrequency(
            out long lpFrequency);

        // long starttime, stoptime and freq for storing values 
        private long startTime, stopTime;
        private long freq;
        

        /// <summary>
        /// Constructor
        /// Sets priority to high, (re)sets the variables and checks if the counter is supported by the OS
        /// </summary>
        public TimeModule()
        {
            //Set Process priority & affinity
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            Process.GetCurrentProcess().ProcessorAffinity = (IntPtr)0x0001;

            // (re)set variables to zero
            startTime = 0;
            stopTime = 0;
            freq = 0;

            if (QueryPerformanceFrequency(out freq) == false)
            {
                // if the performance counter is not supported
                throw new Win32Exception();
            }
        }


        /// <summary>
        /// Start the timer
        /// </summary>
        public void Start()
        {
                // lets do the waiting threads there work
                Thread.Sleep(0);
                // start performance counter, set start time
                QueryPerformanceCounter(out startTime);
        }

        
        /// <summary>
        /// Stop the timer
        /// </summary>
        public void Stop()
        {
                // stop performance counter, set stop time
                QueryPerformanceCounter(out stopTime);
        }

         
        /// <summary>
        /// Returns the duration of the timer (in milliseconds)
        /// </summary>
        public double Duration
        {
            get
            {
                // calculate and return the duration in MS
                return ((double)(stopTime - startTime) / (double)freq) * 1000;
            }
        }
    }
}
