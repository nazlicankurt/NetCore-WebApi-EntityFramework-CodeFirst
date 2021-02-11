
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Context;
using WebApplication5.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {

        private DeveloperContext _context;
        public DeveloperController(DeveloperContext context)

        {
            
            this._context = context;
        }

        
        // GET: api/dev
        [HttpGet]
        public ActionResult GetAll()
        
        {
            var dev = _context.Developer.Find(1);
            //_context.SaveChanges();
            return Ok(dev);
        }

        [HttpGet("{id}")]
        public ActionResult GetValue(int id)
        {
            var dev= _context.Developer.FirstOrDefault(p => p.DeveloperId == id);
            if(dev is null) return NotFound();

            return Ok(dev);


        }

        [HttpPost]
        public ActionResult Post(Developer devDto)
        {
            var dev = new Developer { FirstName = devDto.FirstName, Email = devDto.Email };
            _context.Developer.Add(dev);
            _context.SaveChanges();
            return Ok(dev);
        }

        // PUT api/<DeveloperController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DeveloperController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var dev = _context.Developer.FirstOrDefault(p => p.DeveloperId == id);
            if (dev is null) return NotFound();

            _context.Remove(dev);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
