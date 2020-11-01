using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentaCar_Praksa.Dal.Repositories;
using RentaCar_Praksa.Dal.ViewModel;

namespace RentaCar_Praksa.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
           var users= await _userRepository.GetUsers();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody]UserDto user)
        {
            var id = await _userRepository.SaveUser(user);
            return Ok(id);
        }


        [HttpPut]
        public async Task<IActionResult> Edit(int userId, [FromBody]UserDto user)
        {
            await _userRepository.EditUser(userId, user);
            return Ok(userId);
        }


    }
}