using System;
using System.Threading;

namespace stopwatch_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("S = Segundos (Ex: 7s = 7 segundos");
      Console.WriteLine("M = Minutos (Ex: 7m = 7 minutos");
      Console.WriteLine("0 = Sair");
      Console.WriteLine("Quanto tempo deseja contar ?");

      string data = Console.ReadLine().ToLower();

      if (data == "0")
        Sair();

      char type = char.Parse(data.Substring(data.Length - 1, 1));
      int time = int.Parse(data.Substring(0, data.Length - 1));
      int multiplier = 1;

      if (type == 'm')
      {
        multiplier = 60;
      }


      PreStart(time * multiplier);

    }

    static void PreStart(int time)
    {
      Console.Clear();
      Console.WriteLine("Ready...");
      Thread.Sleep(1000);

      Console.WriteLine("Set...");
      Thread.Sleep(1000);

      Console.WriteLine("Go...");
      Thread.Sleep(2000);
      Start(time);
    }

    static void Start(int time)
    {
      int currentTime = 0;

      while (currentTime != time)
      {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
      }

      Console.Clear();
      Console.WriteLine("Stopwatch finalizado!");
      Thread.Sleep(3000);
      Menu();

    }

    static void Sair()
    {
      System.Environment.Exit(0);
    }

  }
}