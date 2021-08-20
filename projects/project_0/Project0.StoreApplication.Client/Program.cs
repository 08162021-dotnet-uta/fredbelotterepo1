// procedural programming - DONE
// functional programming lite - DONE
// object-oriented programming - NEXT
// unit testing - DONE
// design patterns: singleton, factory - NEXT
// structure: SOLID - 
// serialization - 
// monitoring - 
// debugging - DONE

using System;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      var program = new Program();

      program.CaptureOutput();
    }

    private void OutputStores()
    {
      var storeRepository = new StoreRepository();

      foreach (var store in storeRepository.Stores)
      {
        Console.WriteLine(store);
      }
    }

    private int CaptureInput()
    {
      OutputStores();

      Console.WriteLine("pick a store:");

      int selected = int.Parse(Console.ReadLine());

      return selected;
    }

    private void CaptureOutput()
    {
      var storeRepository = new StoreRepository();

      Console.WriteLine("you have selected: " + " " + storeRepository.Stores[CaptureInput()]);
    }
  }
}
