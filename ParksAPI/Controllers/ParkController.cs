using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParksAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ParksAPI.Solution.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParkController : ControllerBase
  {
    private ParksContext _db;

    public ParkController(ParksContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get(string name, string state, int miles)
    {
      var query = _db.Parks.AsQueryable(); 
      if(name !=null)
      {
        query = query.Where(entry=>entry.Name == name);
      }

      if(state !=null)
      {
        query = query.Where(entry=>entry.State == state);
      }
        
      if(miles !=0)
      {
        query = query.Where(entry=>entry.Miles == miles);
      }
        
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<Park> Get(int id)
    {
        return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park park)
    {
        park.ParkId = id;
        _db.Entry(park).State = EntityState.Modified;
        _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(parkToDelete);
      _db.SaveChanges();
    }

  }
}
