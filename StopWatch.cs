using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Timers;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace MultiplePrograms
{
    class StopWatch
    {
         public static void StWatch()
        {

             Stopwatch stopWatch = new Stopwatch();
             stopWatch.Start();
             Thread.Sleep(10000);
             stopWatch.Stop();
             //Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

           
             string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);
             Console.WriteLine("RunTime " + elapsedTime);
            














        }

    }
}

