// procedural programming - DONE
// functional programming lite - DONE
// object-oriented programming - DONE
// unit testing - DONE
// generics - DONE
// design patterns: singleton - DONE
// structure: SOLID - DONE
// serialization - DONE
// monitoring - DONE
// debugging - DONE

using System;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;

namespace Project0.StoreApplication.Client
{
  class Program
  {
    private static readonly StoreRepository _storeRepository = StoreRepository.Instance;

    static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

      var program = new Program();

      program.CaptureOutput();
    }

    private void OutputStores()
    {
      // verbose
      // debug
      // info
      // warn
      // error
      // fatal

      Log.Information("mehtod outpoutstores");

      foreach (var store in _storeRepository.Stores)
      {
        Console.WriteLine(store);
      }
    }

    private int CaptureInput()
    {
      Log.Information("in method captureinput");

      OutputStores();

      Console.WriteLine("pick a store:");

      int selected = int.Parse(Console.ReadLine());

      return selected - 1;
    }

    private void CaptureOutput()
    {
      Console.WriteLine("you have selected: " + " " + _storeRepository.Stores[CaptureInput()]);
    }
  }
}
