using consortium_member_management.Data;
using consortium_member_management.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace consortium_member_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsortiumMemberController : ControllerBase
    {
        // GET: api/<ConsortiumMemberController>
        private readonly ConsortiumMemberContext _context;
        public ConsortiumMemberController(ConsortiumMemberContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public List<ConsortiumMember> Get()
        {
            var modelOnes = _context.ConsortiumMembers.ToList();
            return modelOnes;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ConsortiumMember Get(string id)
        {
            return _context.ConsortiumMembers.SingleOrDefault(c => c.MemberId == id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ConsortiumMember Post([FromBody] ConsortiumMember pageDefination)
        {
            _context.ConsortiumMembers.Add(pageDefination);
            _context.SaveChanges();
            return pageDefination;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ConsortiumMember Put([FromBody] ConsortiumMember pageDefination)
        {
            _context.Entry(pageDefination).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return pageDefination;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public string Delete(string id)
        {
            var modelOne = _context.ConsortiumMembers.Find(id);
            if (modelOne != null)
            {
                _context.ConsortiumMembers.Remove(modelOne);
                _context.SaveChanges();
            }
            return "" + modelOne.MemberId + " Deleted Successfully";
        }
    }
}
