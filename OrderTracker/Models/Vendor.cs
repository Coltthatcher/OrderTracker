using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor> {};

    public string Description { get; set; }
    public string Name { get; set; }

    public int id { get; set; }
    public List<Order> Orders { get; set; }
  }

}