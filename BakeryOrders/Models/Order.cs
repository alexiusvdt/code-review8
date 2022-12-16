using System.Collections.Generic;

namespace BakeryOrders.Models
{
  public class Order
  {
    public int Id { get; }
    public string Title { get; set; }
    public string Details { get; set; }
    public string Date { get; set; }
    public decimal Price { get; set; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string title, string details, string date, decimal price)
    {
      Title = title;
      Details = details;
      Date = date;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}