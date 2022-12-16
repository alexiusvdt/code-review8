using System.Collections.Generic;

namespace BakeryOrders.Models
{
  public class Order
  {
    public int Id { get; }
    public string Details { get; set; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string details)
    {
      Details = details;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}