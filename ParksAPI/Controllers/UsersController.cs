using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ParksAPI.Services;
using ParksAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParksAPI.Controllers
{
  [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private readonly ParksContext _db;

        public UsersController(IUserService userService, ParksContext db)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]User userParam)
        {
            var user = _userService.Authenticate(userParam.Username, userParam.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users =  _userService.GetAll();
            return Ok(users);
        }

        [AllowAnonymous]
        [HttpPost("create")]
        public IActionResult Create([FromBody]User newUser)
        {
            _userService.Create(newUser);
            return Ok(newUser);
        }
    }
}