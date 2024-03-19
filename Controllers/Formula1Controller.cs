namespace Formula1API.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Formula1API.Contexts;
using Formula1API.Models;

[ApiController]
[Route("api/[controller]")]
public class DriversController : ControllerBase
{
    private readonly Formula1Context formula1Context;
    public DriversController(Formula1Context _formula1Context)
    {
        formula1Context = _formula1Context;
    }

    [HttpGet]
    public async Task<ActionResult<Driver>> GetDriver()
    {
        try
        {
            List<Driver> drivers = await formula1Context.Drivers.ToListAsync();
            if( drivers != null )
            {
                return Ok(drivers);
            }
            else
            {
                return NotFound();
            }
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Driver>> Get(int id)
    {
        try
        {
            Driver? driver = await formula1Context.Drivers.FindAsync(id);
            if(driver != null)
            {
                return Ok(driver);
            }
            else
            {
                return NotFound();
            }
        }
        catch
        {
            return StatusCode(500);
        }   
    }

    [HttpGet]
    [Route("[action]/{name}")]
    public async Task<ActionResult<Driver>> GetDriverByName(string name)
    {
        try
        {
            Driver? driver = await formula1Context.Drivers.FirstOrDefaultAsync(d => d.Name == name);
            if(driver != null)
            {
                return Ok(driver);
            }
            else
            {
                return NotFound();
            }
        }
        catch 
        {
            return StatusCode(500);
        }   
    }

    [HttpPost]
    public async Task<ActionResult> Post(Driver newDriver)
    {
        try
        {
            List<Driver> drivers = await formula1Context.Drivers.ToListAsync();
            if( drivers != null )
            {
                formula1Context.Drivers.Add(newDriver);
                await formula1Context.SaveChangesAsync();
                return NoContent();
            }
            else 
            {
                return NotFound();
            }
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            Driver? driver = await formula1Context.Drivers.FindAsync(id);
            if (driver != null)
            {
                formula1Context.Drivers.Remove(driver);
                await formula1Context.SaveChangesAsync();
                return NoContent(); 
            }
            else
            {
                return NotFound(); 
            }
        }
        catch
        {
            return StatusCode(500); 
        }
    }

    [HttpPut]
    public async Task<IActionResult> Put(Driver editedDriver)
    {
        try
        {
            formula1Context.Entry(editedDriver).State = EntityState.Modified;
            await formula1Context.SaveChangesAsync();
            return NoContent();
        }
        catch
        {
            return StatusCode(500);
        }
    }
}