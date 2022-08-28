using feature_access_permission.Data;
using feature_access_permission.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace feature_access_permission.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageDefinationController : ControllerBase
    {
        private readonly AccessPermissionContext _context;
        public PageDefinationController(AccessPermissionContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public List<PageDefination> Get()
        {
            var modelOnes = _context.PageDefinations.ToList();
            return modelOnes;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public PageDefination Get(string id)
        {
            return _context.PageDefinations.SingleOrDefault(c => c.PageId == id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public PageDefination Post([FromBody] PageDefination pageDefination)
        {
            _context.PageDefinations.Add(pageDefination);
            _context.SaveChanges();
            return pageDefination;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public PageDefination Put([FromBody] PageDefination pageDefination)
        {
            _context.Entry(pageDefination).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return pageDefination;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public string Delete(string id)
        {
            var modelOne = _context.PageDefinations.Find(id);
            if (modelOne != null)
            {
                _context.PageDefinations.Remove(modelOne);
                _context.SaveChanges();
            }
            return "" + modelOne.PageId + " Deleted Successfully";
        }
    }
}
