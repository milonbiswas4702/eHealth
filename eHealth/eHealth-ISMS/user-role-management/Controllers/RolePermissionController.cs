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
    public class RolePermissionController : ControllerBase
    {
        private readonly UserRoleContext _context;
        public RolePermissionController(UserRoleContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public List<RolePermission> Get()
        {
            var modelOnes = _context.RolePermissions.ToList();
            return modelOnes;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public RolePermission Get(string id)
        {
            return _context.RolePermissions.SingleOrDefault(c => c.UserId == id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public RolePermission Post([FromBody] RolePermission pageDefination)
        {
            _context.RolePermissions.Add(pageDefination);
            _context.SaveChanges();
            return pageDefination;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public RolePermission Put([FromBody] RolePermission pageDefination)
        {
            _context.Entry(pageDefination).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return pageDefination;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public string Delete(string id)
        {
            var modelOne = _context.RolePermissions.Find(id);
            if (modelOne != null)
            {
                _context.RolePermissions.Remove(modelOne);
                _context.SaveChanges();
            }
            return "" + modelOne.UserId + " Deleted Successfully";
        }
    }
}
