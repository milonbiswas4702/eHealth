using financial_limit_access_permission.Data;
using financial_limit_access_permission.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace financial_limit_access_permission.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LimitAccessController : ControllerBase
    {
        private readonly LimitAccessContext _context;
        public LimitAccessController(LimitAccessContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public List<LimitAccessPermission> Get()
        {
            var modelOnes = _context.LimitAccessPermissions.ToList();
            return modelOnes;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public LimitAccessPermission Get(string id)
        {
            return _context.LimitAccessPermissions.SingleOrDefault(c => c.LimitId == id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public LimitAccessPermission Post([FromBody] LimitAccessPermission user)
        {
            _context.LimitAccessPermissions.Add(user);
            _context.SaveChanges();
            return user;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public LimitAccessPermission Put([FromBody] LimitAccessPermission pageDefination)
        {
            _context.Entry(pageDefination).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return pageDefination;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public string Delete(string id)
        {
            var modelOne = _context.LimitAccessPermissions.Find(id);
            if (modelOne != null)
            {
                _context.LimitAccessPermissions.Remove(modelOne);
                _context.SaveChanges();
            }
            return "" + modelOne.LimitId + " Deleted Successfully";
        }
    }
}
