using AbdurakhmanovAIi_KT_42_20.Database;
using AbdurakhmanovAIi_KT_42_20.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AbdurakhmanovAIi_KT_42_20.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupsController : ControllerBase
    {
        private readonly ILogger<GroupsController> _logger;
        private StudentDbContext _context;

        public GroupsController(ILogger<GroupsController> logger, StudentDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        [HttpPost("AddGroup")]
        public IActionResult CreateGroup([FromBody] Group student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Groups.Add(student);
            _context.SaveChanges();
            return Ok(student);
        }

        [HttpPut("EditGroup")]
        public IActionResult UpdateGroup(string name, [FromBody] Group updatedGroup)
        {
            var existingGroup = _context.Groups.FirstOrDefault(g => g.GroupName == name);

            if (existingGroup == null)
            {
                return NotFound();
            }

            existingGroup.GroupName = updatedGroup.GroupName;
            existingGroup.GroupJob = updatedGroup.GroupJob;
            existingGroup.GroupYear = updatedGroup.GroupYear;
            existingGroup.StudentQuantity = updatedGroup.StudentQuantity;
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("DeleteGroup")]
        public IActionResult DeleteGroup(string name, [FromBody] Group deletedGroup)
        {
            var existingGroup = _context.Groups.FirstOrDefault(g => g.GroupName == name);

            if (existingGroup == null)
            {
                return NotFound();
            }
            //existingGroup.IsDeleted = true;
            _context.Groups.Remove(existingGroup);
            _context.SaveChanges();

            return Ok();
        }
    }
}
