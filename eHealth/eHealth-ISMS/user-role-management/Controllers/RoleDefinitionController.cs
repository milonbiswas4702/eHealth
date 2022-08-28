using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using user_role_management.Data;
using user_role_management.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace user_role_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleDefinitionController : ControllerBase
    {
        private readonly UserRoleContext _context;
        public RoleDefinitionController(UserRoleContext context)
        {
                _context= context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public List<RoleDefinition> Get()
        {
            var modelOnes = _context.RoleDefinitions.ToList();
            return modelOnes;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public RoleDefinition Get(string id)
        {
            return _context.RoleDefinitions.SingleOrDefault(c => c.RoleId == id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public RoleDefinition Post([FromBody] RoleDefinition pageDefination)
        {
            _context.RoleDefinitions.Add(pageDefination);
            _context.SaveChanges();
            return pageDefination;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public RoleDefinition Put([FromBody] RoleDefinition pageDefination)
        {
            _context.Entry(pageDefination).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return pageDefination;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public string Delete(string id)
        {
            var modelOne = _context.RoleDefinitions.Find(id);
            if (modelOne != null)
            {
                _context.RoleDefinitions.Remove(modelOne);
                _context.SaveChanges();
            }
            return "" + modelOne.RoleId + " Deleted Successfully";
        }
    }
}
