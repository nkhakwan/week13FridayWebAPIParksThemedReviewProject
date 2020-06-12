using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using StateNationalPks.Models;


namespace StateNationalPks.Controllers
{
  [Authorize]
  [Produces("application/json")]
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private StateNationalPksContext _db;

    public ParksController(StateNationalPksContext db)
    {
      _db = db;
    }

    // GET api/parks
    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get(int rating, string type, string name) // binds query parameter to this string description
    {
      var query = _db.Parks.AsQueryable(); // returns all Parks in database as a queryable LINQ object
      if (type == null && name == null && rating == 0)
      {
       return _db.Parks.ToList();
      }

      if (rating > 0)
      {
        query = query.Where(entry => entry.Rating == rating);
      }
      
      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      return query.ToList(); 
    }
    // GET api/parks/5
    [HttpGet("{id}")] 
    public ActionResult<Park> Get(int id)
    {
      return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
    }
    
    
    // POST api/parks
    [HttpPost] // adds new api entry
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }

    // PUT api/parks/5
    [HttpPut("{id}")] // edits existing api entry
    public void Put(int id, [FromBody] Park park)
    {
      park.ParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      _db.SaveChanges();
    }

    
    // DELETE api/parks/5
    [HttpDelete("{id}")] // deletes existing api entry
    public void Delete(int id)
    {
      var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(parkToDelete);
      _db.SaveChanges();
    }
  }
}