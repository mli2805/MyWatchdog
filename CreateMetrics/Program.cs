using System;
using System.Diagnostics;
using System.Threading;

var performanceCounterCpuLoad = new PerformanceCounter("Processor Information", "% Processor Utility", "_Total");

// call this every second or so
while (true)
{
    var percent = (int)performanceCounterCpuLoad.NextValue();
    Console.WriteLine(percent);
    await Task.Delay(1000);
}
