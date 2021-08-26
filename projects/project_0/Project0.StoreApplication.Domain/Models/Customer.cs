using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{
  // this is a comment
  /// <summary>
  /// This is an XML Commnet
  /// </summary>
  public class Customer
  {
    public string Name { get; set; }
    public List<Order> Orders { get; set; }

    public object Order1 { get; set; }
    public Order Order2 { get; set; }
    public Order Order3 { get; set; }

    public Customer()
    {
      Name = "Sir Net";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return $"{Name} with {Orders.Count} Orders so far";
    }
  }
}