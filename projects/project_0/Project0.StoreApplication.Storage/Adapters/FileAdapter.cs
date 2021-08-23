using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Storage.Adapters
{
  public class FileAdapter
  {
    public F ReadFromFile<F>(string path) where F : class
    {
      // open file
      var file = new StreamReader(path);
      // serialize object
      var xml = new XmlSerializer(typeof(F));
      // read from file
      var result = xml.Deserialize(file) as F;
      // return data
      return result;
    }

    public void WriteToFile(List<Store> stores)
    {
      // file path
      var path = @"/home/fred/revature/fred_repo/data/project_0.xml";
      // open file
      var file = new StreamWriter(path);
      // serialize object
      var xml = new XmlSerializer(typeof(List<Store>));
      // write to file
      xml.Serialize(file, stores);
    }

    public void UseReadFile()
    {
      ReadFromFile<Store>("path");
    }
  }
}