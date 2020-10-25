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
      char type = char.Parse(data.Substring(data.Length - 1, 1));
      int time = int.Parse(data.Substring(0, data.Length - 1));

      Console.WriteLine(time);
      Console.WriteLine(type);

    }

    static void Start(int time, char type)
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

    }
  }
}