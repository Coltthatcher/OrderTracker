using System.Collections.Generic;

namespace OrderTracker.Modelse
{
  public class Order
    {
      public string Title { get; set; }
      public string Description { get; set; }

      public int Price {get; set; }

      public string Date {get; set; }
      public int id {get; set; }
    
    private static List<Order> _orders = new List<Order> {};
    }

}