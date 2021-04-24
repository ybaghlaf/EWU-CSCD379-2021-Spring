using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SecretSanta.Data;
using SecretSanta.Business;
using System;

namespace SecretSanta.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserRepository UserRepository {get;}

        public UsersController(IUserRepository userRepository){
            UserRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        // /api/gifts
        [HttpGet]
        public IEnumerable<User> Get(){
            return UserRepository.List();
        }

        // /api/gifts/index
        [HttpGet("{index}")]
        public string Get(int index){
            //return DeleteMe.users[index];
            return "";
        }

        //DELETE /api/gifts/index
        [HttpDelete("{index}")]
        public void Delete(int index){
            DeleteMe.users.RemoveAt(index);
        }

        // POST /api/gifts/
        public void Post([FromBody] string FirstName, string LastName){
          //  DeleteMe.users.Add(FirstName, LastName);
        }

        [HttpPut("{index}")]
        public void Put(int index, [FromBody] string giftName){
          //  DeleteMe.users[index] = giftName;
        }
    }
}