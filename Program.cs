using System;
using System.Threading;

namespace stopwatch_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      start();
    }

    static void start()
    {
      int time = 10;
      int currentTime = 0;

      while (currentTime != time)
      {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
      }

    }
  }
}