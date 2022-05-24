using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gregslist_infinite.Models;
using gregslist_infinite.FakeDB;

namespace gregslist_infinite.Services
{
  public class CarsService
  {
    //   Get all
    internal List<Car> Get()
    {
      return Database.Cars;
    }
    //  Get by id
    internal Car Get(string id)
    {
      Car? car = Database.Cars.Find(c => c.Id == id);
      if (car == null)
      {
        throw new Exception("Invalid Car Id");
      }
      return car;
    }
    // create
    internal Car Create(Car carData)
    {
      Database.Cars.Add(carData);
      return carData;
    }
    // edit
    internal Car Edit(Car carData)
    {
      Car original = Get(carData.Id);
      original.Model = carData.Model ?? original.Model;
      original.Make = carData.Make ?? original.Make;
      original.Color = carData.Color ?? original.Color;
      original.Image = carData.Image ?? original.Image;
      return original;
    }
    // delete
    internal void Delete(string id)
    {
      Car found = Get(id);
      Database.Cars.Remove(found);
    }
  }
}