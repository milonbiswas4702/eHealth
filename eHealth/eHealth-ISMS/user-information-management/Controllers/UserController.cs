using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using user_information_management.Data;
using user_information_management.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace user_information_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserContext _context;
        public UserController(UserContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public List<User> Get()
        {
            var modelOnes = _context.Users.ToList();
            return modelOnes;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public User Get(string id)
        {
            return _context.Users.SingleOrDefault(c => c.UserId == id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public User Post([FromBody] User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public User Put([FromBody] User pageDefination)
        {
            _context.Entry(pageDefination).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return pageDefination;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public string Delete(string id)
        {
            var modelOne = _context.Users.Find(id);
            if (modelOne != null)
            {
                _context.Users.Remove(modelOne);
                _context.SaveChanges();
            }
            return "" + modelOne.UserId + " Deleted Successfully";
        }
    }
}
