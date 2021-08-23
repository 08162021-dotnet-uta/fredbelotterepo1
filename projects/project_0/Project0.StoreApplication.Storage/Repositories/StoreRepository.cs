using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository
  {
    private const string _path = @"/home/fred/revature/fred_repo/data/stores.xml";

    public List<Store> Stores { get; }

    private StoreRepository()
    {
      var fileAdapter = new FileAdapter();

      if (fileAdapter.ReadFromFile<List<Store>>(_path) == null)
      {
        fileAdapter.WriteToFile(new List<Store>()
        {
          new AthleticStore(),
          new GroceryStore(),
          new OnlineStore()
        });
      }

      Stores = fileAdapter.ReadFromFile<List<Store>>(_path);
    }

    private static StoreRepository _storeRepository;

    public static StoreRepository Instance
    {
      get
      {
        if (_storeRepository == null)
        {
          _storeRepository = new StoreRepository();
        }

        return _storeRepository;
      }
    }
  }
}
