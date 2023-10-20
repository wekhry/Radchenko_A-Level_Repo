using Api.Models;
using Api.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            var createdUser = _userService.CreateUser(user);

            return CreatedAtAction(nameof(GetUser), new { id = createdUser.Id }, createdUser);
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _userService.GetUserById(id);

            if (user == null)
            {
                return NotFound(new {message = "User not found"});
            }

            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userService.GetUsers();
            return Ok(users);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User user)
        {
            var updatedUser = _userService.UpdateUser(id, user);

            if(updatedUser == null)
            {
                return NotFound(new { message = "User not found" });
            }
            return Ok(updatedUser);
        }

        [HttpPatch("{id}")]
        public IActionResult UpdateUserPartial(int id, [FromBody] JsonPatchDocument<User> patchDocument)
        {
            var existingUser = _userService.GetUserById(id);

            if(existingUser == null)
            {
                return NotFound(new { message = "User not found" });
            }

            var patchedUser = new User();
            patchDocument.ApplyTo(patchedUser);

            if(string.IsNullOrEmpty(patchedUser.Name))
            {
                ModelState.AddModelError("Name", "Name is required");
            }

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedUser = _userService.UpdateUserPartial(id, patchedUser);

            return Ok(updatedUser);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var deleted = _userService.DeleteUser(id);

            if(!deleted)
            {
                return NotFound(new { message = "User not found" });
            }

            return NoContent();
        }

    }
}
