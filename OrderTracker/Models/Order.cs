using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; set; }

    private static List<Order> _orders = new List<Order> {};

    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _orders.Add(this);
      Id = _orders.Count;
    }

    public static void ClearAll()
    {
      _orders.Clear();
    }
    
    public static List<Order> GetAll()
    {
      return _orders;
    }

    public static Order Find(int searchId)
    {
      return _orders[searchId - 1];
    }
  }
}