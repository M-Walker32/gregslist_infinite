using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using gregslist_infinite.Services;
using gregslist_infinite.Models;

namespace gregslist_infinite.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _cs;

    public CarsController(CarsService cs)
    {
      _cs = cs;
    }
    // Get All
    [HttpGet]
    public ActionResult<List<Car>> Get()
    {
      try
      {
        List<Car> cars = _cs.Get();
        return Ok(cars);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // Get by ID
    [HttpGet("{id}")]
    public ActionResult<Car> Get(string id)
    {
      try
      {
        Car car = _cs.Get(id);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // Create
    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car carData)
    {
      try
      {
        Car newCar = _cs.Create(carData);
        return Ok(newCar);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // Put
    [HttpPut]
    public ActionResult<Car> Edit(string id, [FromBody] Car carData)
    {
      try
      {
        carData.Id = id;
        Car updated = _cs.Edit(carData);
        return Ok(updated);

      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // Delete
    [HttpDelete("{id}")]
    public ActionResult<String> Delete(string id)
    {
      try
      {
        _cs.Delete(id);
        return Ok("delorted");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}