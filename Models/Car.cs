using System.ComponentModel.DataAnnotations;
namespace gregslist_infinite.Models
{
  public class Car
  {
    public string Id { get; set; }
    public string Model { get; set; }
    public string Make { get; set; }
    public string Color { get; set; }
    public string Image { get; set; }

    // Car Constructor
    public Car(string model, string make, string color, string image)
    {
      Id = Guid.NewGuid().ToString();
      Model = model;
      Make = make;
      Color = color;
      Image = image;
    }
  }
}