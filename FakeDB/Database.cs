using gregslist_infinite.Models;
namespace gregslist_infinite.FakeDB
{
  public static class Database
  {
    public static List<Car> Cars { get; set; } = new List<Car>()
    {
      new Car("Scion", "Toaster", "Stainless Steal", "https://file.kelleybluebookimages.com/kbb/base/house/2005/2005-Scion-xB-FrontSide_SIXB051_505x375.jpg?interpolation=high-quality&downsize=303:*")
    };
    public static List<House> Houses { get; set; } = new List<House>()
    {
      new House("123 Parakeet North", 45000, "A beautiful treehouse.", "https://www.luxuriousmagazine.com/wp-content/uploads/2020/09/Treeful-Treehouse-in-Okinawa-Japan.jpg")
    };

  }
}