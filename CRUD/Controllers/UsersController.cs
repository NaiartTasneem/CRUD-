using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRUD.Models;

namespace CRUD.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
       
        [HttpGet]
        public ActionResult<List<User>> GetAll()
        {
            return UsersRepo.GetAll();
        }
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id )
        {
            var user = UsersRepo.GetUser(id);
            if (user == null)
                return NotFound();
            return Ok(user);
            
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var user = UsersRepo.GetUser(id);
            if (user == null)
                return NotFound();
            UsersRepo.Delete(id);
            return Ok();

        }

        [HttpPost]
        public ActionResult Create(User newUser)
        {
            UsersRepo.Add(newUser);
            return Ok();
        }
        
        [HttpPut]
        public ActionResult Update(User user)
        {
            var _user = UsersRepo.GetUser(user.Id);
            if (_user == null)
                return NotFound();
            UsersRepo.Update(user);
            return Ok();
        }
    }
}
