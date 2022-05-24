using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gregslist_infinite.Models;
using gregslist_infinite.FakeDB;

namespace gregslist_infinite.Services
{
  public class HousesService
  {
    // get All
    internal List<House> Get()
    {
      return Database.Houses;
    }
    // get by Id
    internal House Get(string id)
    {
      House? house = Database.Houses.Find(h => h.Id == id);
      if (house == null)
      {
        throw new Exception("Invalid House Id");
      }
      return house;
    }
    // Create
    internal House Create(House houseData)
    {
      Database.Houses.Add(houseData);
      return houseData;
    }
    // Edit
    internal House Edit(House houseData)
    {
      House original = Get(houseData.Id);
      original.Address = houseData.Address ?? original.Address;
      original.Price = houseData.Price != 0 ? houseData.Price : original.Price;
      original.Description = houseData.Description ?? original.Description;
      original.Image = houseData.Image ?? original.Image;
      return original;
    }
    // Delete
    internal void Delete(string id)
    {
      House found = Get(id);
      Database.Houses.Remove(found);
    }

  }
}