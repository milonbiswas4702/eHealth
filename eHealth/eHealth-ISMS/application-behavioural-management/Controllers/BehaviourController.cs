using application_behavioural_management.Data;
using application_behavioural_management.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace application_behavioural_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BehaviourController : ControllerBase
    {
        private readonly BehaviourContext _context;
        public BehaviourController(BehaviourContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public List<SecurityPolicySetupMaster> Get()
        {
            var modelOnes = _context.SecurityPolicySetupMasters.ToList();
            return modelOnes;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public SecurityPolicySetupMaster Get(string id)
        {
            return _context.SecurityPolicySetupMasters.SingleOrDefault(c => c.License == id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public SecurityPolicySetupMaster Post([FromBody] SecurityPolicySetupMaster pageDefination)
        {
            _context.SecurityPolicySetupMasters.Add(pageDefination);
            _context.SaveChanges();
            return pageDefination;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public SecurityPolicySetupMaster Put([FromBody] SecurityPolicySetupMaster pageDefination)
        {
            _context.Entry(pageDefination).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return pageDefination;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public string Delete(string id)
        {
            var modelOne = _context.SecurityPolicySetupMasters.Find(id);
            if (modelOne != null)
            {
                _context.SecurityPolicySetupMasters.Remove(modelOne);
                _context.SaveChanges();
            }
            return "" + modelOne.License + " Deleted Successfully";
        }
    }
}
