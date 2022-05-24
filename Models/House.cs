using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregslist_infinite.Models
{
  public class House
  {
    public string Id { get; set; }
    public string Address { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public House(string address, int price, string description, string image)
    {
      Id = Guid.NewGuid().ToString();
      Address = address;
      Price = price;
      Description = description;
      Image = image;
    }
  }
}