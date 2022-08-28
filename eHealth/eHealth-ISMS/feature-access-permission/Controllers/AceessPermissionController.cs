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
    public class AceessPermissionController : ControllerBase
    {
        private readonly AccessPermissionContext _context;
        public AceessPermissionController(AccessPermissionContext context)
        {
            _context = context;
        }
        // GET: api/<AceessPermissionController>
        [HttpGet("GetAccessPermissions")]
        public List<AccessPermission> GetAccessPermissions()
        {
            var modelOnes = _context.AccessPermissions.ToList();
            return modelOnes;
        }

        // GET api/<AceessPermissionController>/5
        [HttpGet("GetAccessPermission/{id}")]
        public AccessPermission GetAccessPermission(string id)
        {
            return _context.AccessPermissions.SingleOrDefault(c => c.UserId == id);
        }

        // POST api/<AceessPermissionController>
        [HttpPost("PostAccessPermission")]
        public AccessPermission PostAccessPermission([FromBody] AccessPermission accessPermission)
        {
            _context.AccessPermissions.Add(accessPermission);
            _context.SaveChanges();
            return accessPermission;
        }

        // PUT api/<AceessPermissionController>/5
        [HttpPut("PutAccessPermission/{id}")]
        public AccessPermission PutAccessPermission(string id, [FromBody] AccessPermission accessPermission)
        {
            _context.Entry(accessPermission).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return accessPermission;
        }

        // DELETE api/<AceessPermissionController>/5
        [HttpDelete("DeleteAccessPermission/{id}")]
        public string DeleteAccessPermission(string id)
        {
            var modelOne = _context.AccessPermissions.Find(id);
            if (modelOne != null)
            {
                _context.AccessPermissions.Remove(modelOne);
                _context.SaveChanges();
            }
            return "" + modelOne.UserId + " Deleted Successfully";
        }

        private bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
